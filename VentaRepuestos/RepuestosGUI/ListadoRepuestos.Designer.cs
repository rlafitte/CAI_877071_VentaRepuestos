
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
            this.SuspendLayout();
            // 
            // lstRepuestos
            // 
            this.lstRepuestos.FormattingEnabled = true;
            this.lstRepuestos.Location = new System.Drawing.Point(37, 52);
            this.lstRepuestos.Name = "lstRepuestos";
            this.lstRepuestos.Size = new System.Drawing.Size(229, 121);
            this.lstRepuestos.TabIndex = 0;
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
            // ListadoRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 307);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstRepuestos);
            this.Name = "ListadoRepuestos";
            this.Text = "ListadoRepuestos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRepuestos;
        private System.Windows.Forms.Button btnVolver;
    }
}