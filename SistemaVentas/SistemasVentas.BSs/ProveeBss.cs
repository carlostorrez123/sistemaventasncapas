using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;

namespace SistemasVentas.BSs
{
    internal class ProveeBss
    {
        ProveeDal dal = new ProveeDal();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarProveeDal();
        }
    }
}
