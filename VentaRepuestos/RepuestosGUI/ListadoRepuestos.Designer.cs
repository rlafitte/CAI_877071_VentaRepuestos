
namespace RepuestosGUI
{
    partial class ListadoRepuestos
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
            this.lstRepuestos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tbStockLista = new System.Windows.Forms.TextBox();
            this.tbPrecioLista = new System.Windows.Forms.TextBox();
            this.tbNombreLista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstRepuestos
            // 
            this.lstRepuestos.FormattingEnabled = true;
            this.lstRepuestos.Location = new System.Drawing.Point(37, 52);
            this.lstRepuestos.Name = "lstRepuestos";
            this.lstRepuestos.Size = new System.Drawing.Size(229, 121);
            this.lstRepuestos.TabIndex = 0;
            this.lstRepuestos.SelectedIndexChanged += new System.EventHandler(this.lstRepuestos_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(37, 227);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 36);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbStockLista
            // 
            this.tbStockLista.Location = new System.Drawing.Point(451, 149);
            this.tbStockLista.Name = "tbStockLista";
            this.tbStockLista.Size = new System.Drawing.Size(92, 20);
            this.tbStockLista.TabIndex = 17;
            // 
            // tbPrecioLista
            // 
            this.tbPrecioLista.Location = new System.Drawing.Point(451, 117);
            this.tbPrecioLista.Name = "tbPrecioLista";
            this.tbPrecioLista.Size = new System.Drawing.Size(92, 20);
            this.tbPrecioLista.TabIndex = 16;
            // 
            // tbNombreLista
            // 
            this.tbNombreLista.Location = new System.Drawing.Point(451, 85);
            this.tbNombreLista.Name = "tbNombreLista";
            this.tbNombreLista.Size = new System.Drawing.Size(92, 20);
            this.tbNombreLista.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // tbCodigoLista
            // 
            this.tbCodigoLista.Location = new System.Drawing.Point(451, 52);
            this.tbCodigoLista.Name = "tbCodigoLista";
            this.tbCodigoLista.Size = new System.Drawing.Size(92, 20);
            this.tbCodigoLista.TabIndex = 10;
            // 
            // ListadoRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 307);
            this.Controls.Add(this.tbStockLista);
            this.Controls.Add(this.tbPrecioLista);
            this.Controls.Add(this.tbNombreLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigoLista);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstRepuestos);
            this.Name = "ListadoRepuestos";
            this.Text = "ListadoRepuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRepuestos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tbStockLista;
        private System.Windows.Forms.TextBox tbPrecioLista;
        private System.Windows.Forms.TextBox tbNombreLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoLista;
    }
}