using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSs
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public void InsertarVentaBSs(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public Venta ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaId(id);
        }
        public void EditarVentaBss(Venta venta)
        {
            dal.EditarVentaDal(venta);
        }

        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }
    }
}
