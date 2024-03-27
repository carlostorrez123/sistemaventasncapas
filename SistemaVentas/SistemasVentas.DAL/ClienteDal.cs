using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdCliente + "," +
                                                          "'" + cliente.TipoCliente + "'," +
                                                          "'" + cliente.CodigoCliente + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Cliente p = new Cliente();
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                p.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
            }
            return p;
        }
        public void EditarClienteDal(Cliente p)
        {
            string consulta = "update cliente set idpersona=" + p.IdPersona + "," +
                                                        "tipocliente='" + p.TipoCliente + "'," +
                                                        "codigocliente='" + p.CodigoCliente + "'" +
                                                "where idcliente=" + p.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}