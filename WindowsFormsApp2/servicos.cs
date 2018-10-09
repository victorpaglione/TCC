using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Mysql;

namespace WindowsFormsApp2
{
    public partial class servicos : UserControl
    {
        public servicos()
        {
            InitializeComponent();
            carregarDadosGrid();
        }

        private void servicos_Load(object sender, EventArgs e)
        {

        }

        void carregarDadosGrid()
        {

            using (var db = new tccfinalContext())
            {


                //Database query direto na DataSource
                dgvServicos.DataSource = db.Servico.Select(x =>
                    new
                    {
                        Id = x.CodOrca,
                        Nome = x.CodServico,
                        Dataorcamento = x.ValorServiço,
                        ValorOrcamento = x.DescServ,

                    }).ToList();

                //Configuracoes de DataGridView
                dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvServicos.AutoGenerateColumns = false;
                dgvServicos.ReadOnly = true;


                //Customizando as colunas
                dgvServicos.Columns["Id"].Visible = true;
                dgvServicos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               
                dgvServicos.Columns["Dataorcamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvServicos.Columns["ValorOrcamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
              

            }

        }
    }
}
