﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Backend.Strings {
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
    internal class FTPBackend {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FTPBackend() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.FTPBackend", typeof(FTPBackend).Assembly);
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
        ///   Looks up a localized string similar to This backend can read and write data to an FTP based backend. Allowed formats are &quot;ftp://hostname/folder&quot; or &quot;ftp://username:password@hostname/folder&quot;.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this flag is set, the FTP connection is made in active mode. Even if the &quot;ftp-passive&quot; flag is also set, the connection will be made in active mode.
        /// </summary>
        internal static string DescriptionFTPActiveLong {
            get {
                return ResourceManager.GetString("DescriptionFTPActiveLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toggles the FTP connections method.
        /// </summary>
        internal static string DescriptionFTPActiveShort {
            get {
                return ResourceManager.GetString("DescriptionFTPActiveShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this flag is set, the FTP connection is made in passive mode, which works better with some firewalls. If the &quot;ftp-regular&quot; flag is also set, this flag is ignored.
        /// </summary>
        internal static string DescriptionFTPPassiveLong {
            get {
                return ResourceManager.GetString("DescriptionFTPPassiveLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toggles the FTP connections method.
        /// </summary>
        internal static string DescriptionFTPPassiveShort {
            get {
                return ResourceManager.GetString("DescriptionFTPPassiveShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password used to connect to the server. This may also be supplied as the environment variable &quot;FTP_PASSWORD&quot;..
        /// </summary>
        internal static string DescriptionFTPPasswordLong {
            get {
                return ResourceManager.GetString("DescriptionFTPPasswordLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the password used to connect to the server.
        /// </summary>
        internal static string DescriptionFTPPasswordShort {
            get {
                return ResourceManager.GetString("DescriptionFTPPasswordShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username used to connect to the server. This may also be supplied as the environment variable &quot;FTP_USERNAME&quot;..
        /// </summary>
        internal static string DescriptionFTPUsernameLong {
            get {
                return ResourceManager.GetString("DescriptionFTPUsernameLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the username used to connect to the server.
        /// </summary>
        internal static string DescriptionFTPUsernameShort {
            get {
                return ResourceManager.GetString("DescriptionFTPUsernameShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the server and client both supports integrated authentication, this option enables that authentication method. This is likely only available with windows servers and clients..
        /// </summary>
        internal static string DescriptionIntegratedAuthenticationLong {
            get {
                return ResourceManager.GetString("DescriptionIntegratedAuthenticationLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use windows integrated authentication to connect to the server.
        /// </summary>
        internal static string DescriptionIntegratedAuthenticationShort {
            get {
                return ResourceManager.GetString("DescriptionIntegratedAuthenticationShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this flag to communicate using Secure Socket Layer (SSL) over ftp (ftps)..
        /// </summary>
        internal static string DescriptionUseSSLLong {
            get {
                return ResourceManager.GetString("DescriptionUseSSLLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instructs Duplicati to use an SSL (ftps) connection.
        /// </summary>
        internal static string DescriptionUseSSLShort {
            get {
                return ResourceManager.GetString("DescriptionUseSSLShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FTP based.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} was not found, message: {1}.
        /// </summary>
        internal static string MissingFolderError {
            get {
                return ResourceManager.GetString("MissingFolderError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The file {0} was uploaded but not found afterwards, the file listing returned {1}.
        /// </summary>
        internal static string ListVerifyFailure {
            get {
                return ResourceManager.GetString("ListVerifyFailure", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The file {0} was uploaded but the returned size was {1} and it was expected to be {2}.
        /// </summary>
        internal static string ListVerifySizeFailure {
            get {
                return ResourceManager.GetString("ListVerifySizeFailure", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Disable upload verification.
        /// </summary>
        internal static string DescriptionDisableUploadVerifyShort {
            get {
                return ResourceManager.GetString("DescriptionDisableUploadVerifyShort", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to To protect against network failures, every upload will be attempted verified. Use this option to disable this verfication to make the upload faster by more unsafe..
        /// </summary>
        internal static string DescriptionDisableUploadVerifyLong {
            get {
                return ResourceManager.GetString("DescriptionDisableUploadVerifyLong", resourceCulture);
            }
        }
}
}
