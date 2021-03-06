﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RSyncDir {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RSyncDir() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.RSyncDir", typeof(RSyncDir).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create folder: &quot;{0}&quot;, Error message: {1}.
        /// </summary>
        internal static string CreateFolderError {
            get {
                return ResourceManager.GetString("CreateFolderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while determining file status, filename: {0}, folder name:{1}.
        /// </summary>
        internal static string DeletedFilenameError {
            get {
                return ResourceManager.GetString("DeletedFilenameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete file: &quot;{0}&quot;, Error message: {1}.
        /// </summary>
        internal static string DeleteFileError {
            get {
                return ResourceManager.GetString("DeleteFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove folder: &quot;{0}&quot;, Error message: {1}.
        /// </summary>
        internal static string DeleteFolderError {
            get {
                return ResourceManager.GetString("DeleteFolderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to set the write time for the file: {0}.
        ///Error message: {1}.
        /// </summary>
        internal static string FailedToSetFileWriteTime {
            get {
                return ResourceManager.GetString("FailedToSetFileWriteTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to set the write time for the folder: {0}.
        ///Error message: {1}.
        /// </summary>
        internal static string FailedToSetFolderWriteTime {
            get {
                return ResourceManager.GetString("FailedToSetFolderWriteTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} changed while being backed up, omitting file from backup set.
        /// </summary>
        internal static string FileChangedWhileReadError {
            get {
                return ResourceManager.GetString("FileChangedWhileReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} changed while being backed up, this may result in a broken file.
        /// </summary>
        internal static string FileChangedWhileReadWarning {
            get {
                return ResourceManager.GetString("FileChangedWhileReadWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process file: {0}. Error message: {1}.
        /// </summary>
        internal static string FileProcessError {
            get {
                return ResourceManager.GetString("FileProcessError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was marked as partial in a previous volume, but is not marked partial in the current volume.
        /// </summary>
        internal static string FileShouldBePartialError {
            get {
                return ResourceManager.GetString("FileShouldBePartialError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File marked for deletion did not exist: {0}.
        /// </summary>
        internal static string FileToDeleteMissingError {
            get {
                return ResourceManager.GetString("FileToDeleteMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the file modification timestamp for: {0}.
        ///Error message: {1}.
        /// </summary>
        internal static string FolderModificationTimeReadError {
            get {
                return ResourceManager.GetString("FolderModificationTimeReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder was marked for deletion, but did not exist: {0}.
        /// </summary>
        internal static string FolderToDeleteMissingError {
            get {
                return ResourceManager.GetString("FolderToDeleteMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal error occured. The path {0} is not a subpath of any of the source folders: {1}..
        /// </summary>
        internal static string InternalPathMappingError {
            get {
                return ResourceManager.GetString("InternalPathMappingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The partial file record for {0} does not match the file.
        /// </summary>
        internal static string InvalidPartialFileEntry {
            get {
                return ResourceManager.GetString("InvalidPartialFileEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The partial record file is invalid.
        /// </summary>
        internal static string InvalidPartialRecordError {
            get {
                return ResourceManager.GetString("InvalidPartialRecordError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid filename detected: {0}, source folders: {1}, error message: {2}.
        /// </summary>
        internal static string InvalidRelFilenameError {
            get {
                return ResourceManager.GetString("InvalidRelFilenameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestamp information for file {0} could not be read: {1}.
        /// </summary>
        internal static string InvalidTimeStampError {
            get {
                return ResourceManager.GetString("InvalidTimeStampError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multi pass is not initialized.
        /// </summary>
        internal static string MultipassUsageError {
            get {
                return ResourceManager.GetString("MultipassUsageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} is partial from byte offset {1}.
        /// </summary>
        internal static string PartialFileAddedLogMessage {
            get {
                return ResourceManager.GetString("PartialFileAddedLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The partial file {0} was not completed.
        /// </summary>
        internal static string PartialFileIncompleteWarning {
            get {
                return ResourceManager.GetString("PartialFileIncompleteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to clean up the partial incomplete file {0}, error message: {1}.
        /// </summary>
        internal static string PartialLeftoverDeleteError {
            get {
                return ResourceManager.GetString("PartialLeftoverDeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to restore file: &quot;{0}&quot;, Error message: {1}.
        /// </summary>
        internal static string RestoreFileError {
            get {
                return ResourceManager.GetString("RestoreFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder did not exist on restore by delta: {0}.
        /// </summary>
        internal static string RestoreFolderDeltaError {
            get {
                return ResourceManager.GetString("RestoreFolderDeltaError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder did not exist on restore: {0}.
        /// </summary>
        internal static string RestoreFolderMissingError {
            get {
                return ResourceManager.GetString("RestoreFolderMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create a snapshot: {0}.
        /// </summary>
        internal static string SnapshotFailedError {
            get {
                return ResourceManager.GetString("SnapshotFailedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The symlink information for {0} could not be read: {1}.
        /// </summary>
        internal static string SymlinkReadError {
            get {
                return ResourceManager.GetString("SymlinkReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to dispose USN helper: {0}.
        /// </summary>
        internal static string UsnDisposeFailedWarning {
            get {
                return ResourceManager.GetString("UsnDisposeFailedWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read USN data: {0}.
        /// </summary>
        internal static string UsnFailedError {
            get {
                return ResourceManager.GetString("UsnFailedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The USN journalId for volume {0} was changed from {1} to {2}, performing full file compare.
        /// </summary>
        internal static string UsnJournalIdChangedWarning {
            get {
                return ResourceManager.GetString("UsnJournalIdChangedWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USN is not supported on Linux.
        /// </summary>
        internal static string UsnNotSupportedOnLinuxError {
            get {
                return ResourceManager.GetString("UsnNotSupportedOnLinuxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stored USN number for volume {0} is {1} but the current USN is {2}, performing full file compare.
        /// </summary>
        internal static string UsnNumberingFaultWarning {
            get {
                return ResourceManager.GetString("UsnNumberingFaultWarning", resourceCulture);
            }
        }
    }
}
