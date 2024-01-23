using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair ?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimizar 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelcentral.Controls.Clear();
        }

        private void panelcentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCadClientes clientes = new FormCadClientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelcentral.Controls.Clear();//limpa O PAINEL
            panelcentral.Controls.Add(clientes);//adiciona o form no painel 
            clientes.Show();



        }
    }
}
