/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BaseDeDatos;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

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
            conexion = new Conexion("com.mysql.jdbc.Driver", "", "jdbc:mysql://localhost/monkeys_bar", "root");
    }
    
    public abstract String consultaBd();
    
    public void setTabla(String nombreTabla){
        table=nombreTabla;
    }
    
    public String getTabla(){
        return table;
    }
    
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
