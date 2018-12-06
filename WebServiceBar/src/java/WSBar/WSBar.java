/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WSBar;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import BaseDeDatos.*;

/**
 *
 * @author Carlos
 */
@WebService(serviceName = "WSBar")
public class WSBar {
    
    @WebMethod(operationName = "insert")
    public String insert(@WebParam(name = "strTabla") String strTabla, @WebParam(name = "strDatos") String strDatos) {
        InterfazBD obj;
        obj= new InsertBD(strTabla, strDatos);
        return obj.consultaBd();
    }
    
    @WebMethod(operationName = "update")
    public String update(@WebParam(name = "strTabla") String strTabla, @WebParam(name = "strDatos") String strDatos, @WebParam(name = "strCondicion") String strCondicion) {
        InterfazBD obj;
        obj= new UpdateBD(strTabla, strDatos, strCondicion);
        return obj.consultaBd();
    }
    
    @WebMethod(operationName = "delete")
    public String delete(@WebParam(name = "strTabla") String strTabla, @WebParam(name = "strDatos") String strDatos, @WebParam(name = "strCondicion") String strCondicion) {
        InterfazBD obj;
        obj= new DeleteBD(strTabla, strCondicion);
        return obj.consultaBd();
    }
    
    @WebMethod(operationName = "selectLogin")
    public String selectLogin(@WebParam(name = "strCondicion") String strCondicion) {
        InterfazBD obj;
        obj= new SelectLogin(strCondicion);
        return obj.consultaBd();
    }
}
