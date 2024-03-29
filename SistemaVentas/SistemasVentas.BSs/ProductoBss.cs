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
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBSs(Producto producto)
        {
            dal.InsertarProducto(producto);
        }
        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoIdDal(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
