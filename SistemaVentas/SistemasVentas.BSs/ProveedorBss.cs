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
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBSs(Proveedor proveedor)
        {
            dal.InsertarProvedorDal(proveedor);

        }
        public Proveedor ObtenerProveedorIdBss(int id)
        {
            return dal.ObtenerProveedorIdDal(id);
        }
        public void EditarProveedorBss(Proveedor p)
        {
            dal.EditarProveedorDal(p);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
}
