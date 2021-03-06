﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Websites.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.Management.Websites.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cannot find {0} with name {1}..
        /// </summary>
        internal static string CannotFind {
            get {
                return ResourceManager.GetString("CannotFind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete.
        /// </summary>
        internal static string CompleteMessage {
            get {
                return ResourceManager.GetString("CompleteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no hostnames which could be used for validation..
        /// </summary>
        internal static string DefaultHostnamesValidation {
            get {
                return ResourceManager.GetString("DefaultHostnamesValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Git not found. Please install git and place it in your command line path..
        /// </summary>
        internal static string GitNotFound {
            get {
                return ResourceManager.GetString("GitNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment with {0} does not exist.
        /// </summary>
        internal static string InvalidDeployment {
            get {
                return ResourceManager.GetString("InvalidDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must create your git publishing credentials using the Windows Azure portal.
        ///Please follow these steps in the portal:
        ///1. On the left side open &quot;Web Sites&quot;
        ///2. Click on any website
        ///3. Choose &quot;Setup Git Publishing&quot; or &quot;Reset deployment credentials&quot;
        ///4. Back in the PowerShell window, rerun this command by typing &quot;New-AzureWebSite {site name} -Git -PublishingUsername {username}
        ///Launch portal now?.
        /// </summary>
        internal static string InvalidGitCredentials {
            get {
                return ResourceManager.GetString("InvalidGitCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified hostname does not exist. Please specify a valid hostname for the site..
        /// </summary>
        internal static string InvalidHostnameValidation {
            get {
                return ResourceManager.GetString("InvalidHostnameValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid or empty.
        /// </summary>
        internal static string InvalidOrEmptyArgumentMessage {
            get {
                return ResourceManager.GetString("InvalidOrEmptyArgumentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The website {0} was not found. Please specify a valid website name..
        /// </summary>
        internal static string InvalidWebsite {
            get {
                return ResourceManager.GetString("InvalidWebsite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link already established.
        /// </summary>
        internal static string LinkAlreadyEstablished {
            get {
                return ResourceManager.GetString("LinkAlreadyEstablished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple possible publishing users. Please go to the Portal and use the listed deployment user, or click &apos;set/reset deployment credentials&apos; to set up a new user account, then reurn this cmdlet and specify PublishingUsername..
        /// </summary>
        internal static string MultiplePublishingUsernames {
            get {
                return ResourceManager.GetString("MultiplePublishingUsernames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A publishing username is required. Please specify one using the argument PublishingUsername..
        /// </summary>
        internal static string NeedPublishingUsernames {
            get {
                return ResourceManager.GetString("NeedPublishingUsernames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no default subscription set, please set a default subscription by running Set-AzureSubscription -Default &lt;subscription name&gt;.
        /// </summary>
        internal static string NoDefaultSubscriptionMessage {
            get {
                return ResourceManager.GetString("NoDefaultSubscriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must create your first web site using the Windows Azure portal.
        ///Please follow these steps in the portal:
        ///1. At the bottom of the page, click on New &gt; Web Site &gt; Quick Create
        ///2. Type {0} in the URL field
        ///3. Click on &quot;Create Web Site&quot;
        ///4. Once the site has been created, click on the site name
        ///5. Click on &quot;Set up Git publishing&quot; or &quot;Reset deployment credentials&quot; and setup a publishing username and password. Use those credentials for all new websites you create..
        /// </summary>
        internal static string PortalInstructions {
            get {
                return ResourceManager.GetString("PortalInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 6. Back in the console window, rerun this command by typing &quot;New-AzureWebsite &lt;site name&gt; -Git&quot;.
        /// </summary>
        internal static string PortalInstructionsGit {
            get {
                return ResourceManager.GetString("PortalInstructionsGit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reploy deployment with {0} Id ?.
        /// </summary>
        internal static string RedeployCommit {
            get {
                return ResourceManager.GetString("RedeployCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing website.
        /// </summary>
        internal static string RemoveWebsiteMessage {
            get {
                return ResourceManager.GetString("RemoveWebsiteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the website &quot;{0}&quot;.
        /// </summary>
        internal static string RemoveWebsiteWarning {
            get {
                return ResourceManager.GetString("RemoveWebsiteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repository is not setup. You need to pass a valid site name..
        /// </summary>
        internal static string RepositoryNotSetup {
            get {
                return ResourceManager.GetString("RepositoryNotSetup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string ShouldProcessCaption {
            get {
                return ResourceManager.GetString("ShouldProcessCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebSite with given name {0} already exists in the specified Subscription and Webspace..
        /// </summary>
        internal static string WebsiteAlreadyExists {
            get {
                return ResourceManager.GetString("WebsiteAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebSite with given name {0} already exists in the specified Subscription and Location..
        /// </summary>
        internal static string WebsiteAlreadyExistsReplacement {
            get {
                return ResourceManager.GetString("WebsiteAlreadyExistsReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site {0} already has repository created for it..
        /// </summary>
        internal static string WebsiteRepositoryAlreadyExists {
            get {
                return ResourceManager.GetString("WebsiteRepositoryAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workspaces/WebsiteExtension/Website/{0}/dashboard/.
        /// </summary>
        internal static string WebsiteSufixUrl {
            get {
                return ResourceManager.GetString("WebsiteSufixUrl", resourceCulture);
            }
        }
    }
}
