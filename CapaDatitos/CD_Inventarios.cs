using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatitos
{
    public class CD_Inventarios
    {
        private Conexion conn = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        // tableUSUS 1 
        public DataTable Mostrar()
        {
            //transac sql
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT TOP(100) * FROM INVENTARIOS ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDesc()
        {
            //transac sql
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT TOP(100)* FROM INVENTARIOS ORDER BY CONVERT(INT,SUBSTRING(INV_NO,4,LEN(INV_NO))) DESC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarAsc()
        {
            //transac sql
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT TOP(100) * FROM INVENTARIOS ORDER BY CONVERT(INT,SUBSTRING(INV_NO,4,LEN(INV_NO))) ASC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }

        public DataTable Busqueda(string codEnt, string desc, string est,string espe)
        {
            //transac sql
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT TOP(100) * FROM INVENTARIOS WHERE AUXILIAR LIKE '"+ codEnt + "' OR COD_ENTIDAD LIKE '"+ desc + "' OR DESCRIPCION LIKE '"+ est + "' OR ESTADO LIKE '"+ espe + "' ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();
            return tabla;
        }

        public DateTime  RecuperaFecha(string id)
        {
            DateTime cb = DateTime.Now;
            //transac sql            
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM INVENTARIOS_EXCEL I WHERE I.INV_NO='"+id+"' ORDER BY CONVERT(INT,SUBSTRING(I.INV_NO,4,LEN(I.INV_NO))) DESC ";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {                
                     cb = Convert.ToDateTime(leer["FECHA_INGRESO"]);
            }
            conn.CerrarConexion();
            return cb;
        }

        public int id()
        {
            int cod = 0;
            //transac sql            
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT MAX(CONVERT(INT,SUBSTRING(I.INV_NO,4,LEN(I.INV_NO))))+1 as CODIGO FROM INVENTARIOS I";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                cod = Convert.ToInt16(leer["CODIGO"]);
            }
            conn.CerrarConexion();
            return cod;
        }
        public void InsertarP(string aux, string part, string ce, string ca,string se, string des, string es, string esp, string emp, string proc, DateTime fe,string obs)
        {
            int isa = id();
            // PARA EL PROCEDIMIENTO
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "INSERT INTO INVENTARIOS VALUES(CONCAT('AF-',"+isa+"),'"+aux+"','"+part+"','"+ce+"','"+ca+"','"+ce+"','"+des+"','"+es+"','"+esp+"','"+emp+"','"+proc+"',CAST('"+fe+"' AS datetime),'"+obs+"');";
            /*comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@AUXILIAR", aux);
            comando.Parameters.AddWithValue("@PARTIDA", part);
            comando.Parameters.AddWithValue("@COD_ENTIDAD", ce);
            comando.Parameters.AddWithValue("@COD_ANTIGUO", ca);
            comando.Parameters.AddWithValue("@SERIE", se);
            comando.Parameters.AddWithValue("@DESCRIPCION", des);
            comando.Parameters.AddWithValue("@ESTADO", es);
            comando.Parameters.AddWithValue("@ESPECIFICA", esp);
            comando.Parameters.AddWithValue("@EMP_NO", emp);
            comando.Parameters.AddWithValue("@PROCEDENCIA", proc);
            comando.Parameters.AddWithValue("@FECHA_INGRESO",fe);
            comando.Parameters.AddWithValue("@OBSERVACION", obs);
            */
            // Y ASI SUCESIVAMENTE
            comando.ExecuteNonQuery();
            //buffer
            comando.Parameters.Clear();
        }

        public void EditarP(string aux, string part, string ce, string ca, string se,string des, string es, string esp, string emp, string proc, DateTime fe, string obs, String id)
        {
            // PARA EL PROCEDIMIENTO
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "UPDATE INVENTARIOS SET AUXILIAR='"+aux+"',PARTIDA='"+part+"',COD_ENTIDAD='"+ce+"',COD_ANTIGUO='"+ca+"',SERIE='"+se+"',DESCRIPCION='"+des+"',ESTADO='"+es+ "',ESPECIFICA='"+esp+"',EMP_NO='"+emp+"',PROCEDENCIA='"+proc+ "',FECHA_INGRESO=CAST('" + fe + "' AS datetime),OBSERVACION='" + obs+"' WHERE INV_NO='"+id+"'";
            /*
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@AUXILIAR", aux);
            comando.Parameters.AddWithValue("@PARTIDA", part);
            comando.Parameters.AddWithValue("@COD_ENTIDAD", ce);
            comando.Parameters.AddWithValue("@COD_ANTIGUO", ca);
            comando.Parameters.AddWithValue("@SERIE", se);
            comando.Parameters.AddWithValue("@DESCRIPCION", des);
            comando.Parameters.AddWithValue("@ESTADO", es);
            comando.Parameters.AddWithValue("@ESPECIFICA", esp);
            comando.Parameters.AddWithValue("@EMP_NO", emp);
            comando.Parameters.AddWithValue("@PROCEDENCIA", proc);
            comando.Parameters.AddWithValue("@FECHA_INGRESO", fe);
            comando.Parameters.AddWithValue("@OBSERVACION", obs);
            comando.Parameters.AddWithValue("@id", id);
            */
            comando.ExecuteNonQuery();
            // buffer
            comando.Parameters.Clear();
        }

        public void Eliminar(string id)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "DELETE FROM INVENTARIOS WHERE INV_NO='" + id + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

    }
}
