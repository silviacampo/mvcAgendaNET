﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAgenda.Resources {
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
    public class Users {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Users() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MvcAgenda.Resources.Users", typeof(Users).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        public static string userEmail {
            get {
                return ResourceManager.GetString("userEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max 100 char.
        /// </summary>
        public static string userEmailMaxLengthMsg {
            get {
                return ResourceManager.GetString("userEmailMaxLengthMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email is not valid.
        /// </summary>
        public static string userEmailRegExMsg {
            get {
                return ResourceManager.GetString("userEmailRegExMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email can&apos;t be empty.
        /// </summary>
        public static string userEmailRequiredMsg {
            get {
                return ResourceManager.GetString("userEmailRequiredMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not available..
        /// </summary>
        public static string userEmailUnavailable {
            get {
                return ResourceManager.GetString("userEmailUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Friends.
        /// </summary>
        public static string userFriends {
            get {
                return ResourceManager.GetString("userFriends", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string userName {
            get {
                return ResourceManager.GetString("userName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max 20 char.
        /// </summary>
        public static string userNameMaxLengthMsg {
            get {
                return ResourceManager.GetString("userNameMaxLengthMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name can&apos;t be empty.
        /// </summary>
        public static string userNameRequiredMsg {
            get {
                return ResourceManager.GetString("userNameRequiredMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not available..
        /// </summary>
        public static string userNameUnavailable {
            get {
                return ResourceManager.GetString("userNameUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not available. Try {1}..
        /// </summary>
        public static string userNameUnavailableAlt {
            get {
                return ResourceManager.GetString("userNameUnavailableAlt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string userPassword {
            get {
                return ResourceManager.GetString("userPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} must be at least {2} characters long..
        /// </summary>
        public static string userPasswordMaxLengthMsg {
            get {
                return ResourceManager.GetString("userPasswordMaxLengthMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password can&apos;t be empty.
        /// </summary>
        public static string userPasswordRequiredMsg {
            get {
                return ResourceManager.GetString("userPasswordRequiredMsg", resourceCulture);
            }
        }
    }
}