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
    public partial class Cliente : UserControl
    {
        public Cliente()
        {
            InitializeComponent();
            carregarDadosGrid();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
        void carregarDadosGrid()
        {

            using (var db = new tccfinalContext())
            {


                //Database query direto na DataSource
                dgvClientes.DataSource = db.Cliente.Select(x =>
                    new
                    {
                        Id = x.CodCliente,
                        Nome = x.NomeCliente,
                        TipoPessoa = x.TipoPessoaNavigation.TipoPessoa1,
                        UF = x.UfNavigation.Estado1,
                        Avaliacao = x.AvaliacaoClienteNavigation.Avaliacao1,
                        CPF_CNPJ = x.CpfCnpj,
                        TelefoneFixo = x.TelFixo,
                        Celular = x.TelCel,
                        Email = x.EmailCliete,
                        Cidade = x.Cidade,
                        CEP = x.CepCliente,
                        Endereço = x.EnderecoCliente,

                    }).ToList();

                //Configuracoes de DataGridView
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.ReadOnly = true;


                //Customizando as colunas
                dgvClientes.Columns["Id"].Visible = false;
                dgvClientes.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["TipoPessoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["Avaliacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["UF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["CPF_CNPJ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["TelefoneFixo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["Celular"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["Cidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["CEP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvClientes.Columns["Endereço"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            }
        }
    }
}
