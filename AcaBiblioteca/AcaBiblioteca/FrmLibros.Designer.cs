namespace AcaBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pnlDatos = new Panel();
            lblISBN = new Label();
            lblTituloLib = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblCategoria = new Label();
            lblAno = new Label();
            lblExistencias = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtCategoria = new TextBox();
            txtAno = new TextBox();
            txtExistencias = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(971, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(315, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(971, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(259, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 25);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(357, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(198, 31);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(602, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAno);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAno);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(971, 388);
            pnlDatos.TabIndex = 2;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(282, 38);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(64, 25);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN :";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(282, 84);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(72, 25);
            lblTituloLib.TabIndex = 4;
            lblTituloLib.Text = "Título :";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(282, 126);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(71, 25);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor :";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(282, 175);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(93, 25);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial :";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(282, 220);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(104, 25);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría :";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(282, 261);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(57, 25);
            lblAno.TabIndex = 8;
            lblAno.Text = "Año :";
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(282, 303);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(115, 25);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias :";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(432, 38);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(244, 31);
            txtISBN.TabIndex = 3;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(432, 84);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(244, 31);
            txtTitulo.TabIndex = 10;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(432, 217);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(244, 31);
            txtCategoria.TabIndex = 11;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(432, 261);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(244, 31);
            txtAno.TabIndex = 12;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(432, 303);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(244, 31);
            txtExistencias.TabIndex = 13;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(432, 126);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(244, 33);
            cmbAutor.TabIndex = 14;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(432, 172);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(244, 33);
            cmbEditorial.TabIndex = 15;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 629);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel pnlDatos;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblISBN;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAno;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lblExistencias;
        private Label lblAno;
    }
}