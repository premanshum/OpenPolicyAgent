//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace colonel.Policies.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("colonel.Policies.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AzureActivity 
        ///| where TimeGenerated &gt; ago({0})
        ///| where ActivityStatusValue == &quot;Success&quot;
        ///
        ///| where ResourceGroup !startswith(&quot;DATABRICKS-RG-&quot;)
        ///| where ResourceGroup !startswith(&quot;MC_&quot;)
        ///| where ResourceGroup != &quot;&quot;
        ///
        ///| where OperationNameValue !startswith(&quot;MICROSOFT.CLASSICCOMPUTE&quot;)
        ///| where OperationNameValue endswith(&quot;WRITE&quot;) or OperationNameValue endswith(&quot;DELETE&quot;) or OperationNameValue endswith(&quot;CREATE&quot;)
        ///| where OperationNameValue !in(
        ///     &quot;MICROSOFT.COMPUTE/RESTOREPOINTCOLLECTIONS/RESTOREPOINTS/W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetRecentResourceChangesQuery {
            get {
                return ResourceManager.GetString("GetRecentResourceChangesQuery", resourceCulture);
            }
        }
    }
}
