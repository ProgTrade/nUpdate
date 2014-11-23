﻿// Author: Dominic Beger (Trade/ProgTrade)
// License: Creative Commons Attribution NoDerivs (CC-ND)
// Created: 01-08-2014 12:11
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace nUpdate.Administration.UI.Controls
{
    public class ExplorerTreeView : TreeView
    {
        #region InsertType enum

        public enum InsertType
        {
            BeforeNode,
            AfterNode,
            InsideNode
        }

        #endregion

        private long _mTicks;
        private TreeNode _selectedNode;
        private TVITEM _tempTvItem;

        public ExplorerTreeView()
        {
            SetStyle(ControlStyles.Opaque, true);
            BorderStyle = BorderStyle.None;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, [MarshalAs(UnmanagedType.U4)] int msg, IntPtr wParam,
            ref TVITEM item);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, bool wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("user32.dll")]
        private static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT paintStruct);

        [DllImport("user32.dll")]
        private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT paintStruct);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawLine(
                SystemPens.ControlLight,
                new Point(e.ClipRectangle.Width - 1, 0),
                new Point(e.ClipRectangle.Width - 1, e.ClipRectangle.Height)
                );
        }

        private void PseudoSelectNode(TreeNode node, bool selected)
        {
            _tempTvItem.hItem = node.Handle;
            _tempTvItem.state = selected ? 2 : 0;
            SendMessage(Handle, 0x113f, new IntPtr(0), ref _tempTvItem);
        }

        public void SetInsertionMark(TreeNode node, InsertType insertPostion)
        {
            _tempTvItem.mask = 8;
            _tempTvItem.stateMask = 2;
            if (_selectedNode != null)
            {
                PseudoSelectNode(_selectedNode, false);
                _selectedNode = null;
            }
            if (insertPostion == InsertType.InsideNode)
            {
                PseudoSelectNode(node, true);
                _selectedNode = node;
            }
            SendMessage(Handle, 0x111a, insertPostion == InsertType.AfterNode,
                ((node == null) || (insertPostion == InsertType.InsideNode)) ? IntPtr.Zero : node.Handle);
        }

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case 15:
                {
                    var paintStruct = new PAINTSTRUCT();
                    IntPtr targetDc = BeginPaint(message.HWnd, ref paintStruct);
                    var rectangle = new Rectangle(paintStruct.rcPaint_left, paintStruct.rcPaint_top,
                        paintStruct.rcPaint_right - paintStruct.rcPaint_left,
                        paintStruct.rcPaint_bottom - paintStruct.rcPaint_top);
                    if ((rectangle.Width > 0) && (rectangle.Height > 0))
                    {
                        using (
                            BufferedGraphics graphics = BufferedGraphicsManager.Current.Allocate(targetDc,
                                ClientRectangle))
                        {
                            IntPtr hdc = graphics.Graphics.GetHdc();
                            Message m = Message.Create(Handle, 0x318, hdc, IntPtr.Zero);
                            DefWndProc(ref m);
                            graphics.Graphics.ReleaseHdc(hdc);
                            graphics.Render();
                        }
                    }
                    EndPaint(message.HWnd, ref paintStruct);
                    message.Result = IntPtr.Zero;
                    return;
                }
                case 20:
                    message.Result = (IntPtr) 1;
                    return;

                    /*case 0x20:
                LinkLabel2.SetCursor(LinkLabel2.LoadCursor(0, 0x7f00));
                message.Result = IntPtr.Zero;
                return;*/
            }
            base.WndProc(ref message);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Environment.OSVersion.Version.Major >= 6)
            {
                ShowLines = false;
                HotTracking = true;
                int lParam = SendMessage(base.Handle, 0x112d, 0, 0) | 0x40;
                SendMessage(Handle, 0x112c, 0, lParam);
                SetWindowTheme(Handle, "explorer", null);
            }
            else
                HotTracking = false;
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
            Point pt = PointToClient(new Point(drgevent.X, drgevent.Y));
            TreeNode nodeAt = GetNodeAt(pt);
            if (nodeAt == null)
                return;

            var span = new TimeSpan(DateTime.Now.Ticks - _mTicks);
            if (pt.Y < ItemHeight)
            {
                if (nodeAt.PrevVisibleNode != null)
                    nodeAt = nodeAt.PrevVisibleNode;
                nodeAt.EnsureVisible();
                _mTicks = DateTime.Now.Ticks;
            }
            else if ((pt.Y < (ItemHeight*2)) && (span.TotalMilliseconds > 250.0))
            {
                nodeAt = nodeAt.PrevVisibleNode;
                if (nodeAt.PrevVisibleNode != null)
                    nodeAt = nodeAt.PrevVisibleNode;
                nodeAt.EnsureVisible();
                _mTicks = DateTime.Now.Ticks;
            }
            if (pt.Y > ItemHeight)
            {
                if (nodeAt.NextVisibleNode != null)
                    nodeAt = nodeAt.NextVisibleNode;
                nodeAt.EnsureVisible();
                _mTicks = DateTime.Now.Ticks;
            }
            else if ((pt.Y > (ItemHeight*2)) && (span.TotalMilliseconds > 250.0))
            {
                nodeAt = nodeAt.NextVisibleNode;
                if (nodeAt.NextVisibleNode != null)
                    nodeAt = nodeAt.NextVisibleNode;
                nodeAt.EnsureVisible();
                _mTicks = DateTime.Now.Ticks;
            }
        }

        #region Nested type: PAINTSTRUCT

        [StructLayout(LayoutKind.Sequential)]
        private struct PAINTSTRUCT
        {
            public readonly IntPtr hdc;
            public readonly bool fErase;
            public readonly int rcPaint_left;
            public readonly int rcPaint_top;
            public readonly int rcPaint_right;
            public readonly int rcPaint_bottom;
            public readonly bool fRestore;
            public readonly bool fIncUpdate;
            public readonly int reserved1;
            public readonly int reserved2;
            public readonly int reserved3;
            public readonly int reserved4;
            public readonly int reserved5;
            public readonly int reserved6;
            public readonly int reserved7;
            public readonly int reserved8;
        }

        #endregion

        #region Nested type: TVITEM

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            public readonly IntPtr pszText;
            public readonly IntPtr cchTextMax;
            public readonly int iImage;
            public readonly int iSelectedImage;
            public readonly int cChildren;
            public readonly int lParam;
        }

        #endregion
    }
}