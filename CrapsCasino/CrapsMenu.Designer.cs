namespace CrapsCasino
{
    partial class CrapsMenu
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
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_NombreJuego = new System.Windows.Forms.Label();
            this.btn_JugarVarios = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.lbl_NombreJuego);
            this.pnl_Menu.Controls.Add(this.btn_JugarVarios);
            this.pnl_Menu.Location = new System.Drawing.Point(12, 12);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(280, 161);
            this.pnl_Menu.TabIndex = 0;
            // 
            // lbl_NombreJuego
            // 
            this.lbl_NombreJuego.AutoSize = true;
            this.lbl_NombreJuego.Location = new System.Drawing.Point(99, 24);
            this.lbl_NombreJuego.Name = "lbl_NombreJuego";
            this.lbl_NombreJuego.Size = new System.Drawing.Size(86, 13);
            this.lbl_NombreJuego.TabIndex = 2;
            this.lbl_NombreJuego.Text = "CRAPS CASINO";
            // 
            // btn_JugarVarios
            // 
            this.btn_JugarVarios.Location = new System.Drawing.Point(102, 90);
            this.btn_JugarVarios.Name = "btn_JugarVarios";
            this.btn_JugarVarios.Size = new System.Drawing.Size(83, 41);
            this.btn_JugarVarios.TabIndex = 1;
            this.btn_JugarVarios.Text = "Jugar con Varios";
            this.btn_JugarVarios.UseVisualStyleBackColor = true;
            this.btn_JugarVarios.Click += new System.EventHandler(this.btn_JugarVarios_Click);
            // 
            // CrapsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 180);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "CrapsMenu";
            this.Text = "CrapsMenu";
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_NombreJuego;
        private System.Windows.Forms.Button btn_JugarVarios;
    }
}