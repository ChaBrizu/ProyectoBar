﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_ventas.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WSBar/", ConfigurationName="ServiceReference1.WSBar")]
    public interface WSBar {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento strTabla del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/updateRequest", ReplyAction="http://WSBar/WSBar/updateResponse")]
        Punto_de_ventas.ServiceReference1.updateResponse update(Punto_de_ventas.ServiceReference1.updateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/updateRequest", ReplyAction="http://WSBar/WSBar/updateResponse")]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.updateResponse> updateAsync(Punto_de_ventas.ServiceReference1.updateRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento strTabla del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/deleteRequest", ReplyAction="http://WSBar/WSBar/deleteResponse")]
        Punto_de_ventas.ServiceReference1.deleteResponse delete(Punto_de_ventas.ServiceReference1.deleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/deleteRequest", ReplyAction="http://WSBar/WSBar/deleteResponse")]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.deleteResponse> deleteAsync(Punto_de_ventas.ServiceReference1.deleteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento strTabla del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/insertRequest", ReplyAction="http://WSBar/WSBar/insertResponse")]
        Punto_de_ventas.ServiceReference1.insertResponse insert(Punto_de_ventas.ServiceReference1.insertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/insertRequest", ReplyAction="http://WSBar/WSBar/insertResponse")]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.insertResponse> insertAsync(Punto_de_ventas.ServiceReference1.insertRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento strCondicion del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/selectLoginRequest", ReplyAction="http://WSBar/WSBar/selectLoginResponse")]
        Punto_de_ventas.ServiceReference1.selectLoginResponse selectLogin(Punto_de_ventas.ServiceReference1.selectLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WSBar/WSBar/selectLoginRequest", ReplyAction="http://WSBar/WSBar/selectLoginResponse")]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.selectLoginResponse> selectLoginAsync(Punto_de_ventas.ServiceReference1.selectLoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="update", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.updateRequestBody Body;
        
        public updateRequest() {
        }
        
        public updateRequest(Punto_de_ventas.ServiceReference1.updateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class updateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strTabla;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strDatos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strCondicion;
        
        public updateRequestBody() {
        }
        
        public updateRequestBody(string strTabla, string strDatos, string strCondicion) {
            this.strTabla = strTabla;
            this.strDatos = strDatos;
            this.strCondicion = strCondicion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateResponse", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.updateResponseBody Body;
        
        public updateResponse() {
        }
        
        public updateResponse(Punto_de_ventas.ServiceReference1.updateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class updateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public updateResponseBody() {
        }
        
        public updateResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="delete", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.deleteRequestBody Body;
        
        public deleteRequest() {
        }
        
        public deleteRequest(Punto_de_ventas.ServiceReference1.deleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class deleteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strTabla;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strDatos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strCondicion;
        
        public deleteRequestBody() {
        }
        
        public deleteRequestBody(string strTabla, string strDatos, string strCondicion) {
            this.strTabla = strTabla;
            this.strDatos = strDatos;
            this.strCondicion = strCondicion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteResponse", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.deleteResponseBody Body;
        
        public deleteResponse() {
        }
        
        public deleteResponse(Punto_de_ventas.ServiceReference1.deleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class deleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public deleteResponseBody() {
        }
        
        public deleteResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insert", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.insertRequestBody Body;
        
        public insertRequest() {
        }
        
        public insertRequest(Punto_de_ventas.ServiceReference1.insertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class insertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strTabla;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strDatos;
        
        public insertRequestBody() {
        }
        
        public insertRequestBody(string strTabla, string strDatos) {
            this.strTabla = strTabla;
            this.strDatos = strDatos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertResponse", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.insertResponseBody Body;
        
        public insertResponse() {
        }
        
        public insertResponse(Punto_de_ventas.ServiceReference1.insertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class insertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public insertResponseBody() {
        }
        
        public insertResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectLogin", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.selectLoginRequestBody Body;
        
        public selectLoginRequest() {
        }
        
        public selectLoginRequest(Punto_de_ventas.ServiceReference1.selectLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class selectLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strCondicion;
        
        public selectLoginRequestBody() {
        }
        
        public selectLoginRequestBody(string strCondicion) {
            this.strCondicion = strCondicion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectLoginResponse", Namespace="http://WSBar/", Order=0)]
        public Punto_de_ventas.ServiceReference1.selectLoginResponseBody Body;
        
        public selectLoginResponse() {
        }
        
        public selectLoginResponse(Punto_de_ventas.ServiceReference1.selectLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class selectLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public selectLoginResponseBody() {
        }
        
        public selectLoginResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSBarChannel : Punto_de_ventas.ServiceReference1.WSBar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSBarClient : System.ServiceModel.ClientBase<Punto_de_ventas.ServiceReference1.WSBar>, Punto_de_ventas.ServiceReference1.WSBar {
        
        public WSBarClient() {
        }
        
        public WSBarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSBarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSBarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSBarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_ventas.ServiceReference1.updateResponse Punto_de_ventas.ServiceReference1.WSBar.update(Punto_de_ventas.ServiceReference1.updateRequest request) {
            return base.Channel.update(request);
        }
        
        public string update(string strTabla, string strDatos, string strCondicion) {
            Punto_de_ventas.ServiceReference1.updateRequest inValue = new Punto_de_ventas.ServiceReference1.updateRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.updateRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            inValue.Body.strCondicion = strCondicion;
            Punto_de_ventas.ServiceReference1.updateResponse retVal = ((Punto_de_ventas.ServiceReference1.WSBar)(this)).update(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.updateResponse> Punto_de_ventas.ServiceReference1.WSBar.updateAsync(Punto_de_ventas.ServiceReference1.updateRequest request) {
            return base.Channel.updateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.updateResponse> updateAsync(string strTabla, string strDatos, string strCondicion) {
            Punto_de_ventas.ServiceReference1.updateRequest inValue = new Punto_de_ventas.ServiceReference1.updateRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.updateRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            inValue.Body.strCondicion = strCondicion;
            return ((Punto_de_ventas.ServiceReference1.WSBar)(this)).updateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_ventas.ServiceReference1.deleteResponse Punto_de_ventas.ServiceReference1.WSBar.delete(Punto_de_ventas.ServiceReference1.deleteRequest request) {
            return base.Channel.delete(request);
        }
        
        public string delete(string strTabla, string strDatos, string strCondicion) {
            Punto_de_ventas.ServiceReference1.deleteRequest inValue = new Punto_de_ventas.ServiceReference1.deleteRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.deleteRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            inValue.Body.strCondicion = strCondicion;
            Punto_de_ventas.ServiceReference1.deleteResponse retVal = ((Punto_de_ventas.ServiceReference1.WSBar)(this)).delete(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.deleteResponse> Punto_de_ventas.ServiceReference1.WSBar.deleteAsync(Punto_de_ventas.ServiceReference1.deleteRequest request) {
            return base.Channel.deleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.deleteResponse> deleteAsync(string strTabla, string strDatos, string strCondicion) {
            Punto_de_ventas.ServiceReference1.deleteRequest inValue = new Punto_de_ventas.ServiceReference1.deleteRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.deleteRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            inValue.Body.strCondicion = strCondicion;
            return ((Punto_de_ventas.ServiceReference1.WSBar)(this)).deleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_ventas.ServiceReference1.insertResponse Punto_de_ventas.ServiceReference1.WSBar.insert(Punto_de_ventas.ServiceReference1.insertRequest request) {
            return base.Channel.insert(request);
        }
        
        public string insert(string strTabla, string strDatos) {
            Punto_de_ventas.ServiceReference1.insertRequest inValue = new Punto_de_ventas.ServiceReference1.insertRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.insertRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            Punto_de_ventas.ServiceReference1.insertResponse retVal = ((Punto_de_ventas.ServiceReference1.WSBar)(this)).insert(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.insertResponse> Punto_de_ventas.ServiceReference1.WSBar.insertAsync(Punto_de_ventas.ServiceReference1.insertRequest request) {
            return base.Channel.insertAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.insertResponse> insertAsync(string strTabla, string strDatos) {
            Punto_de_ventas.ServiceReference1.insertRequest inValue = new Punto_de_ventas.ServiceReference1.insertRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.insertRequestBody();
            inValue.Body.strTabla = strTabla;
            inValue.Body.strDatos = strDatos;
            return ((Punto_de_ventas.ServiceReference1.WSBar)(this)).insertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_ventas.ServiceReference1.selectLoginResponse Punto_de_ventas.ServiceReference1.WSBar.selectLogin(Punto_de_ventas.ServiceReference1.selectLoginRequest request) {
            return base.Channel.selectLogin(request);
        }
        
        public string selectLogin(string strCondicion) {
            Punto_de_ventas.ServiceReference1.selectLoginRequest inValue = new Punto_de_ventas.ServiceReference1.selectLoginRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.selectLoginRequestBody();
            inValue.Body.strCondicion = strCondicion;
            Punto_de_ventas.ServiceReference1.selectLoginResponse retVal = ((Punto_de_ventas.ServiceReference1.WSBar)(this)).selectLogin(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.selectLoginResponse> Punto_de_ventas.ServiceReference1.WSBar.selectLoginAsync(Punto_de_ventas.ServiceReference1.selectLoginRequest request) {
            return base.Channel.selectLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_ventas.ServiceReference1.selectLoginResponse> selectLoginAsync(string strCondicion) {
            Punto_de_ventas.ServiceReference1.selectLoginRequest inValue = new Punto_de_ventas.ServiceReference1.selectLoginRequest();
            inValue.Body = new Punto_de_ventas.ServiceReference1.selectLoginRequestBody();
            inValue.Body.strCondicion = strCondicion;
            return ((Punto_de_ventas.ServiceReference1.WSBar)(this)).selectLoginAsync(inValue);
        }
    }
}
