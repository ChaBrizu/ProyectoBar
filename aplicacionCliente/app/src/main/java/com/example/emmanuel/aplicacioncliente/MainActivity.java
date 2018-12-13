package com.example.emmanuel.aplicacioncliente;

import android.net.http.HttpResponseCache;
import android.nfc.Tag;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;
import org.json.JSONObject;

public class MainActivity extends AppCompatActivity {

    TextView info;
    EditText dato;
    TextView respuesta1, respuesta2, respuesta3;
    Button btnBuscar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        info = (TextView)findViewById(R.id.textViewInfo);
        dato = (EditText)findViewById((R.id.editTextDato));
        respuesta1 = (TextView)findViewById(R.id.textViewRespuesta1);
        respuesta2 = (TextView)findViewById(R.id.textViewRespuesta2);
        respuesta3 = (TextView)findViewById(R.id.textViewRespuesta3);
        btnBuscar = (Button)findViewById(R.id.buttonBuscarCliente);

        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ObtenerCliente tarea = new ObtenerCliente();
                tarea.execute(dato.getText().toString());
            }
        });
    }

    //Tarea asincrona para llamar WS de consulta en segundo plano
    public class ObtenerCliente extends AsyncTask<String,Void,Void>{
        //Campos a recibir son: Id, nombre, apellido, direccion,telefono,deuda
        int oId;
        String oName;
        String oLName;
        String oDir;
        String oTel;
        double oDeu;

        @Override
        protected Void doInBackground(String... params){

            Log.i("ConsultaCliente","doInBackground");
            HttpClient httpClient = new DefaultHttpClient();

            String sId = params[0];

            HttpGet get = new HttpGet("http://192.168.0.13:8080/WSMonkysREST3067488357488417719/webresources/monkysbar.clientes/" + sId);
            get.setHeader("Content-type", "application/json");

            try{
                HttpResponse resp = httpClient.execute(get);
                String respString = EntityUtils.toString(resp.getEntity());

                JSONObject respJSON = new JSONObject(respString);

                oId = respJSON.getInt("id_cliente");
                oName = respJSON.getString("nombre");
                oLName = respJSON.getString("apellido");
                oDir = respJSON.getString("direccion");
                oTel = respJSON.getString("telefono");
                oDeu = respJSON.getDouble("deuda");
            }
            catch (Exception ex){
                Log.e("ServicioREST", "Error",ex);
                ex.printStackTrace();
            }

            return  null;
        }

        @Override
        protected  void onPostExecute(Void result){

            Log.i("ServicioRest", "onPostExecute");
            respuesta1.setText("ID: "+ oId + " --- Nombre: " + oName + " --- Apellido: " + oLName + " --- Deuda: $"+oDeu);
            respuesta2.setText("Direccion: " + oDir);
            respuesta3.setText("Telefono: " + oTel);
        }

        @Override
        protected  void onPreExecute(){

            Log.i("ServicioRest", "onPreExecute");
            info.setText("Se esta procesando la informacion.");
        }
    }
}
