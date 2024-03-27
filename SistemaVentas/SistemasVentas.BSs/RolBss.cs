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
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }
        public void InsertarRolBSs(Rol rol)
        {
            dal.InserarRolDal(rol);
        }
        public Rol ObtenerRolIdBss(int id)
        {
            return dal.ObtenerRolIdDal(id);
        }
        public void EditarRolBss(Rol p)
        {
            dal.EditarRolDal(p);
        }
        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }
    }
}
