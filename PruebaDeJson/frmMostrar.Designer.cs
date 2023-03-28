namespace PruebaDeJson
{
    partial class frmMostrar
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
            lvImprimir = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnMostrar = new Button();
            btnDevolver = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lvImprimir
            // 
            lvImprimir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvImprimir.Location = new Point(133, 8);
            lvImprimir.Name = "lvImprimir";
            lvImprimir.Size = new Size(464, 335);
            lvImprimir.TabIndex = 0;
            lvImprimir.UseCompatibleStateImageBehavior = false;
            lvImprimir.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ISBN";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TITULO";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "AUTOR";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EDITORIAL";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "PAGINAS";
            columnHeader5.Width = 100;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 8);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(115, 41);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(12, 55);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(115, 38);
            btnDevolver.TabIndex = 2;
            btnDevolver.Text = "DEVOLVER";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 99);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 355);
            Controls.Add(btnSalir);
            Controls.Add(btnDevolver);
            Controls.Add(btnMostrar);
            Controls.Add(lvImprimir);
            Name = "frmMostrar";
            Text = "frmMostrar";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvImprimir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnMostrar;
        private Button btnDevolver;
        private Button btnSalir;
    }
}