using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class frmRelatórioComFiltro : Form
    {
        public frmRelatórioComFiltro()
        {
            InitializeComponent();
        }

        private void frmRelatórioComFiltro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Cidades_Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.cidades_PessoasTableAdapter.Fill(this.dataSet_Agenda.Cidades_Pessoas);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.tb_pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_pessoaTableAdapter.Fill(this.dataSet_Agenda.tb_pessoa);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade", comboBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade",(string)null));
            this.reportViewer1.RefreshReport();
        }
    }
}
