﻿// UpdaterUI.cs, 10.06.2019
// Copyright (C) Dominic Beger 17.06.2019

using System.Threading;
using nUpdate.Internal.Core.Localization;

namespace nUpdate
{
    public sealed partial class UpdaterUI
    {
        private readonly LocalizationProperties _lp;
#pragma warning disable IDE0051 // Nicht verwendete private Member entfernen
        private bool _active;
#pragma warning restore IDE0051 // Nicht verwendete private Member entfernen

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdaterUI" />-class.
        /// </summary>
        /// <param name="updateManager">The instance of the <see cref="UpdateManager" /> to handle over.</param>
        /// <param name="context">The synchronization context to use.</param>
        public UpdaterUI(UpdateManager updateManager, SynchronizationContext context)
            : this(updateManager, context, false)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdaterUI" /> class.
        /// </summary>
        /// <param name="updateManager">The update manager.</param>
        /// <param name="context">The context.</param>
        /// <param name="useHiddenSearch">
        ///     If set to <c>true</c> a hidden search will be provided in order to search in the
        ///     background without informing the user.
        /// </param>
        public UpdaterUI(UpdateManager updateManager, SynchronizationContext context, bool useHiddenSearch)
        {
            UpdateManager = updateManager;
            Context = context;
            UseHiddenSearch = useHiddenSearch;
            _lp = LocalizationHelper.GetLocalizationProperties(UpdateManager.LanguageCulture,
                UpdateManager.CultureFilePaths);
        }

        /// <summary>
        ///     Gets or sets the <see cref="SynchronizationContext" /> to use for mashalling the user interface specific calls to
        ///     the current UI thread.
        /// </summary>
        internal SynchronizationContext Context { get; set; }

        /// <summary>
        ///     Gets or sets the given instance of the <see cref="UpdateManager" />-class.
        /// </summary>
        internal UpdateManager UpdateManager { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether a hidden search should be provided in order to search in the background
        ///     without informing the user, or not.
        /// </summary>
        public bool UseHiddenSearch { get; set; }
    }
}