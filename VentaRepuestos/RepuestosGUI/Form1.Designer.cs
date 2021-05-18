
namespace RepuestosGUI
{
    partial class Form1
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
            this.txtAgregarRep = new System.Windows.Forms.Button();
            this.txtQuitarRep = new System.Windows.Forms.Button();
            this.txtModifRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAgregarRep
            // 
            this.txtAgregarRep.Location = new System.Drawing.Point(78, 73);
            this.txtAgregarRep.Name = "txtAgregarRep";
            this.txtAgregarRep.Size = new System.Drawing.Size(126, 60);
            this.txtAgregarRep.TabIndex = 0;
            this.txtAgregarRep.Text = "Agregar repuesto";
            this.txtAgregarRep.UseVisualStyleBackColor = true;
            this.txtAgregarRep.Click += new System.EventHandler(this.txtAgregarRep_Click);
            // 
            // txtQuitarRep
            // 
            this.txtQuitarRep.Location = new System.Drawing.Point(78, 183);
            this.txtQuitarRep.Name = "txtQuitarRep";
            this.txtQuitarRep.Size = new System.Drawing.Size(126, 60);
            this.txtQuitarRep.TabIndex = 1;
            this.txtQuitarRep.Text = "Quitar repuesto";
            this.txtQuitarRep.UseVisualStyleBackColor = true;
            // 
            // txtModifRep
            // 
            this.txtModifRep.Location = new System.Drawing.Point(78, 284);
            this.txtModifRep.Name = "txtModifRep";
            this.txtModifRep.Size = new System.Drawing.Size(126, 60);
            this.txtModifRep.TabIndex = 2;
            this.txtModifRep.Text = "Modificar repuesto";
            this.txtModifRep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtModifRep);
            this.Controls.Add(this.txtQuitarRep);
            this.Controls.Add(this.txtAgregarRep);
            this.Name = "Form1";
            this.Text = "Venta de Repuestos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAgregarRep;
        private System.Windows.Forms.Button txtQuitarRep;
        private System.Windows.Forms.Button txtModifRep;
    }
}

