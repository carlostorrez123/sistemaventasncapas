using SistemasVentas.BSs;
using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVista;
using SistemasVentas.VISTA.UsuarioVista;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentaVista
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta p = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerVentaIdBss(idx);
            textBox2.Text = p.IdCliente.ToString();
            textBox3.Text = p.IdVendedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox1.Text = p.Total.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssvend.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox3.Text = usuario.IdUsuario.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox1.Text);

            bss.EditarVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bssclien = new ClienteBss();

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssclien.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox2.Text = cliente.IdCliente.ToString();
            }
        }
        public static int IdVendedorSeleccionada = 0;
        UsuarioBss bssvend = new UsuarioBss();
    }
    
}
