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
    public partial class frmRelatório : Form
    {
        public frmRelatório()
        {
            InitializeComponent();
        }

        private void frmRelatório_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.tb_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_pessoaTableAdapter.Fill(this.dataSet_Agenda.tb_pessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
