﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.HelloService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloService.WSHelloSoap")]
    public interface WSHelloSoap {
        
        // CODEGEN: Generazione di un contratto di messaggio perché il nome di elemento name dallo spazio dei nomi http://tempuri.org/ non è contrassegnato come nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessage", ReplyAction="*")]
        WebClient.HelloService.GetMessageResponse GetMessage(WebClient.HelloService.GetMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessage", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.HelloService.GetMessageRequestBody Body;
        
        public GetMessageRequest() {
        }
        
        public GetMessageRequest(WebClient.HelloService.GetMessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetMessageRequestBody() {
        }
        
        public GetMessageRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.HelloService.GetMessageResponseBody Body;
        
        public GetMessageResponse() {
        }
        
        public GetMessageResponse(WebClient.HelloService.GetMessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMessageResult;
        
        public GetMessageResponseBody() {
        }
        
        public GetMessageResponseBody(string GetMessageResult) {
            this.GetMessageResult = GetMessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSHelloSoapChannel : WebClient.HelloService.WSHelloSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSHelloSoapClient : System.ServiceModel.ClientBase<WebClient.HelloService.WSHelloSoap>, WebClient.HelloService.WSHelloSoap {
        
        public WSHelloSoapClient() {
        }
        
        public WSHelloSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSHelloSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSHelloSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSHelloSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.HelloService.GetMessageResponse WebClient.HelloService.WSHelloSoap.GetMessage(WebClient.HelloService.GetMessageRequest request) {
            return base.Channel.GetMessage(request);
        }
        
        public string GetMessage(string name) {
            WebClient.HelloService.GetMessageRequest inValue = new WebClient.HelloService.GetMessageRequest();
            inValue.Body = new WebClient.HelloService.GetMessageRequestBody();
            inValue.Body.name = name;
            WebClient.HelloService.GetMessageResponse retVal = ((WebClient.HelloService.WSHelloSoap)(this)).GetMessage(inValue);
            return retVal.Body.GetMessageResult;
        }
    }
}
