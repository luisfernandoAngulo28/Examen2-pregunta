using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class FListaS : Form
    {
        public FListaS()
        {
            InitializeComponent();
        }

        clsListaS L = new clsListaS();

        private void FcolaC_Load(object sender, EventArgs e)
        {

        }

        private void CmdCreaS_Click(object sender, EventArgs e)
        {
            //Q.Drop();
            //lblCola.Text = Q.Imprimir();
            //lblLong.Text = "";
            //lblRear.Text = "";
            //lblFront.Text = "";
            //txtEleme.Text = "";
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // escriba aqui el codigo

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colocar aqui el codigo
        }

        private void cmdFront_Click(object sender, EventArgs e)
        {
            //lblFront.Text = Convert.ToString(Q.Frente());
        }

        private void cmdRear_Click(object sender, EventArgs e)
        {
            //lblRear.Text = Convert.ToString(Q.Atras());
        }

        private void txtEleme_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
