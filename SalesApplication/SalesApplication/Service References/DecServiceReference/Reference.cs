﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesApplication.DecServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DecServiceReference.decrpytSoap")]
    public interface decrpytSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 strDic 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dec", ReplyAction="*")]
        SalesApplication.DecServiceReference.decResponse dec(SalesApplication.DecServiceReference.decRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class decRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="dec", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.DecServiceReference.decRequestBody Body;
        
        public decRequest() {
        }
        
        public decRequest(SalesApplication.DecServiceReference.decRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class decRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strDic;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string keyFileName;
        
        public decRequestBody() {
        }
        
        public decRequestBody(string strDic, string keyFileName) {
            this.strDic = strDic;
            this.keyFileName = keyFileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class decResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="decResponse", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.DecServiceReference.decResponseBody Body;
        
        public decResponse() {
        }
        
        public decResponse(SalesApplication.DecServiceReference.decResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class decResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string decResult;
        
        public decResponseBody() {
        }
        
        public decResponseBody(string decResult) {
            this.decResult = decResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface decrpytSoapChannel : SalesApplication.DecServiceReference.decrpytSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class decrpytSoapClient : System.ServiceModel.ClientBase<SalesApplication.DecServiceReference.decrpytSoap>, SalesApplication.DecServiceReference.decrpytSoap {
        
        public decrpytSoapClient() {
        }
        
        public decrpytSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public decrpytSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public decrpytSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public decrpytSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SalesApplication.DecServiceReference.decResponse SalesApplication.DecServiceReference.decrpytSoap.dec(SalesApplication.DecServiceReference.decRequest request) {
            return base.Channel.dec(request);
        }
        
        public string dec(string strDic, string keyFileName) {
            SalesApplication.DecServiceReference.decRequest inValue = new SalesApplication.DecServiceReference.decRequest();
            inValue.Body = new SalesApplication.DecServiceReference.decRequestBody();
            inValue.Body.strDic = strDic;
            inValue.Body.keyFileName = keyFileName;
            SalesApplication.DecServiceReference.decResponse retVal = ((SalesApplication.DecServiceReference.decrpytSoap)(this)).dec(inValue);
            return retVal.Body.decResult;
        }
    }
}