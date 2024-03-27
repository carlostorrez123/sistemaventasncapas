using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from DetalleVenta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleVenta values(" + detalleventa.IdVenta + "," +
                                                          "" + detalleventa.IdProducto + "," +
                                                          "" + detalleventa.Cantidad + "," +
                                                          "" + detalleventa.PrecioVenta + "," +
                                                          "" + detalleventa.SubTotal + "," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta deve = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                deve.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                deve.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                deve.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                deve.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                deve.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"].ToString());
                deve.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subTotal"].ToString());
            }
            return deve;
        }
        public void EditarDetalleVentaDal(DetalleVenta p)
        {
            string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.SubTotal + " " +
                                                "where iddetalleventa=" + p.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
