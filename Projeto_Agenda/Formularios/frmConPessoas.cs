using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmConPessoas : Form
    {
        public frmConPessoas()
        {
            InitializeComponent();
        }

        private void tb_pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void frmConPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.tb_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_pessoaTableAdapter.Fill(this.dataSet_Agenda.tb_pessoa);

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string Coluna, Procurar, Texto, Filtro;

            Coluna = comboBox1.Text;
            Procurar = comboBox2.Text;
            Texto = textBox1.Text;

            Filtro = Coluna;


            if (Procurar == "Que começa com")
            {
                Filtro += " like '" + Texto + "%'";
            }

            else if (Procurar == "Que contém")
            {
                Filtro += " like '%" + Texto + "%'";
            }

            else if (Procurar == "Que termina com")
            {
                Filtro += " like '%" + Texto + "'";
            }

            else if (Procurar == "Igual a")
            {
                Filtro += "='" + Texto + "'";
            }

            else
            {
                Filtro = "";
            }

            tb_pessoaBindingSource.Filter = Filtro;
        }
    }
}
