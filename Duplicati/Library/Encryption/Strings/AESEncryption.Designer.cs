﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Encryption.Strings {
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
    internal class AESEncryption {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AESEncryption() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Encryption.Strings.AESEncryption", typeof(AESEncryption).Assembly);
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
        ///   Looks up a localized string similar to If the decryption fails using AES Crypt, dont attempt to use the previous encryption file format. .
        /// </summary>
        internal static string AesencryptiondontallowfallbackLong_v2 {
            get {
                return ResourceManager.GetString("AesencryptiondontallowfallbackLong_v2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not attempt to decrypt using previous method.
        /// </summary>
        internal static string AesencryptiondontallowfallbackShort {
            get {
                return ResourceManager.GetString("AesencryptiondontallowfallbackShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad key stretch.
        /// </summary>
        internal static string BadKeyStretchError {
            get {
                return ResourceManager.GetString("BadKeyStretchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This module encrypts all files in the same way that AESCrypt does, using 256 bit AES encryption..
        /// </summary>
        internal static string Description_v2 {
            get {
                return ResourceManager.GetString("Description_v2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AES-256 encryption, built-in.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
    }
}
