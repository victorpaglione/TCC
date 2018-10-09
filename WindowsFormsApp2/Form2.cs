using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panelleft.Height = button1.Height;
            panelleft.Top = button1.Top;
            orcamento1.Visible = true;
            cliente1.Visible = false;
            servicos1.Visible = false;
            opcoes1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelleft.Height = button1.Height;
            panelleft.Top = button1.Top;
            orcamento1.Visible = true;
            cliente1.Visible = false;
            servicos1.Visible = false;
            opcoes1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelleft.Height = button2.Height;
            panelleft.Top = button2.Top;
            orcamento1.Visible = false;
            cliente1.Visible = true;
            servicos1.Visible = false;
            opcoes1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelleft.Height = button3.Height;
            panelleft.Top = button3.Top;
            orcamento1.Visible = false;
            cliente1.Visible = false;
            servicos1.Visible = true;
            opcoes1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelleft.Height = button3.Height;
            panelleft.Top = button3.Top;
            orcamento1.Visible = false;
            cliente1.Visible = false;
            servicos1.Visible = false;
            opcoes1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
