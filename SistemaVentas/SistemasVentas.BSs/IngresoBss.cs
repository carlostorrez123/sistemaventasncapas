﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSs
{
    public class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresoBSs(Ingreso ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }
        public Ingreso ObtenerIngresoIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }
        public void EditarIngresoBss(Ingreso ingreso)
        {
            dal.EditarIngresoDal(ingreso);
        }
        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
    }
}
