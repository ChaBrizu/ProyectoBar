/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDeDatos;

import java.sql.SQLException;

/**
 *
 * @author Carlos
 */
public class UpdateBD extends InterfazBD{
    public UpdateBD(String strDatos, String strCondicion){
        setDatos(strDatos);
        setCondicion(strCondicion);
    }
    
    @Override
    public String consultaBd(){
        String resultado;
        String datos=getDatos();
        String condicion=getCondicion();
        
        try {
                executer = conexion.ObtenerConexion().createStatement();
                sqlQuery = "UPDATE `usuario` SET " + datos + " WHERE " + condicion + " LIMIT 1";
                executer.executeUpdate(sqlQuery);
                resultado =  "Las modificaciones fueron ejecutadas correctamente.";
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