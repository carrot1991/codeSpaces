﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesApplication.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.ValidateServiceSoap")]
    public interface ValidateServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 strDictionary 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validate", ReplyAction="*")]
        SalesApplication.ServiceReference3.validateResponse validate(SalesApplication.ServiceReference3.validateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validate", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference3.validateRequestBody Body;
        
        public validateRequest() {
        }
        
        public validateRequest(SalesApplication.ServiceReference3.validateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strDictionary;
        
        public validateRequestBody() {
        }
        
        public validateRequestBody(string strDictionary) {
            this.strDictionary = strDictionary;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validateResponse", Namespace="http://tempuri.org/", Order=0)]
        public SalesApplication.ServiceReference3.validateResponseBody Body;
        
        public validateResponse() {
        }
        
        public validateResponse(SalesApplication.ServiceReference3.validateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool validateResult;
        
        public validateResponseBody() {
        }
        
        public validateResponseBody(bool validateResult) {
            this.validateResult = validateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ValidateServiceSoapChannel : SalesApplication.ServiceReference3.ValidateServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidateServiceSoapClient : System.ServiceModel.ClientBase<SalesApplication.ServiceReference3.ValidateServiceSoap>, SalesApplication.ServiceReference3.ValidateServiceSoap {
        
        public ValidateServiceSoapClient() {
        }
        
        public ValidateServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidateServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidateServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidateServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SalesApplication.ServiceReference3.validateResponse SalesApplication.ServiceReference3.ValidateServiceSoap.validate(SalesApplication.ServiceReference3.validateRequest request) {
            return base.Channel.validate(request);
        }
        
        public bool validate(string strDictionary) {
            SalesApplication.ServiceReference3.validateRequest inValue = new SalesApplication.ServiceReference3.validateRequest();
            inValue.Body = new SalesApplication.ServiceReference3.validateRequestBody();
            inValue.Body.strDictionary = strDictionary;
            SalesApplication.ServiceReference3.validateResponse retVal = ((SalesApplication.ServiceReference3.ValidateServiceSoap)(this)).validate(inValue);
            return retVal.Body.validateResult;
        }
    }
}