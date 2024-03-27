using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from Venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                          "" + venta.IdVendedor + "," +
                                                          "'" + venta.Fecha + "'," +
                                                          "" + venta.Total + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                venta.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idVendedor"]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                venta.Total = Convert.ToDecimal(tabla.Rows[0]["total"].ToString());
            }
            return venta;
        }
        public void EditarVentaDal(Venta venta)
        {
            string consulta = "update venta set idcliente =" + venta.IdCliente + "," +
                                               "idVendedor =" + venta.IdVendedor + "," +
                                               "fecha ='" + venta.Fecha + "'," +
                                               "total =" + venta.Total + "," +
                                               "estado ='" + venta.Estado + "'" +
                                    "where idventa =" + venta.IdVenta;

            conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
