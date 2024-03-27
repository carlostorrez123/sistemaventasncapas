using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public  class TipoprodDal
    {
        public DataTable ListarTipoprodDal()
        {
            string consulta = "select * from Tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InserartipoprodDal(Tipoprod tipoprod)
        {
            string consulta = "insert into tipoProd values('" + tipoprod.Nombre + "'," + "','"
                                                        + tipoprod.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        Tipoprod p = new Tipoprod();
        public Tipoprod ObtenerTipoProdIdDal(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdTipoprod = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarTipoProdDal(Tipoprod p)
        {
            string consulta = "update tipoprod set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idtipoprod=" + p.IdTipoprod;
            conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }


    }
}
