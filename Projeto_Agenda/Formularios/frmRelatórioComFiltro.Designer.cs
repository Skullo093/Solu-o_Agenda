
namespace Projeto_Agenda.Formularios
{
    partial class frmRelatórioComFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSet_Agenda = new Projeto_Agenda.Dados.DataSet_Agenda();
            this.tbpessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_pessoaTableAdapter = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.tb_pessoaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cidadesPessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.cidades_PessoasTableAdapter = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.Cidades_PessoasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesPessoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesPessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesPessoasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpessoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpessoaBindingSource
            // 
            this.tbpessoaBindingSource.DataMember = "tb_pessoa";
            this.tbpessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // tb_pessoaTableAdapter
            // 
            this.tb_pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por Cidade";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cidadesPessoasBindingSource;
            this.comboBox1.DisplayMember = "Cidade";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Cidade";
            // 
            // cidadesPessoasBindingSource
            // 
            this.cidadesPessoasBindingSource.DataMember = "Cidades_Pessoas";
            this.cidadesPessoasBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(253, 27);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 3;
            this.btn_Filtrar.Text = "FILTRAR";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.Location = new System.Drawing.Point(404, 27);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(75, 23);
            this.btn_todos.TabIndex = 4;
            this.btn_todos.Text = "TODOS";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // cidades_PessoasTableAdapter
            // 
            this.cidades_PessoasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "PessoaComFiltro";
            reportDataSource1.Value = this.tbpessoaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Agenda.Relatorios.RelatórioComFiltro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 345);
            this.reportViewer1.TabIndex = 5;
            // 
            // tb_pessoaBindingSource
            // 
            this.tb_pessoaBindingSource.DataMember = "tb_pessoa";
            this.tb_pessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // cidadesPessoasBindingSource1
            // 
            this.cidadesPessoasBindingSource1.DataMember = "Cidades_Pessoas";
            this.cidadesPessoasBindingSource1.DataSource = this.dataSet_Agenda;
            // 
            // tbpessoaBindingSource1
            // 
            this.tbpessoaBindingSource1.DataMember = "tb_pessoa";
            this.tbpessoaBindingSource1.DataSource = this.dataSet_Agenda;
            // 
            // frmRelatórioComFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRelatórioComFiltro";
            this.Text = "frmRelatórioComFiltro";
            this.Load += new System.EventHandler(this.frmRelatórioComFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesPessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesPessoasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpessoaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource tbpessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.tb_pessoaTableAdapter tb_pessoaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.BindingSource cidadesPessoasBindingSource;
        private Dados.DataSet_AgendaTableAdapters.Cidades_PessoasTableAdapter cidades_PessoasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_pessoaBindingSource;
        private System.Windows.Forms.BindingSource cidadesPessoasBindingSource1;
        private System.Windows.Forms.BindingSource tbpessoaBindingSource1;
    }
}