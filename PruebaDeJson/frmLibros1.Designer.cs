namespace PruebaDeJson
{
    partial class frmLibros1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtAutor = new TextBox();
            label4 = new Label();
            txtEditorial = new TextBox();
            label5 = new Label();
            txtPagina = new TextBox();
            label6 = new Label();
            btnRegistrar = new Button();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIBROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 56);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(76, 56);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(169, 23);
            txtISBN.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(327, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(169, 23);
            txtTitulo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(267, 60);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "TITULO";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(597, 58);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(169, 23);
            txtAutor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(538, 60);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 5;
            label4.Text = "AUTOR";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(197, 105);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(169, 23);
            txtEditorial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(110, 107);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 7;
            label5.Text = "EDITORIAL";
            // 
            // txtPagina
            // 
            txtPagina.Location = new Point(468, 107);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(169, 23);
            txtPagina.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(382, 109);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 9;
            label6.Text = "PAGINAS";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(327, 158);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 36);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(327, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 36);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(327, 242);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(105, 36);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(327, 284);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 36);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLibros1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 339);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPagina);
            Controls.Add(label6);
            Controls.Add(txtEditorial);
            Controls.Add(label5);
            Controls.Add(txtAutor);
            Controls.Add(label4);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(txtISBN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLibros1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtISBN;
        private TextBox txtTitulo;
        private Label label3;
        private TextBox txtAutor;
        private Label label4;
        private TextBox txtEditorial;
        private Label label5;
        private TextBox txtPagina;
        private Label label6;
        private Button btnRegistrar;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnSalir;
    }
}