﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSDocs.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PSDocsResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSDocsResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSDocs.Resources.PSDocsResources", typeof(PSDocsResources).Assembly);
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
        ///   Looks up a localized string similar to [PSDocs][D] -- Found {0} PSDocs module(s).
        /// </summary>
        internal static string FoundModules {
            get {
                return ResourceManager.GetString("FoundModules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options file does not exist..
        /// </summary>
        internal static string OptionsNotFound {
            get {
                return ResourceManager.GetString("OptionsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PSDocs][D] -- Scanning for source files in module: {0}.
        /// </summary>
        internal static string ScanModule {
            get {
                return ResourceManager.GetString("ScanModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PSDocs][D] -- Scanning for source files: {0}.
        /// </summary>
        internal static string ScanSource {
            get {
                return ResourceManager.GetString("ScanSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script was not found..
        /// </summary>
        internal static string ScriptNotFound {
            get {
                return ResourceManager.GetString("ScriptNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create path.
        /// </summary>
        internal static string ShouldCreatePath {
            get {
                return ResourceManager.GetString("ShouldCreatePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write file.
        /// </summary>
        internal static string ShouldWriteFile {
            get {
                return ResourceManager.GetString("ShouldWriteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source was not found..
        /// </summary>
        internal static string SourceNotFound {
            get {
                return ResourceManager.GetString("SourceNotFound", resourceCulture);
            }
        }
    }
}
