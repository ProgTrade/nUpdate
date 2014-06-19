﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace nUpdate.Administration.Core.Localization
{
    public class LocalizationProperties
    {
        public LocalizationProperties()
        {
            ProductTitle = "nUpdate Administration 1.1.0.0";
            CancelButtonText = "Cancel";
            ContinueButtonText = "Continue";
            SaveButtonText = "Save";
            DoneButtonText = "Done";
            CreatePackageButtonText = "Create package";

            InvalidArgumentErrorCaption = "Invalid argument found.";
            InvalidArgumentErrorText = "The entry for {0} can't be parsed to {1}.";

            MainFormHeader = "nUpdate - Administration";
            MainFormInfoText = "Welcome, you can create and manage your updates for nUpdate here.";
            MainFormProjectsGroupText = "Projects";
            MainFormOptionGroupText = "Settings";
            MainFormInformationGroupText = "Information";
            MainFormNewProjectText = "New project";
            MainFormOpenProjectText = "Open project";
            MainFormInformationText = "Information";
            MainFormSettingsText = "Preferences";
            MainFormFeedbackText = "Feedback";
            MainFormNotSupportedWarn = "Your system is not supported. Windows Vista or higher necessary...";

            NewProjectFormTitle = "New project - {0}";
            PanelSignatureHeader = "Key pair generation";
            PanelSignatureInfoText = "nUpdate uses a 4096-bit RSA-Signature to serve for the security of your update" + Environment.NewLine +
                                     "packages. The generation of these keys may take a different amount of time," + Environment.NewLine +
                                     "depending on your PC. Please be patient.";

            PanelSignatureWaitText = "Please wait while the key pair is being generated...";
            PanelGeneralHeader = "General";
            PanelGeneralNameText = "Name:";
            PanelGeneralNameWatermarkText = "The name of the project";
            PanelGeneralLanguageText = "Language:";
            PanelFtpHeader = "FTP-Data";
            PanelFtpServerText = "Adress:";
            PanelFtpServerWatermarkText = "The url of the update server";
            PanelFtpUserText = "User:";
            PanelFtpUserWatermarkText = "The username";
            PanelFtpPasswordText = "Password:";
            PanelFtpDirectoryText = "Directory:";
            PanelFtpPortText = "Port:";
            PanelFtpPortWatermarkText = "The port";
            PanelFtpPassiveConnectionText = "Passive (rated)";
            PanelFtpActiveConnectionText = "Active";

            ProjectsOverviewFormTitle = "Projects";
            ProjectsOverviewFormEditText = "Edit project";
            ProjectsOverviewFormFtpText = "Edit FTP-data";
            ProjectsOverviewFormDeleteText = "Delete";
            ProjectsOverviewFormNameText = "Name";
            ProjectsOverviewFormLanguageText= "Language";
            ProjectsOverviewFormCreationTimeText = "Created";
            ProjectsOverviewFormPackagesText = "Packages";
            ProjectsOverviewFormProjectsText = "Projects: ";

            UnknownErrorMessage = "An unknown error occured.";
            UnknownErrorCaption = "Unknown error";
            RemovalConfirmationMessage = "Are you sure you want to remove this project?";
            RemovalConfirmationCaption = "Delete project";

            AlreadyExistingWarn = "The project {0} already exists.";

            ProjectFormTitle = "{0} - nUpdate Administration 1.1.0.0";
            ProjectFormOverviewTabText = "Overview";
            ProjectFormNameLabelText = "Name:";
            ProjectFormUpdateUrlLabelText = "Update-URL:";
            ProjectFormFtpHostLabelText = "FTP-Host:";
            ProjectFormFtpDirectoryLabelText = "FTP-directory:";
            ProjectFormPackagesAmountLabelText = "Amount of packages released:";
            ProjectFormNewestPackageLabelText = "Newest package released:";
            ProjectFormInfoFileloadingLabelText = "Status of the update-info file:";
            ProjectFormCheckInfoFileStatusLinkLabelText = "Check status";
            ProjectFormProjectDataText = "Project-data";
            ProjectFormPublicKeyLabelText = "Public key:";
            ProjectFormProjectIdLabelText = "Project-ID:";
            ProjectFormPackagesTabText = "Packages";
            ProjectFormOverviewText = "Project-overview";
            ProjectFormAddButtonText = "Add";
            ProjectFormEditButtonText = "Edit";
            ProjectFormDeleteButtonText = "Delete";
            ProjectFormUploadButtonText = "Upload";
            ProjectFormHistoryButtonText = "History";
            ProjectFormVersionText = "Version";
            ProjectFormDevStageText = "Developmental stage";
            ProjectFormReleasedText = "Released";
            ProjectFormSizeText = "Size";
            ProjectFormDescriptionText = "Description";
            ProjectFormSearchText = "Search...";

            EditFormNewNameText = "New name:";
            EditFormLanguageText = "Language:";
            EditFormRenameText = "The new name of the project";
            EditFormTitle = "Edit project";

            #region "PackageAddForm

            PackageAddFormTitle = "Add new package - {0} - {1}";
            PackageAddFormGeneralItemText = "General";
            PackageAddFormChangelogItemText = "Changelog";
            PackageAddFormFilesItemText = "Files";
            PackageAddFormAvailabilityItemText = "Availability";
            PackageAddFormDevelopmentalStageLabelText = "Developmental stage:";
            PackageAddFormVersionLabelText = "Version:";
            PackageAddFormDescriptionLabelText = "Description:";
            PackageAddFormPublishCheckBoxText = "Publish this update";
            PackageAddFormPublishInfoLabelText = "Sets if the package should be uploaded yet. You can upload it later, if you disable this" + Environment.NewLine +
                                             "option. The update package will be saved locally on your PC then.";
            PackageAddFormEnvironmentLabelText = "Architecture settings:";
            PackageAddFormEnvironmentInfoLabelText = "Sets if the update package should only run on special architectures. To set any type" + Environment.NewLine +
                                                       "of architecture, choose \"AnyCPU\" as entry.";

            PackageAddFormLoadButtonText = "Load from file...";
            PackageAddFormClearButtonText = "Clear";
            PackageAddFormAddFileButtonText = "Add files...";
            PackageAddFormRemoveFileButtonText = "Remove files...";
            PackageAddFormNameHeaderText = "Name";
            PackageAddFormSizeHeaderText = "Size";
            PackageAddFormAvailableForAllRadioButtonText = "Available for all older versions";
            PackageAddFormAvailableForAllInfoText = "This package is available and can be downloaded for all older versions.";
            PackageAddFormAvailableForSomeRadioButtonText = "Available for some older versions";
            PackageAddFormAvailableForSomeInfoText = "This package is not available for the following versions.";
            PackageAddFormAddButtonText = "Add";
            PackageAddFormRemoveButtonText = "Remove";

            PackageAddFormArchiveInitializerInfoText = "Initializing archive...";
            PackageAddFormPrepareInfoText = "Preparing update...";
            PackageAddFormSigningInfoText = "Signing package...";
            PackageAddFormConfigInitializerInfoText = "Initializing config...";
            PackageAddFormUploadingPackageInfoText = "Uploading package - {0}";
            PackageAddFormUploadingConfigInfoText = "Uploading configuration...";

            PackageAddFormNoInternetWarningText = "nUpdate Administration could not verify a network connection. Some functions are disabled for now and you can only save the package on your PC. An upload is possible as soon as a network connections is given.";
            PackageAddFormNoInternetWarningCaption = "No network connection available.";
            PackageAddFormNoFilesSpecifiedWarningText = "There were no files specified for the update package. Please make sure you added an archive or some files to pack automatically.";
            PackageAddFormNoFilesSpecifiedWarningCaption = "No files for the package set.";
            PackageAddFormUnsupportedArchiveWarningText = "You added an unsupported archive type to the list. nUpdate is only able to unpack \".ZIP\"-files at the moment.";
            PackageAddFormUnsupportedArchiveWarningCaption = "Unsupported archive type.";
            PackageAddFormVersionInvalidWarningText = "The given version is invalid. You cannot use \"0.0.x.x\" as product-version. Please make sure to select a minimum Minor-version of \"1\".";
            PackageAddFormVersionInvalidWarningCaption = "Invalid package version.";
            PackageAddFormVersionExistingWarningText = "Version \"{0}\" is already existing.";
            PackageAddFormNoChangelogWarningText = "There was no changelog set for the update package.";
            PackageAddFormNoChangelogWarningCaption = "No changelog set.";
            PackageAddFormAlreadyImportedWarningText = "The file \" {0} \" is already imported. Should it be replaced by the new one?";
            PackageAddFormAlreadyImportedWarningCaption = "File already imported";

            PackageAddFormPackageDataCreationErrorCaption = "Creating package data failed.";
            PackageAddFormProjectDataLoadingErrorCaption = "Failed to load project data.";
            PackageAddFormGettingUrlErrorCaption = "Error while getting url.";
            PackageAddFormReadingPackageBytesErrorCaption = "Reading package bytes failed.";
            PackageAddFormInvalidServerDirectoryErrorCaption = "Invalid server directory.";
            PackageAddFormInvalidServerDirectoryErrorText = "The directory for the update files on the server is not valid. Please edit it.";
            PackageAddFormLoadingFtpDataErrorCaption = "Failed to load FTP-data.";
            PackageAddFormConfigurationDownloadErrorCaption = "Configuration download failed.";
            PackageAddFormSerializingDataErrorCaption = "Error on serializing data.";
            PackageAddFormRelativeUriErrorText = "The server-directory can't be set as a relative uri.";
            PackageAddFormPackageInformationSavingErrorCaption = "Saving package information failed.";
            PackageAddFormUploadFailedErrorCaption = "Upload failed.";

            #endregion
        }

        // The title in the forms
        public string ProductTitle { get; set; }

        // The "Cancel"-button text
        public string CancelButtonText { get; set; }

        // The "Continue"-button text
        public string ContinueButtonText { get; set; }

        // The "Save"-button text
        public string SaveButtonText { get; set; }

        // The "Create package"-button text
        public string CreatePackageButtonText { get; set; }

        // The caption of an "Invalid argument"-error
        public string InvalidArgumentErrorCaption { get; set; }

        // The text of an "Invalid argument"-error
        public string InvalidArgumentErrorText { get; set; }

        #region "MainForm"

        // The "Done"-button text
        public string DoneButtonText { get; set; }

        // The header in the MainForm
        public string MainFormHeader { get; set; }

        // The info text in the MainForm
        public string MainFormInfoText { get; set; }

        // The text of the "project" group in the ListView
        public string MainFormProjectsGroupText { get; set; }

        // The text of the "more options" group in the ListView
        public string MainFormOptionGroupText { get; set; }

        // The text for the "information" group in the ListView
        public string MainFormInformationGroupText { get; set; }

        // The text for the "New project"-button
        public string MainFormNewProjectText { get; set; }

        // The text for the "Open project"-button
        public string MainFormOpenProjectText { get; set; }

        // The text for the "Information"-button
        public string MainFormInformationText { get; set; }

        // The text for the "Settings"-button
        public string MainFormSettingsText { get; set; }

        // The text for the "Feedback"-button
        public string MainFormFeedbackText { get; set; }

        // The text of the "Not supported-warning"
        public string MainFormNotSupportedWarn { get; set; }

        #endregion

        #region "NewProjectForm"

        // The title of the NewProjectForm
        public string NewProjectFormTitle { get; set; }

        // The header of the signature-panel
        public string PanelSignatureHeader { get; set; }

        // The info text in the signature-panel
        public string PanelSignatureInfoText { get; set; }

        // The text of the "Loading"-label
        public string PanelSignatureWaitText { get; set; }

        // The header of the general-panel
        public string PanelGeneralHeader { get; set; }

        // The text of the "Name"-label
        public string PanelGeneralNameText { get; set; }

        // The watermark-text of the "Name"-textbox
        public string PanelGeneralNameWatermarkText { get; set; }

        // The text of the "Language"-label
        public string PanelGeneralLanguageText { get; set; }

        // The header of the Ftp-panel
        public string PanelFtpHeader { get; set; }

        // The text of the "Server"-label
        public string PanelFtpServerText { get; set; }

        // The watermark-text of the "Server"-textbox
        public string PanelFtpServerWatermarkText { get; set; }

        // The text of the "User"-label
        public string PanelFtpUserText { get; set; }

        // The watermark-text of the "User"-textbox
        public string PanelFtpUserWatermarkText { get; set; }

        // The text of the "Password"-label
        public string PanelFtpPasswordText { get; set; }

        // The text of the "Directory"-label
        public string PanelFtpDirectoryText { get; set; }

        // The text of the "Port"-label
        public string PanelFtpPortText { get; set; }

        // The watermark-text of the "Port"-textbox
        public string PanelFtpPortWatermarkText { get; set; }

        // The text of the "Passive"-combobox item
        public string PanelFtpPassiveConnectionText { get; set; }

        // The text of the "Active"-combobox item
        public string PanelFtpActiveConnectionText { get; set; }

        // The text of the warning when the project already exists
        public string AlreadyExistingWarn { get; set; }

        // The text when fields are empty
        public string FieldsEmptyWarn { get; set; }

        #endregion

        #region "ProjectsOverviewForm"

        // The title of the projects-form
        public string ProjectsOverviewFormTitle { get; set; }

        // The text of the "Edit FTP"-button
        public string ProjectsOverviewFormFtpText { get; set; }

        // The text of the "Delete"-button
        public string ProjectsOverviewFormDeleteText { get; set; }

        // The text of the "Edit"-button
        public string ProjectsOverviewFormEditText { get; set; }

        // The text of the "Name"-column
        public string ProjectsOverviewFormNameText { get; set; }

        // The text of the "Language"-column
        public string ProjectsOverviewFormLanguageText { get; set; }

        // The text of the "Creation-time"-column
        public string ProjectsOverviewFormCreationTimeText { get; set; }

        // The text of the "Packages"-column
        public string ProjectsOverviewFormPackagesText { get; set; }

        // The text of the "Projects"-label
        public string ProjectsOverviewFormProjectsText { get; set; }

        // The text of the "Unknown error"-message
        public string UnknownErrorMessage { get; set; }

        // The caption of the "Unknown error"-message
        public string UnknownErrorCaption { get; set; }   

        // The text of the "Project remove"-confirm-message
        public string RemovalConfirmationMessage { get; set; }

        // The caption of the "Project remove"-confirm-message
        public string RemovalConfirmationCaption { get; set; }

        #endregion

        #region "ProjectForm"

        // The title of the "Project"-form
        public string ProjectFormTitle { get; set; }

        // The text of the "Overview"-tabpage
        public string ProjectFormOverviewTabText { get; set; }

        // The text of the "Packages"-tabpage
        public string ProjectFormPackagesTabText { get; set; }

        // The text of the "Overview"-header
        public string ProjectFormOverviewText { get; set; }

        // The text of the "Name"-label
        public string ProjectFormNameLabelText { get; set; }

        // The text of the "Update-URL"-label
        public string ProjectFormUpdateUrlLabelText { get; set; }

        // The text of the "FTP-Host"-label
        public string ProjectFormFtpHostLabelText { get; set; }

        // The text of the "FTP-Directory"-label
        public string ProjectFormFtpDirectoryLabelText { get; set; }

        // The text of the "Amount of packages released"-label
        public string ProjectFormPackagesAmountLabelText { get; set; }

        // The text of the "Newest package released"-label
        public string ProjectFormNewestPackageLabelText { get; set; }

        // The text of the "Status of the info-file"-label
        public string ProjectFormInfoFileloadingLabelText { get; set; }

        // The text of the "Check status"-label
        public string ProjectFormCheckInfoFileStatusLinkLabelText { get; set; }

        // The text of the "Project-data"-header
        public string ProjectFormProjectDataText { get; set; }

        // The text of the "Public key"-label
        public string ProjectFormPublicKeyLabelText { get; set; }

        // The text of the "Project-ID"-label
        public string ProjectFormProjectIdLabelText { get; set; }

        // The text of the "Add"-button
        public string ProjectFormAddButtonText { get; set; }

        // The text of the "Edit"-button
        public string ProjectFormEditButtonText { get; set; }

        // The text of the "Delete"-button
        public string ProjectFormDeleteButtonText { get; set; }

        // The text of the "Upload"-button
        public string ProjectFormUploadButtonText { get; set; }

        // The text of the "History"-button
        public string ProjectFormHistoryButtonText { get; set; }

        // The text of the "Version"-column
        public string ProjectFormVersionText { get; set; }

        // The text of the "Developmental Stage"-column
        public string ProjectFormDevStageText { get; set; }

        // The text of the "Released"-coumn
        public string ProjectFormReleasedText { get; set; }

        // The text of the "Size"-column
        public string ProjectFormSizeText { get; set; }

        // The text of the "Description"-column
        public string ProjectFormDescriptionText { get; set; }

        // The watermark-text of the "Search"-textbox
        public string ProjectFormSearchText { get; set; }

        #endregion

        #region "EditForm"

        // The title of the EditForm
        public string EditFormTitle { get; set; }

        // The watermark-text of the "Rename"-textbox
        public string EditFormRenameText { get; set; }

        // The text of the "New name"-label
        public string EditFormNewNameText { get; set; }

        // The text of the "Language"-label
        public string EditFormLanguageText { get; set; }

        #endregion

        #region "PackageAddForm

        // The title of the PackageAddForm
        public string PackageAddFormTitle { get; set; }

        // The text of the "General"-item
        public string PackageAddFormGeneralItemText { get; set; }

        // The text of the "Changelog"-item
        public string PackageAddFormChangelogItemText { get; set; }

        // The text of the "Files"-item
        public string PackageAddFormFilesItemText { get; set; }

        // The text of the "Availability"-item
        public string PackageAddFormAvailabilityItemText { get; set; }

        // The text of the "Operations"-item
        public string PackageAddFormOperationsItemText { get; set; }

        // The text of the "Proxy"-item
        public string PackageAddFormProxyItemText { get; set; }

        // General-panel

        // The text of the "Developmental stage"-label
        public string PackageAddFormDevelopmentalStageLabelText { get; set; }

        // The text of the "Version"-label
        public string PackageAddFormVersionLabelText { get; set; }

        // The text of the "Description"-label
        public string PackageAddFormDescriptionLabelText { get; set; }

        // The text of the checkbox for publishing
        public string PackageAddFormPublishCheckBoxText { get; set; }

        // The text of the publishing info-label
        public string PackageAddFormPublishInfoLabelText { get; set; }

        // The text of the environment-label
        public string PackageAddFormEnvironmentLabelText { get; set; }

        // The text of the environment-info-label
        public string PackageAddFormEnvironmentInfoLabelText { get; set; }

        // Changelog-Tab

        // The text of the "Load"-button
        public string PackageAddFormLoadButtonText { get; set; }

        // The text of the "Clear"-button
        public string PackageAddFormClearButtonText { get; set; }

        // Files-tab
        
        // The text of the "Add File"-button
        public string PackageAddFormAddFileButtonText { get; set; }

        // The text of the "Remove File"-button
        public string PackageAddFormRemoveFileButtonText { get; set; }

        // The text of the "Name"-header in the listview
        public string PackageAddFormNameHeaderText { get; set; }

        // The text of the "Size"-header in the listview
        public string PackageAddFormSizeHeaderText { get; set; }

        // Availability

        // The text of the radio button for all available versions
        public string PackageAddFormAvailableForAllRadioButtonText { get; set; }

        // The text of the info for the radio button for all available versions
        public string PackageAddFormAvailableForAllInfoText { get; set; }

        // The text of the radio button for some available versions
        public string PackageAddFormAvailableForSomeRadioButtonText { get; set; }

        // The text of the info for the radio button for some available versions
        public string PackageAddFormAvailableForSomeInfoText { get; set; }

        // The text of the "Add"-button to add the versions
        public string PackageAddFormAddButtonText { get; set; }

        // The text of the "Remove"-button to remove the versions
        public string PackageAddFormRemoveButtonText { get; set; }

        // Proxy

        // The text of the CheckBox, if a proxy should be used
        public string PackageAddFormUseProxyCheckBoxText { get; set; }

        // The text of the "Host"-label
        public string PackageAddFormProxyHostLabelText { get; set; }

        // The text of the "Port"-label
        public string PackageAddFormProxyPortLabelText { get; set; }

        // The text of the "Username"-label
        public string PackageAddFormProxyUsernameLabelText { get; set; }

        // The text of the "Password"-label
        public string PackageAddFormProxyPasswordLabelText { get; set; }

        // The text of the proxy info-label
        public string PackageAddFormProxyInfoLabelText { get; set; }

        // Operations

        // The text of the "Use operations"-checkbox.
        public string PackageAddFormUseOperationsCheckBoxText { get; set; }

        // The text of the "Add operation"-button.
        public string PackageAddFormOperationAddButtonText { get; set; }

        // Information while creating

        public string PackageAddFormArchiveInitializerInfoText { get; set; }

        public string PackageAddFormPrepareInfoText { get; set; }

        public string PackageAddFormSigningInfoText { get; set; }

        public string PackageAddFormConfigInitializerInfoText { get; set; }

        public string PackageAddFormUploadingPackageInfoText { get; set; }

        public string PackageAddFormUploadingConfigInfoText { get; set; }

        // Warnings and errors

        // The caption of the error if the data could not be created
        public string PackageAddFormPackageDataCreationErrorCaption { get; set; }

        // The caption of the error if the data of the project could not be loaded
        public string PackageAddFormProjectDataLoadingErrorCaption { get; set; }

        // The caption of the error if the url for the package could not be defined
        public string PackageAddFormGettingUrlErrorCaption { get; set; }

        // The caption of the error if the package could not be read while signing
        public string PackageAddFormReadingPackageBytesErrorCaption { get; set; }

        // The caption of the error if the server directory is invalid
        public string PackageAddFormInvalidServerDirectoryErrorCaption { get; set; }

        // The text of the error if the server directory is invalid
        public string PackageAddFormInvalidServerDirectoryErrorText { get; set; }

        // The caption of the error if the FTP-data could not be loaded
        public string PackageAddFormLoadingFtpDataErrorCaption { get; set; }

        // The caption of the error if the configuration download failed
        public string PackageAddFormConfigurationDownloadErrorCaption { get; set; }

        // The caption of the error if the serializing of the data failed
        public string PackageAddFormSerializingDataErrorCaption { get; set; }

        // The text of the error if the directory can't be set as a relative uri
        public string PackageAddFormRelativeUriErrorText { get; set; }

        // The caption of the error if the saving of the package information/data fails
        public string PackageAddFormPackageInformationSavingErrorCaption { get; set; }

        // The caption of the error if the upload fails
        public string PackageAddFormUploadFailedErrorCaption { get; set; }

        // The text of the warning if there is no network available
        public string PackageAddFormNoInternetWarningText { get; set; }

        // The caption of the warning if there is no network available
        public string PackageAddFormNoInternetWarningCaption { get; set; }

        // The text of the warning when no files are specified for the package
        public string PackageAddFormNoFilesSpecifiedWarningText { get; set; }

        // The caption of the warning when no files are specified for the package
        public string PackageAddFormNoFilesSpecifiedWarningCaption { get; set; }

        // The text of the warning when there is an unsupported archive type added to the list
        public string PackageAddFormUnsupportedArchiveWarningText { get; set; }

        // The caption of the warning when there is an unsupported archive type added to the list
        public string PackageAddFormUnsupportedArchiveWarningCaption { get; set; }

        // The text of the warning when the given version is invalid
        public string PackageAddFormVersionInvalidWarningText { get; set; }

        // The text of the warning when the given version is already existing
        public string PackageAddFormVersionExistingWarningText { get; set; }

        // The caption of the warning when the given version is invalid
        public string PackageAddFormVersionInvalidWarningCaption { get; set; }

        // The text of the warning when thre is no changelog specified
        public string PackageAddFormNoChangelogWarningText { get; set; }

        // The caption of the warning when thre is no changelog specified
        public string PackageAddFormNoChangelogWarningCaption { get; set; }

        // The caption of the warning when the file is already imported
        public string PackageAddFormAlreadyImportedWarningText { get; set; }

        // The text of the warning when the file is already imported
        public string PackageAddFormAlreadyImportedWarningCaption { get; set; }

        #endregion

        ///// <summary>
        ///// Writes the properties and values to a XML-file
        ///// </summary>
        ///// <param name="fileName">The path of the file</param>
        //public void WriteXml(string fileName)
        //{
        //    // Create a new file stream and serialize the properties
        //    if (!File.Exists(fileName))
        //    {
        //        FileStream fs = new FileStream(fileName, FileMode.Create);
        //        XmlSerializer xml = new XmlSerializer(typeof(LanguageSerializer));
        //        xml.Serialize(fs, this);
        //        fs.Flush();
        //        fs.Close();
        //    }

        //    else
        //    {
        //        return;
        //    }
        //}

        ///// <summary>
        ///// Reads the properties and values form a XML-file
        ///// </summary>
        ///// <param name="fileName">The path of the file</param>
        ///// <returns></returns>
        //public static LanguageSerializer ReadXml(string fileName)
        //{
        //    FileStream fs = new FileStream(fileName, FileMode.Open);
        //    XmlSerializer xml = new XmlSerializer(typeof(LanguageSerializer));
        //    LanguageSerializer lang = (LanguageSerializer)xml.Deserialize(fs);
        //    fs.Close();
        //    return lang;
        //}
    }
}
