
namespace Gasto_Combustível
{
    partial class Principal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnUtilidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalculaGasto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPrincipal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUtilidades,
            this.mnSobre});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnUtilidades
            // 
            this.mnUtilidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCalculaGasto});
            this.mnUtilidades.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnUtilidades.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mnUtilidades.Name = "mnUtilidades";
            this.mnUtilidades.Size = new System.Drawing.Size(89, 20);
            this.mnUtilidades.Text = "Utilidades";
            // 
            // mnCalculaGasto
            // 
            this.mnCalculaGasto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnCalculaGasto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mnCalculaGasto.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mnCalculaGasto.Name = "mnCalculaGasto";
            this.mnCalculaGasto.Size = new System.Drawing.Size(165, 22);
            this.mnCalculaGasto.Text = "Calcula Gasto";
            this.mnCalculaGasto.Click += new System.EventHandler(this.mnCalculaGasto_Click);
            // 
            // mnSobre
            // 
            this.mnSobre.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnSobre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mnSobre.Name = "mnSobre";
            this.mnSobre.Size = new System.Drawing.Size(54, 20);
            this.mnSobre.Text = "Sobre";
            this.mnSobre.Click += new System.EventHandler(this.mnSobre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(248, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(26, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(726, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esta é sua ferramenta de Cálculo de gasto de Combustível.";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.Text = "Cálculo de Combustível";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnUtilidades;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnSobre;
        private System.Windows.Forms.ToolStripMenuItem mnCalculaGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

