using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from Proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProvedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                          "'" + proveedor.Telefono + "'," +
                                                          "'" + proveedor.Dirección + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Proveedor p = new Proveedor();
        public Proveedor ObtenerProveedorIdDal(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p. Dirección = tabla.Rows[0]["direccion"].ToString();
            }
            return p;
        }
        public void EditarProveedorDal(Proveedor p)
        {
            string consulta = "update proveedor set nombre='" + p.Nombre + "'," +
                                                        "telefono='" + p.Telefono + "'," +
                                                        "direccion='" + p.Dirección + "'," +
                                                "where idproveedor=" + p.IdProveedor;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
