using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from Ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                          "'" + ingreso.FechaIngreso + "'," +
                                                          "" + ingreso.Total + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Ingreso pe = new Ingreso();
        public Ingreso ObtenerIngresoId(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                pe.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                pe.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                pe.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                pe.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return pe;
        }
        public void EditarIngresoDal(Ingreso p)
        {
            string consulta = "update ingreso set idproveedor=" + p.IdProveedor + "," +
                                                        "fechaingreso='" + p.FechaIngreso + "'," +
                                                        "total=" + p.Total + "," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idingreso=" + p.IdIngreso;
            conexion.Ejecutar(consulta);
        }
        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
