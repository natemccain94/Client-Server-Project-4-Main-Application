﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace VeryImportantCompanySecurity.FloorServiceReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IFloorService", Namespace="http://tempuri.org/")]
    public partial class FloorService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetFloorPlateOneValOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFloorPlateTwoValOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFloorPlateThreeValOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFloorPlateFourValOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FloorService() {
            this.Url = global::VeryImportantCompanySecurity.Properties.Settings.Default.VeryImportantCompanySecurity_FloorServiceReference_FloorService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetFloorPlateOneValCompletedEventHandler GetFloorPlateOneValCompleted;
        
        /// <remarks/>
        public event GetFloorPlateTwoValCompletedEventHandler GetFloorPlateTwoValCompleted;
        
        /// <remarks/>
        public event GetFloorPlateThreeValCompletedEventHandler GetFloorPlateThreeValCompleted;
        
        /// <remarks/>
        public event GetFloorPlateFourValCompletedEventHandler GetFloorPlateFourValCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IFloorService/GetFloorPlateOneVal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetFloorPlateOneVal() {
            object[] results = this.Invoke("GetFloorPlateOneVal", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFloorPlateOneValAsync() {
            this.GetFloorPlateOneValAsync(null);
        }
        
        /// <remarks/>
        public void GetFloorPlateOneValAsync(object userState) {
            if ((this.GetFloorPlateOneValOperationCompleted == null)) {
                this.GetFloorPlateOneValOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFloorPlateOneValOperationCompleted);
            }
            this.InvokeAsync("GetFloorPlateOneVal", new object[0], this.GetFloorPlateOneValOperationCompleted, userState);
        }
        
        private void OnGetFloorPlateOneValOperationCompleted(object arg) {
            if ((this.GetFloorPlateOneValCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFloorPlateOneValCompleted(this, new GetFloorPlateOneValCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IFloorService/GetFloorPlateTwoVal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetFloorPlateTwoVal() {
            object[] results = this.Invoke("GetFloorPlateTwoVal", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFloorPlateTwoValAsync() {
            this.GetFloorPlateTwoValAsync(null);
        }
        
        /// <remarks/>
        public void GetFloorPlateTwoValAsync(object userState) {
            if ((this.GetFloorPlateTwoValOperationCompleted == null)) {
                this.GetFloorPlateTwoValOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFloorPlateTwoValOperationCompleted);
            }
            this.InvokeAsync("GetFloorPlateTwoVal", new object[0], this.GetFloorPlateTwoValOperationCompleted, userState);
        }
        
        private void OnGetFloorPlateTwoValOperationCompleted(object arg) {
            if ((this.GetFloorPlateTwoValCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFloorPlateTwoValCompleted(this, new GetFloorPlateTwoValCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IFloorService/GetFloorPlateThreeVal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetFloorPlateThreeVal() {
            object[] results = this.Invoke("GetFloorPlateThreeVal", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFloorPlateThreeValAsync() {
            this.GetFloorPlateThreeValAsync(null);
        }
        
        /// <remarks/>
        public void GetFloorPlateThreeValAsync(object userState) {
            if ((this.GetFloorPlateThreeValOperationCompleted == null)) {
                this.GetFloorPlateThreeValOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFloorPlateThreeValOperationCompleted);
            }
            this.InvokeAsync("GetFloorPlateThreeVal", new object[0], this.GetFloorPlateThreeValOperationCompleted, userState);
        }
        
        private void OnGetFloorPlateThreeValOperationCompleted(object arg) {
            if ((this.GetFloorPlateThreeValCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFloorPlateThreeValCompleted(this, new GetFloorPlateThreeValCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IFloorService/GetFloorPlateFourVal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetFloorPlateFourVal() {
            object[] results = this.Invoke("GetFloorPlateFourVal", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFloorPlateFourValAsync() {
            this.GetFloorPlateFourValAsync(null);
        }
        
        /// <remarks/>
        public void GetFloorPlateFourValAsync(object userState) {
            if ((this.GetFloorPlateFourValOperationCompleted == null)) {
                this.GetFloorPlateFourValOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFloorPlateFourValOperationCompleted);
            }
            this.InvokeAsync("GetFloorPlateFourVal", new object[0], this.GetFloorPlateFourValOperationCompleted, userState);
        }
        
        private void OnGetFloorPlateFourValOperationCompleted(object arg) {
            if ((this.GetFloorPlateFourValCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFloorPlateFourValCompleted(this, new GetFloorPlateFourValCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFloorPlateOneValCompletedEventHandler(object sender, GetFloorPlateOneValCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFloorPlateOneValCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFloorPlateOneValCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFloorPlateTwoValCompletedEventHandler(object sender, GetFloorPlateTwoValCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFloorPlateTwoValCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFloorPlateTwoValCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFloorPlateThreeValCompletedEventHandler(object sender, GetFloorPlateThreeValCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFloorPlateThreeValCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFloorPlateThreeValCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetFloorPlateFourValCompletedEventHandler(object sender, GetFloorPlateFourValCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFloorPlateFourValCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFloorPlateFourValCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591