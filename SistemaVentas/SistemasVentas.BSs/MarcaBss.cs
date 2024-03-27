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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBSs(Marca marca)
        {
            dal.InsertarMarcaDal(marca);

        }
        public Marca ObtenerMarcaIdBss(int id)
        {
            return dal.ObtenerMarcaIdDal(id);
        }
        public void EditarMarcaBss(Marca p)
        {
            dal.EditarMarcaDal(p);
        }
        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);
        }


    }
}
