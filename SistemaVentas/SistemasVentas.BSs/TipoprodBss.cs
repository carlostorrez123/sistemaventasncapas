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
    public class TipoprodBss
    {
        TipoprodDal dal = new TipoprodDal();

        public string Nombre { get; set; }

        public DataTable ListarTipoprodBss()

        {
            return dal.ListarTipoprodDal();
        }
        public void InsertarTipoprodBSs(Tipoprod tipoprod)
        {
            dal.InserartipoprodDal(tipoprod);
        }
        public Tipoprod ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProdIdDal(id);
        }
        public void EditarTipoProdBss(Tipoprod p)
        {
            dal.EditarTipoProdDal(p);
        }
        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
