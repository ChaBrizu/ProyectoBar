/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDeDatos;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

/**
 *
 * @author Carlos
 */
public class SelectLogin extends InterfazBD {
    public SelectLogin(String strCondicion){
        setCondicion(strCondicion);
    }
    
    @Override
    public String consultaBd(){
        String resultado;
        String condicion=getCondicion();
        
        try {
                executer = conexion.ObtenerConexion().createStatement();
                dataSet = executer.executeQuery("SELECT nombre FROM `usuario` WHERE nombre='" + condicion + "'" + " LIMIT 1;");
                if(dataSet.next() == false){
                    resultado = "Nombre de usuario o contraseña incorrectos";
                }
                else{
                    resultado = "Bienvenido " + dataSet.getString("nombre");
                }
                    //SELECT * FROM `usuario` WHERE nombre='admin' and contraseña='1234' LIMIT 1;
                
        }
        catch (SQLException e) {
                resultado = e.toString() + "\n" + sqlQuery;
        }
        finally{
                try {
                        dataSet.close();
                        executer.close();
                }
                catch (SQLException e) {
                        System.out.print(e.toString());
                }
        }
        return resultado;
    }
}
