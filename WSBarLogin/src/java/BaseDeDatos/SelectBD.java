package BaseDeDatos;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

/**
 *
 * @author Carlos
 */
public class SelectBD extends InterfazBD {
    public SelectBD(String strCondicion){
        setCondicion(strCondicion);
    }
    
    @Override
    public String consultaBd(){
        String resultado;
        String condicion=getCondicion();
        
        try {
                executer = conexion.ObtenerConexion().createStatement();
                dataSet = executer.executeQuery("SELECT * FROM `usuario` WHERE nombre='" + condicion + "'" + " LIMIT 1;");
                if(dataSet.next() == false){
                    resultado = "Nombre de usuario o contraseña incorrectos";
                }
                else{
                    resultado = "Bienvenido " + dataSet.getString("nombre");
                }
                
                dataSet.close();
                executer.close();
                
        }
        catch (SQLException e) {
                resultado = e.toString() + "\n" + sqlQuery;
        }
        return resultado;
    }
}