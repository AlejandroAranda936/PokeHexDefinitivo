using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeHexDefinitivo
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Tabla Pokedex = new Tabla();
            Pokedex.Show();
            this.Hide();
        }
    }
}
