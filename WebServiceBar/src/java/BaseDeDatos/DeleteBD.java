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
public class DeleteBD extends InterfazBD{
    public DeleteBD(String strTabla, String strCondicion){
        setTabla(strTabla);
        setCondicion(strCondicion);
    }
    
    @Override
    public String consultaBd(){
        String resultado;
        
        String tabla=getTabla();
        String condicion=getCondicion();
        
        try {
            executer = conexion.ObtenerConexion().createStatement();
            sqlQuery = "DELETE FROM " + tabla + " WHERE " + condicion;
            executer.executeUpdate(sqlQuery);
            resultado =  "Datos borrados exitosamente.";
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