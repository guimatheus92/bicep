﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.Cli {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CliResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CliResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.Cli.CliResources", typeof(CliResources).Assembly);
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
        ///   Looks up a localized string similar to {0}: Decompilation failed with fatal error &quot;{1}&quot;.
        /// </summary>
        internal static string DecompilationFailedFormat {
            get {
                return ResourceManager.GetString("DecompilationFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified output directory &quot;{0}&quot; does not exist..
        /// </summary>
        internal static string DirectoryDoesNotExistFormat {
            get {
                return ResourceManager.GetString("DirectoryDoesNotExistFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: The following experimental Bicep features have been enabled: {0}. Experimental features should be enabled for testing purposes only, as there are no guarantees about the quality or stability of these features. Do not enable these settings for any production usage, or your production environment may be subject to breaking..
        /// </summary>
        internal static string ExperimentalFeaturesDisclaimerMessage {
            get {
                return ResourceManager.GetString("ExperimentalFeaturesDisclaimerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file &quot;{0}&quot; does not exist..
        /// </summary>
        internal static string FileDoesNotExistFormat {
            get {
                return ResourceManager.GetString("FileDoesNotExistFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file path &apos;{0}&apos; contains &apos;\&apos;. Bicep does not support &apos;\&apos; in file paths on non-Windows platforms when used as command-line inputs..
        /// </summary>
        internal static string FilePathContainsBackslash {
            get {
                return ResourceManager.GetString("FilePathContainsBackslash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file pattern &apos;{0}&apos; contains &apos;\&apos;. Bicep does not support &apos;\&apos; in file paths on non-Windows platforms when used as command-line inputs..
        /// </summary>
        internal static string FilePatternContainsBackslash {
            get {
                return ResourceManager.GetString("FilePatternContainsBackslash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized arguments &quot;{0}&quot; specified. Use &quot;{1} --help&quot; to view available options..
        /// </summary>
        internal static string UnrecognizedArgumentsFormat {
            get {
                return ResourceManager.GetString("UnrecognizedArgumentsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified input &quot;{0}&quot; was not recognized as a Bicep file. Bicep files must use the .bicep extension..
        /// </summary>
        internal static string UnrecognizedBicepFileExtensionMessage {
            get {
                return ResourceManager.GetString("UnrecognizedBicepFileExtensionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified input &quot;{0}&quot; was not recognized as a Bicep or Bicep Parameters file. Valid files must either the .bicep or .bicepparam extension..
        /// </summary>
        internal static string UnrecognizedBicepOrBicepparamsFileExtensionMessage {
            get {
                return ResourceManager.GetString("UnrecognizedBicepOrBicepparamsFileExtensionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified input &quot;{0}&quot; was not recognized as a Bicep Parameters file. Bicep parameters files must use the .bicepparam extension..
        /// </summary>
        internal static string UnrecognizedBicepparamsFileExtensionMessage {
            get {
                return ResourceManager.GetString("UnrecognizedBicepparamsFileExtensionMessage", resourceCulture);
            }
        }
    }
}
