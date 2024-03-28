using SistemasVentas.BSs;
using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonasVISTA;
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

namespace SistemasVentas.VISTA.ClienteVista
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente p = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.TipoCliente = textBox1.Text;
            p.CodigoCliente = textBox2.Text;

            bss.EditarClienteBss(p);
            MessageBox.Show("Datos Actualizados");

        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerClienteIdBss(idx);
            textBox3.Text = p.IdPersona.ToString();
            textBox1.Text = p.TipoCliente;
            textBox2.Text = p.CodigoCliente;
        }
    }
}
