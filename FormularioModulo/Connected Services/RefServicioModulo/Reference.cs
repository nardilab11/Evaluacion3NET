﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormularioModulo.RefServicioModulo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefServicioModulo.IServicioModulo")]
    public interface IServicioModulo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioModulo/calcularModulo", ReplyAction="http://tempuri.org/IServicioModulo/calcularModuloResponse")]
        int calcularModulo(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioModulo/calcularModulo", ReplyAction="http://tempuri.org/IServicioModulo/calcularModuloResponse")]
        System.Threading.Tasks.Task<int> calcularModuloAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioModuloChannel : FormularioModulo.RefServicioModulo.IServicioModulo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioModuloClient : System.ServiceModel.ClientBase<FormularioModulo.RefServicioModulo.IServicioModulo>, FormularioModulo.RefServicioModulo.IServicioModulo {
        
        public ServicioModuloClient() {
        }
        
        public ServicioModuloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioModuloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioModuloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioModuloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int calcularModulo(int a, int b) {
            return base.Channel.calcularModulo(a, b);
        }
        
        public System.Threading.Tasks.Task<int> calcularModuloAsync(int a, int b) {
            return base.Channel.calcularModuloAsync(a, b);
        }
    }
}
