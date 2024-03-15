using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSs
{
    public class TipoprodBss
    {
        TipoprodDal dal = new TipoprodDal();
        public DataTable ListarTipoprodBss()
        {
            return dal.ListarTipoprodDal();
        }
    }
}
