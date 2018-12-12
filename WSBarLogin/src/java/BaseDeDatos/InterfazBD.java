package BaseDeDatos;

import java.sql.*;

/**
 *
 * @author Carlos
 */
public abstract class InterfazBD {
    
    protected String table;
    protected String data;
    protected String condition;
        
    protected String sqlQuery;
    protected Statement executer;
    protected ResultSet dataSet;
    protected Conexion conexion;
    
    public InterfazBD() {
            conexion = new Conexion("com.mysql.jdbc.Driver", "", "jdbc:mysql://localhost/bar_monkys", "root");
    }
    
    public abstract String consultaBd();
    
    public void setDatos(String strDatos){
        data=strDatos;
    }
    
    public String getDatos(){
        return data;
    }
    
    public void setCondicion(String strCondicion){
        condition=strCondicion;
    }
    
    public String getCondicion(){
        return condition;
    }
}