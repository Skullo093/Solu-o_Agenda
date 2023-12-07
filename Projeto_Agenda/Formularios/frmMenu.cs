using Projeto_Agenda.Formularios;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConPessoas objConPessoas = new frmConPessoas();
            objConPessoas.MdiParent = this;
            objConPessoas.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmConPessoas objConPessoas = new frmConPessoas();
            objConPessoas.MdiParent = this;
            objConPessoas.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatório objRelatório = new frmRelatório();
            objRelatório.MdiParent = this;
            objRelatório.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmRelatório objRelatório = new frmRelatório();
            objRelatório.MdiParent = this;
            objRelatório.Show();
        }

        private void relatórioComFiltro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatórioComFiltro objRelatórioComFiltro = new frmRelatórioComFiltro();
            objRelatórioComFiltro.MdiParent = this;
            objRelatórioComFiltro.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmRelatórioComFiltro objRelatórioComFiltro = new frmRelatórioComFiltro();
            objRelatórioComFiltro.MdiParent = this;
            objRelatórioComFiltro.Show();
        }
    }
}
