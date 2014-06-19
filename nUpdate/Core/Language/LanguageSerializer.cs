﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace nUpdate.Core.Language
{
    public class LanguageSerializer
    {
        public LanguageSerializer()
        {
            CancelButtonText = "Cancel";
            ContinueButtonText = "Continue";
            InstallButtonText = "Install";
            CloseButtonText = "Close";

            UpdateSearchDialogHeader = "Searching for updates...";

            NewUpdateDialogHeader = "New updates available.";
            NewUpdateDialogInfoText = "New updates can be downloaded for {0}.";
            NewUpdateDialogNewestVersionText = "Newest version: {0}";
            NewUpdateDialogCurrentVersionText = "Current version: {0}";
            NewUpdateDialogSizeText = "Package size: {0}";
            NewUpdateDialogChangelogText = "Changelog:";

            NoUpdateDialogHeader = "There are no new updates available.";
            NoUpdateDialogInfoText = "The application is up-to-date.";

            UpdateDownloadDialogLoadingHeader = "Updates are being downloaded...";
            UpdateDownloadDialogLoadingInfo = "Please be patient...";
            UpdateDownloadDialogLoadingPackageText = "Package is being downloaded...";
            UpdateDownloadDialogFinishedHeader = "The updates have been downloaded.";
            UpdateDownloadDialogFinishedInfoText = "Download completed.";
            UpdateDownloadDialogFinishedPackageText = "Package downloaded.";

            UpdateErrorDialogHeader = "Updating the application has failed.";
            UpdateErrorDialogErrorCodeText = "Errorcode:";

            SearchErrorCaption = "Error while searching for updates.";
            LocalDataCreationErrorCaption = "Error while creating local data.";
            LocalDataCreationErrorText = "The folder for the package data couldn't be created. {0}";
            FileTooBigErrorCaption = "The update file is too big.";
            FileTooBigErrorText = "nUpdate will not allow to install the update in order to save your RAM.";
            PackageNotFoundErrorCaption = "Package not found.";
            PackageNotFoundErrorText = "The update package couldn't be validated because it is missing.";
            InvalidSignatureErrorCaption = "Invalid signature.";
            InvalidSignatureErrorText = String.Format("The package contains an invalid signature and could be dangerous.{0}In order to avoid any security risks, nUpdate will not allow to install the package and delete it unrecoverably.",
                            Environment.NewLine);
            InvalidSignatureAndFileDeletingFailedErrorText = "The package contains an invalid signature and could be dangerous.{0}In order to avoid any security risks, nUpdate will not allow to install the package.{0}Unfortunately nUpdate could not remove the update package because of an system error. Please delete this package immediately because it could contain viruses and/or malware in order to damage your PC.{0}{1}";
        }

        /// <summary>
        /// The text of the CancelButton.
        /// </summary>
        public string CancelButtonText { get; set; }

        /// <summary>
        /// The text of the ContinueButton.
        /// </summary>
        public string ContinueButtonText { get; set; }

        /// <summary>
        /// The text of the InstallButton.
        /// </summary>
        public string InstallButtonText { get; set; }

        /// <summary>
        /// The text of the CloseButton.
        /// </summary>
        public string CloseButtonText { get; set; }

        /// <summary>
        /// The text of the header of the UpdateSearchDialog.
        /// </summary>
        public string UpdateSearchDialogHeader { get; set; }

        public string NewUpdateDialogHeader { get; set; }
        public string NewUpdateDialogInfoText { get; set; }
        public string NewUpdateDialogNewestVersionText { get; set; }
        public string NewUpdateDialogCurrentVersionText { get; set; }
        public string NewUpdateDialogSizeText { get; set; }
        public string NewUpdateDialogChangelogText { get; set; }
        public string NoUpdateDialogHeader { get; set; }
        public string NoUpdateDialogInfoText { get; set; }
        public string UpdateDownloadDialogLoadingHeader { get; set; }
        public string UpdateDownloadDialogLoadingInfo { get; set; }
        public string UpdateDownloadDialogLoadingPackageText { get; set; }
        public string UpdateDownloadDialogFinishedHeader { get; set; }
        public string UpdateDownloadDialogFinishedInfoText { get; set; }
        public string UpdateDownloadDialogFinishedPackageText { get; set; }
        public string UpdateErrorDialogHeader { get; set; }
        public string UpdateErrorDialogErrorCodeText { get; set; }

        public string SearchErrorCaption { get; set; }
        public string LocalDataCreationErrorCaption { get; set; }
        public string LocalDataCreationErrorText { get; set; }
        public string FileTooBigErrorCaption { get; set; }
        public string FileTooBigErrorText { get; set; }
        public string PackageNotFoundErrorCaption { get; set; }
        public string PackageNotFoundErrorText { get; set; }
        public string InvalidSignatureErrorCaption { get; set; }
        public string InvalidSignatureErrorText { get; set; }
        public string InvalidSignatureAndFileDeletingFailedErrorText { get; set; }
        /// <summary>
        /// Writes the properties and values to a XML-file.
        /// </summary>
        /// <param name="fileName">The path of the file.</param>
        internal void WriteXml(string fileName)
        {
            // Create a new file stream and serialize the properties
            if (!File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                XmlSerializer xml = new XmlSerializer(typeof(LanguageSerializer));
                xml.Serialize(fs, this);
                fs.Flush();
                fs.Close();
            }

            else
            {
                return;
            }
        }

        /// <summary>
        /// Reads the properties and values form a XML-file.
        /// </summary>
        /// <param name="fileName">The path of the file.</param>
        /// <returns></returns>
        internal static LanguageSerializer ReadXml(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(LanguageSerializer));
            LanguageSerializer lang = (LanguageSerializer)xml.Deserialize(fs);
            fs.Close();
            return lang;
        }

        /// <summary>
        /// Reads the properties and values form a XML-file.
        /// </summary>
        /// <param name="stream">The path of the file.</param>
        /// <returns></returns>
        internal static LanguageSerializer ReadXml(Stream stream)
        {
            XmlSerializer xml = new XmlSerializer(typeof(LanguageSerializer));
            LanguageSerializer lang = (LanguageSerializer)xml.Deserialize(stream);
            return lang;
        }
    }
}

