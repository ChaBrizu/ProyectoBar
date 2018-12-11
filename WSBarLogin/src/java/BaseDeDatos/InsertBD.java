package BaseDeDatos;

import java.sql.SQLException;

/**
 *
 * @author Carlos
 */
public class InsertBD extends InterfazBD{
    public InsertBD(String strDatos){
        setDatos(strDatos);
    }
    
    @Override
    public String consultaBd(){
        int i;
        String resultado;
        String datos=getDatos();
        try {
                executer = conexion.ObtenerConexion().createStatement();
                dataSet = executer.executeQuery("SELECT * FROM `usuario` LIMIT 1");
                sqlQuery = "INSERT INTO `usuario` (";
                for(i = 1;i<=dataSet.getMetaData().getColumnCount()-1;i++)
                {
                     sqlQuery = sqlQuery + dataSet.getMetaData().getColumnName(i) + ",";
                }
                sqlQuery = sqlQuery + dataSet.getMetaData().getColumnName(i)+ ") VALUES (" + datos + ")";
                executer.executeUpdate(sqlQuery);
                resultado =  "Datos almacenados exitosamente.";
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