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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class orcamento : UserControl
    {
        public orcamento()
        {
            InitializeComponent();
            carregarDadosGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void orcamento_Load(object sender, EventArgs e)
        {

        }
        void carregarDadosGrid()
        {

            using (var db = new tccfinalContext())
            {


                //Database query direto na DataSource
                dgvOrcamentos.DataSource = db.Orcamentos.Select(x =>
                    new
                    {
                        Id = x.CodOrca,
                        Cliente = x.ClienteNavigation.NomeCliente,
                        CPF_CNPJ = x.ClienteNavigation.CpfCnpj,
                        DataOrçamento = x.DataOrca,
                        ValorOrcamento = x.ValorOrca,
                        MetodoPagamento = x.MetodoPagNavigation.MPag,
                        DataEntrega = x.DataEntrega,
                        Status = x.StatusOrcaNavigation.Status1,
                        AnoId = x.AnoId,
                        MesId = x.MesId,
                        DiaId = x.DiaId,
                    }).ToList();

                //Configuracoes de DataGridView
                dgvOrcamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOrcamentos.AutoGenerateColumns = false;
                dgvOrcamentos.ReadOnly = true;
                //Customizando as colunas
                dgvOrcamentos.Columns["Id"].Visible = false;               
                dgvOrcamentos.Columns["Dataorçamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["ValorOrcamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["DataEntrega"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["AnoId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["MesId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["DiaId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["MetodoPagamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrcamentos.Columns["CPF_CNPJ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new tccfinalContext())
            {
              
                var query1 = db.Orcamentos.Where(ru => ru.AnoId = AnoId).tolist();




            }

        }
    }
}

