﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core6502DotNet {
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
    internal class ConfigConstants {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigConstants() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Core6502DotNet.src.Utility.ConfigConstants", typeof(ConfigConstants).Assembly);
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
        ///   Looks up a localized string similar to {&quot;allowOverflow&quot;:false,&quot;caseSensitive&quot;:false,&quot;defines&quot;:[&quot;MYLABEL&quot;],&quot;ignoreColons&quot;:false,&quot;includePath&quot;:&quot;/includes&quot;,&quot;listingOptions&quot;:{&quot;labelPath&quot;:&quot;labeldump.asm&quot;,&quot;labelsAddressesOnly&quot;:false,&quot;listPath&quot;:&quot;source_list.asm&quot;,&quot;noAssembly&quot;:false,&quot;noDisassembly&quot;:false,&quot;noSource&quot;:false,&quot;truncateAssembly&quot;:false,&quot;verbose&quot;:false},&quot;loggingOptions&quot;:{&quot;checksum&quot;:false,&quot;echoEachPass&quot;:false,&quot;errorPath&quot;:&quot;errors.txt&quot;,&quot;noStats&quot;:false,&quot;noWarnings&quot;:false,&quot;quietMode&quot;:false,&quot;suppressUnusedSectionWarning&quot;:false,&quot;warnCaseMismatch&quot;:false [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CONFIG_FULL {
            get {
                return ResourceManager.GetString("CONFIG_FULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;sources&quot;:[&quot;source.asm&quot;]}.
        /// </summary>
        internal static string CONFIG_MIN {
            get {
                return ResourceManager.GetString("CONFIG_MIN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;$schema&quot;:&quot;http://json-schema.org/draft-03/schema&quot;,&quot;properties&quot;:{&quot;caseSensitive&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;ignoreColons&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;resetPCOnBank&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;allowOverflow&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;defines&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;minItems&quot;:1,&quot;uniqueItems&quot;:true},&quot;includePath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;listingOptions&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;labelPath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;listPath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;noAssembly&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;noDisassembly&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;noSource&quot;:{&quot;typ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CONFIG_SCHEMA {
            get {
                return ResourceManager.GetString("CONFIG_SCHEMA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;$schema&quot;:&quot;https://json-schema.org/draft/2020-12/schema&quot;,&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;allowOverflow&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;caseSensitive&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;defines&quot;:{&quot;$ref&quot;:&quot;#/$defs/nonEmptySet&quot;},&quot;ignoreColons&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;includePath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;listingOptions&quot;:{&quot;allOf&quot;:[{&quot;properties&quot;:{&quot;labelPath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;labelsAddressesOnly&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;listPath&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;noAssembly&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;noDisassembly&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;noSource&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;truncat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CONFIG_SCHEMA_202012 {
            get {
                return ResourceManager.GetString("CONFIG_SCHEMA_202012", resourceCulture);
            }
        }
    }
}
