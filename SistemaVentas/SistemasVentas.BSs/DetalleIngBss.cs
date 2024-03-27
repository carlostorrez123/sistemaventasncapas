using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSs
{
    public class DetalleIngBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListarDetalleIngBss()
        {
            return dal.ListarDetalleIngDal();
        }
        public void InsertarDetalleIngBSs(DetalleIng detalleing)
        {
            dal.InsertarDetalleIngDal(detalleing);
        }
        public DetalleIng ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngIdDal(id);
        }
        public void EditarDetalleIngBss(DetalleIng p)
        {
            dal.EditarDetalleIngDal(p);
        }
        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
    }
}
