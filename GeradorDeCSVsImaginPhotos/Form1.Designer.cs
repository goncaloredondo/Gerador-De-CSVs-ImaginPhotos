using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeCSVsImaginPhotos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private Button btnAdicionar;
        private Button btnCriarCSV;
        private ComboBox cbCategorias = new ComboBox();
        private ComboBox cbFotos = new ComboBox();
        private ComboBox cbTipo = new ComboBox();
        private Label lblAutor;
        private Label lblCategoria;
        private Label lblDescricao;
        private Label lblFotos;
        private Label lblNome;
        private Label lblTipo;
        private PictureBox pbFoto;
        private PictureBox pbLogo;
        private RichTextBox rtbDescricao;
        private TextBox txtAutor;
        private TextBox txtNome;
        private void ControlsCreator()
        {
            // 
            // btnAdicionar
            // 
            btnAdicionar = new Button();
            btnAdicionar.Location = new System.Drawing.Point(15, 240);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(135, 21);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar foto";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCriarCSV
            // 
            btnCriarCSV = new Button();
            btnCriarCSV.Location = new System.Drawing.Point(169, 240);
            btnCriarCSV.Name = "btnCriarCSV";
            btnCriarCSV.Size = new System.Drawing.Size(135, 21);
            btnCriarCSV.TabIndex = 41;
            btnCriarCSV.Text = "Criar CSV";
            btnCriarCSV.UseVisualStyleBackColor = true;
            btnCriarCSV.Click += new System.EventHandler(this.button_Click);
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new System.Drawing.Point(135, 77);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new System.Drawing.Size(169, 21);
            cbCategorias.TabIndex = 40;
            // 
            // cbFotos
            // 
            cbFotos.FormattingEnabled = true;
            cbFotos.Location = new System.Drawing.Point(135, 15);
            cbFotos.Name = "cbFotos";
            cbFotos.Size = new System.Drawing.Size(169, 21);
            cbFotos.TabIndex = 2;
            cbFotos.Text = "Escolha Uma Foto";
            cbFotos.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndex);
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new System.Drawing.Point(135, 108);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new System.Drawing.Size(169, 21);
            cbTipo.TabIndex = 33;
            // 
            // lblAutor
            // 
            lblAutor = new Label();
            lblAutor.AutoSize = true;
            lblAutor.Location = new System.Drawing.Point(15, 215);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new System.Drawing.Size(35, 13);
            lblAutor.TabIndex = 37;
            lblAutor.Text = "Autor:";
            // 
            // lblCategoria
            // 
            lblCategoria = new Label();
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(15, 82);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(55, 13);
            lblCategoria.TabIndex = 22;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            lblDescricao = new Label();
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new System.Drawing.Point(15, 144);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new System.Drawing.Size(58, 13);
            lblDescricao.TabIndex = 24;
            lblDescricao.Text = "Descrição:";
            // 
            // lblFotos
            // 
            lblFotos = new Label();
            lblFotos.AutoSize = true;
            lblFotos.Location = new System.Drawing.Point(15, 20);
            lblFotos.Name = "lblFotos";
            lblFotos.Size = new System.Drawing.Size(111, 13);
            lblFotos.TabIndex = 17;
            lblFotos.Text = "Fotos para preencher:";
            // 
            // lblNome
            // 
            lblNome = new Label();
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(15, 51);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(38, 13);
            lblNome.TabIndex = 30;
            lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            lblTipo = new Label();
            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(15, 113);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(31, 13);
            lblTipo.TabIndex = 39;
            lblTipo.Text = "Tipo:";
            // 
            // pbFoto
            // 
            pbFoto = new PictureBox();
            pbFoto.Location = new System.Drawing.Point(325, 15);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new System.Drawing.Size(500, 500);
            pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo = new PictureBox();
            pbLogo.Image = Image.FromFile(programPath + "\\Logo_2PB_500.png");
            pbLogo.Location = new System.Drawing.Point(58, 287);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(200, 200);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // rtbDescricao
            // 
            rtbDescricao = new RichTextBox();
            rtbDescricao.Location = new System.Drawing.Point(135, 139);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new System.Drawing.Size(169, 60);
            rtbDescricao.TabIndex = 15;
            // 
            // txtAutor
            // 
            txtAutor = new TextBox();
            txtAutor.Location = new System.Drawing.Point(135, 210);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new System.Drawing.Size(169, 20);
            txtAutor.TabIndex = 34;
            // 
            // txtNome
            // 
            txtNome = new TextBox();
            txtNome.Location = new System.Drawing.Point(135, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(169, 20);
            txtNome.TabIndex = 16;
            Controls.Add(btnAdicionar);
            Controls.Add(btnCriarCSV);
            Controls.Add(cbCategorias);
            Controls.Add(cbFotos);
            Controls.Add(cbTipo);
            Controls.Add(lblAutor);
            Controls.Add(lblCategoria);
            Controls.Add(lblDescricao);
            Controls.Add(lblFotos);
            Controls.Add(lblNome);
            Controls.Add(lblTipo);
            Controls.Add(pbFoto);
            Controls.Add(pbLogo);
            Controls.Add(txtAutor);
            Controls.Add(rtbDescricao);
            Controls.Add(txtNome);
        }
        private void InitializeComponent()
        {
            //((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 532);
            this.Icon = new Icon(programPath + "\\Favicon.ico");
            this.Name = "Form1";
            this.Text = "Gerador de CSV ImaginPhotos";
            //((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}