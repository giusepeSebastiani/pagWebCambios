﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaginaWebCambios.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService2Soap")]
    public interface WebService2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SolesToDolar", ReplyAction="*")]
        double SolesToDolar(double soles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SolesToDolar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SolesToDolarAsync(double soles);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService2SoapChannel : PaginaWebCambios.ServiceReference2.WebService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService2SoapClient : System.ServiceModel.ClientBase<PaginaWebCambios.ServiceReference2.WebService2Soap>, PaginaWebCambios.ServiceReference2.WebService2Soap {
        
        public WebService2SoapClient() {
        }
        
        public WebService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double SolesToDolar(double soles) {
            return base.Channel.SolesToDolar(soles);
        }
        
        public System.Threading.Tasks.Task<double> SolesToDolarAsync(double soles) {
            return base.Channel.SolesToDolarAsync(soles);
        }
    }
}
