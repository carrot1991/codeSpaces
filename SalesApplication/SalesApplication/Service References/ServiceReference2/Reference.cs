﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesApplication.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.getKeySoap")]
    public interface getKeySoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 constructKeyResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/constructKey", ReplyAction="*")]
        SalesApplication.ServiceReference2.constructKeyResponse constructKey(SalesApplication.ServiceReference2.constructKeyRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 path 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/get", ReplyAction="*")]
        SalesApplication.ServiceReference2.getResponse get(SalesApplication.ServiceReference2.getRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class constructKeyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="constructKey", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference2.constructKeyRequestBody Body;
        
        public constructKeyRequest() {
        }
        
        public constructKeyRequest(SalesApplication.ServiceReference2.constructKeyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class constructKeyRequestBody {
        
        public constructKeyRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class constructKeyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="constructKeyResponse", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference2.constructKeyResponseBody Body;
        
        public constructKeyResponse() {
        }
        
        public constructKeyResponse(SalesApplication.ServiceReference2.constructKeyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class constructKeyResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string constructKeyResult;
        
        public constructKeyResponseBody() {
        }
        
        public constructKeyResponseBody(string constructKeyResult) {
            this.constructKeyResult = constructKeyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference2.getRequestBody Body;
        
        public getRequest() {
        }
        
        public getRequest(SalesApplication.ServiceReference2.getRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string path;
        
        public getRequestBody() {
        }
        
        public getRequestBody(string path) {
            this.path = path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getResponse", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference2.getResponseBody Body;
        
        public getResponse() {
        }
        
        public getResponse(SalesApplication.ServiceReference2.getResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getResult;
        
        public getResponseBody() {
        }
        
        public getResponseBody(string getResult) {
            this.getResult = getResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface getKeySoapChannel : SalesApplication.ServiceReference2.getKeySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getKeySoapClient : System.ServiceModel.ClientBase<SalesApplication.ServiceReference2.getKeySoap>, SalesApplication.ServiceReference2.getKeySoap {
        
        public getKeySoapClient() {
        }
        
        public getKeySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public getKeySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public getKeySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public getKeySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SalesApplication.ServiceReference2.constructKeyResponse SalesApplication.ServiceReference2.getKeySoap.constructKey(SalesApplication.ServiceReference2.constructKeyRequest request) {
            return base.Channel.constructKey(request);
        }
        
        public string constructKey() {
            SalesApplication.ServiceReference2.constructKeyRequest inValue = new SalesApplication.ServiceReference2.constructKeyRequest();
            inValue.Body = new SalesApplication.ServiceReference2.constructKeyRequestBody();
            SalesApplication.ServiceReference2.constructKeyResponse retVal = ((SalesApplication.ServiceReference2.getKeySoap)(this)).constructKey(inValue);
            return retVal.Body.constructKeyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SalesApplication.ServiceReference2.getResponse SalesApplication.ServiceReference2.getKeySoap.get(SalesApplication.ServiceReference2.getRequest request) {
            return base.Channel.get(request);
        }
        
        public string get(string path) {
            SalesApplication.ServiceReference2.getRequest inValue = new SalesApplication.ServiceReference2.getRequest();
            inValue.Body = new SalesApplication.ServiceReference2.getRequestBody();
            inValue.Body.path = path;
            SalesApplication.ServiceReference2.getResponse retVal = ((SalesApplication.ServiceReference2.getKeySoap)(this)).get(inValue);
            return retVal.Body.getResult;
        }
    }
}
