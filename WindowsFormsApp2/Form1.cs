using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Mysql;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new tccfinalContext())
            {

                var a = db.User.FirstOrDefault(x => x.Login == textBox1.Text);
                var b = db.User.FirstOrDefault(x => x.Senha == textBox2.Text);

                if (a != null && b != null)
                {

                    this.Hide();
                    Form f = new Form2();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
