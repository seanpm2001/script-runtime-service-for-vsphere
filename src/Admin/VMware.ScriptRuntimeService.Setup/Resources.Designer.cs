﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMware.ScriptRuntimeService.Setup {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VMware.ScriptRuntimeService.Setup.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &quot;{0}&quot; was resolved of the hostname for the PS Execution Host Service. Hostname will be used  as the service endpoint. If this hostname is is not DNS resolvable from the vSpehre network other services won&apos;t be able to reach the service. 
        ///
        ///Do you want to proceed with &quot;{0}&quot; hostname? If you choose &quot;No&quot; IP options will be displayed.
        ///
        ///[Y] Yes [N] No (default is &quot;Y&quot;):.
        /// </summary>
        internal static string ConfirmHostname {
            get {
                return ResourceManager.GetString("ConfirmHostname", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Solution User.
        /// </summary>
        internal static string DeleteSolutionUserOperation {
            get {
                return ResourceManager.GetString("DeleteSolutionUserOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lookup service deregistration.
        /// </summary>
        internal static string DeregisterFromLookupServiceOperation {
            get {
                return ResourceManager.GetString("DeregisterFromLookupServiceOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred during service setup:.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Which of the below IP Addresses do you want to be used for the service endpoin:
        ///
        ///{0}
        ///Enter number in range {1}:.
        /// </summary>
        internal static string IpAddressChoice {
            get {
                return ResourceManager.GetString("IpAddressChoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing operation: {0}.
        /// </summary>
        internal static string PerofomingOperation {
            get {
                return ResourceManager.GetString("PerofomingOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution user registration.
        /// </summary>
        internal static string RegisteringSolutionUser {
            get {
                return ResourceManager.GetString("RegisteringSolutionUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lookup service registration.
        /// </summary>
        internal static string RegisteringToLookupServiceOperation {
            get {
                return ResourceManager.GetString("RegisteringToLookupServiceOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid server certificate.
        ///
        ///{0}
        ///
        ///It is recommended that you do not connect to any server with an invalid certificate. Do you accept the server certificate?
        ///[Y] Yes [N] No (default is &quot;N&quot;):.
        /// </summary>
        internal static string ServerCertificatePrompt {
            get {
                return ResourceManager.GetString("ServerCertificatePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter password for user &apos;{0}&apos; to log in to &apos;{1}&apos;:.
        /// </summary>
        internal static string SSOPasswordPrompt {
            get {
                return ResourceManager.GetString("SSOPasswordPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storing VC CA certificates.
        /// </summary>
        internal static string StoringCACertificates {
            get {
                return ResourceManager.GetString("StoringCACertificates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storing &apos;{0}&apos; CA certificate for .
        /// </summary>
        internal static string StoringVCCACertificates {
            get {
                return ResourceManager.GetString("StoringVCCACertificates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success.
        /// </summary>
        internal static string Success {
            get {
                return ResourceManager.GetString("Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update lookup service registration.
        /// </summary>
        internal static string UpdateLookupServiceRegistration {
            get {
                return ResourceManager.GetString("UpdateLookupServiceRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: setup [-psc] &lt;psc_hostname&gt; [-user] &lt;psc_usename&gt; [[-password] &lt;psc_password&gt;] [-settings] &lt;ses_service_settings_file&gt; [-force].
        /// </summary>
        internal static string UsageMessage {
            get {
                return ResourceManager.GetString("UsageMessage", resourceCulture);
            }
        }
    }
}
