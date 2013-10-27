namespace CrapsCasino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbx_p1 = new System.Windows.Forms.PictureBox();
            this.pbx_p2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apuestaJugador1 = new System.Windows.Forms.TextBox();
            this.lbl_ApuestaJugador1 = new System.Windows.Forms.Label();
            this.lbl_NomJugador1 = new System.Windows.Forms.Label();
            this.lbl_totalJugador1 = new System.Windows.Forms.Label();
            this.lbl_nombreJugador1 = new System.Windows.Forms.Label();
            this.lbl_totaldineroJugador1 = new System.Windows.Forms.Label();
            this.btn_apostar = new System.Windows.Forms.Button();
            this.txt_Apuestajugador2 = new System.Windows.Forms.TextBox();
            this.txt_apuestaJugador3 = new System.Windows.Forms.TextBox();
            this.lbl_totaldineroJugador2 = new System.Windows.Forms.Label();
            this.lbl_NombreJugador2 = new System.Windows.Forms.Label();
            this.lbl_totalJugador2 = new System.Windows.Forms.Label();
            this.lbl_NomJugador2 = new System.Windows.Forms.Label();
            this.lbl_apuestaJugador2 = new System.Windows.Forms.Label();
            this.lbl_totaldineroJugador3 = new System.Windows.Forms.Label();
            this.lbl_nombreJugador3 = new System.Windows.Forms.Label();
            this.lbl_totalJugador3 = new System.Windows.Forms.Label();
            this.lbl_NomJugador3 = new System.Windows.Forms.Label();
            this.lbl_apuestaJugador3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_nombreMonto = new System.Windows.Forms.Label();
            this.lbl_NombreTurno = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_p2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx_p1
            // 
            this.pbx_p1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_p1.InitialImage")));
            this.pbx_p1.Location = new System.Drawing.Point(74, 12);
            this.pbx_p1.Name = "pbx_p1";
            this.pbx_p1.Size = new System.Drawing.Size(156, 154);
            this.pbx_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_p1.TabIndex = 0;
            this.pbx_p1.TabStop = false;
            // 
            // pbx_p2
            // 
            this.pbx_p2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_p2.InitialImage")));
            this.pbx_p2.Location = new System.Drawing.Point(450, 12);
            this.pbx_p2.Name = "pbx_p2";
            this.pbx_p2.Size = new System.Drawing.Size(172, 154);
            this.pbx_p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_p2.TabIndex = 1;
            this.pbx_p2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tirar Dados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_resultado.Location = new System.Drawing.Point(337, 29);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(24, 25);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // txt_apuestaJugador1
            // 
            this.txt_apuestaJugador1.Location = new System.Drawing.Point(70, 53);
            this.txt_apuestaJugador1.Name = "txt_apuestaJugador1";
            this.txt_apuestaJugador1.Size = new System.Drawing.Size(100, 20);
            this.txt_apuestaJugador1.TabIndex = 5;
            this.txt_apuestaJugador1.Text = "0";
            // 
            // lbl_ApuestaJugador1
            // 
            this.lbl_ApuestaJugador1.AutoSize = true;
            this.lbl_ApuestaJugador1.Location = new System.Drawing.Point(18, 56);
            this.lbl_ApuestaJugador1.Name = "lbl_ApuestaJugador1";
            this.lbl_ApuestaJugador1.Size = new System.Drawing.Size(46, 13);
            this.lbl_ApuestaJugador1.TabIndex = 6;
            this.lbl_ApuestaJugador1.Text = "Apuesta";
            // 
            // lbl_NomJugador1
            // 
            this.lbl_NomJugador1.AutoSize = true;
            this.lbl_NomJugador1.Location = new System.Drawing.Point(68, 17);
            this.lbl_NomJugador1.Name = "lbl_NomJugador1";
            this.lbl_NomJugador1.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomJugador1.TabIndex = 7;
            this.lbl_NomJugador1.Text = "label2";
            // 
            // lbl_totalJugador1
            // 
            this.lbl_totalJugador1.AutoSize = true;
            this.lbl_totalJugador1.Location = new System.Drawing.Point(18, 80);
            this.lbl_totalJugador1.Name = "lbl_totalJugador1";
            this.lbl_totalJugador1.Size = new System.Drawing.Size(31, 13);
            this.lbl_totalJugador1.TabIndex = 8;
            this.lbl_totalJugador1.Text = "Total";
            // 
            // lbl_nombreJugador1
            // 
            this.lbl_nombreJugador1.AutoSize = true;
            this.lbl_nombreJugador1.Location = new System.Drawing.Point(18, 17);
            this.lbl_nombreJugador1.Name = "lbl_nombreJugador1";
            this.lbl_nombreJugador1.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreJugador1.TabIndex = 9;
            this.lbl_nombreJugador1.Text = "Nombre";
            // 
            // lbl_totaldineroJugador1
            // 
            this.lbl_totaldineroJugador1.AutoSize = true;
            this.lbl_totaldineroJugador1.Location = new System.Drawing.Point(68, 80);
            this.lbl_totaldineroJugador1.Name = "lbl_totaldineroJugador1";
            this.lbl_totaldineroJugador1.Size = new System.Drawing.Size(35, 13);
            this.lbl_totaldineroJugador1.TabIndex = 10;
            this.lbl_totaldineroJugador1.Text = "label2";
            // 
            // btn_apostar
            // 
            this.btn_apostar.Location = new System.Drawing.Point(295, 232);
            this.btn_apostar.Name = "btn_apostar";
            this.btn_apostar.Size = new System.Drawing.Size(111, 59);
            this.btn_apostar.TabIndex = 11;
            this.btn_apostar.Text = "Apostar";
            this.btn_apostar.UseVisualStyleBackColor = true;
            this.btn_apostar.Click += new System.EventHandler(this.btn_apostar_Click);
            // 
            // txt_Apuestajugador2
            // 
            this.txt_Apuestajugador2.Location = new System.Drawing.Point(246, 50);
            this.txt_Apuestajugador2.Name = "txt_Apuestajugador2";
            this.txt_Apuestajugador2.Size = new System.Drawing.Size(100, 20);
            this.txt_Apuestajugador2.TabIndex = 12;
            this.txt_Apuestajugador2.Text = "0";
            // 
            // txt_apuestaJugador3
            // 
            this.txt_apuestaJugador3.Location = new System.Drawing.Point(423, 47);
            this.txt_apuestaJugador3.Name = "txt_apuestaJugador3";
            this.txt_apuestaJugador3.Size = new System.Drawing.Size(100, 20);
            this.txt_apuestaJugador3.TabIndex = 13;
            this.txt_apuestaJugador3.Text = "0";
            // 
            // lbl_totaldineroJugador2
            // 
            this.lbl_totaldineroJugador2.AutoSize = true;
            this.lbl_totaldineroJugador2.Location = new System.Drawing.Point(244, 77);
            this.lbl_totaldineroJugador2.Name = "lbl_totaldineroJugador2";
            this.lbl_totaldineroJugador2.Size = new System.Drawing.Size(35, 13);
            this.lbl_totaldineroJugador2.TabIndex = 18;
            this.lbl_totaldineroJugador2.Text = "label2";
            // 
            // lbl_NombreJugador2
            // 
            this.lbl_NombreJugador2.AutoSize = true;
            this.lbl_NombreJugador2.Location = new System.Drawing.Point(194, 14);
            this.lbl_NombreJugador2.Name = "lbl_NombreJugador2";
            this.lbl_NombreJugador2.Size = new System.Drawing.Size(44, 13);
            this.lbl_NombreJugador2.TabIndex = 17;
            this.lbl_NombreJugador2.Text = "Nombre";
            // 
            // lbl_totalJugador2
            // 
            this.lbl_totalJugador2.AutoSize = true;
            this.lbl_totalJugador2.Location = new System.Drawing.Point(194, 77);
            this.lbl_totalJugador2.Name = "lbl_totalJugador2";
            this.lbl_totalJugador2.Size = new System.Drawing.Size(31, 13);
            this.lbl_totalJugador2.TabIndex = 16;
            this.lbl_totalJugador2.Text = "Total";
            // 
            // lbl_NomJugador2
            // 
            this.lbl_NomJugador2.AutoSize = true;
            this.lbl_NomJugador2.Location = new System.Drawing.Point(244, 14);
            this.lbl_NomJugador2.Name = "lbl_NomJugador2";
            this.lbl_NomJugador2.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomJugador2.TabIndex = 15;
            this.lbl_NomJugador2.Text = "label2";
            // 
            // lbl_apuestaJugador2
            // 
            this.lbl_apuestaJugador2.AutoSize = true;
            this.lbl_apuestaJugador2.Location = new System.Drawing.Point(194, 53);
            this.lbl_apuestaJugador2.Name = "lbl_apuestaJugador2";
            this.lbl_apuestaJugador2.Size = new System.Drawing.Size(46, 13);
            this.lbl_apuestaJugador2.TabIndex = 14;
            this.lbl_apuestaJugador2.Text = "Apuesta";
            // 
            // lbl_totaldineroJugador3
            // 
            this.lbl_totaldineroJugador3.AutoSize = true;
            this.lbl_totaldineroJugador3.Location = new System.Drawing.Point(420, 74);
            this.lbl_totaldineroJugador3.Name = "lbl_totaldineroJugador3";
            this.lbl_totaldineroJugador3.Size = new System.Drawing.Size(35, 13);
            this.lbl_totaldineroJugador3.TabIndex = 23;
            this.lbl_totaldineroJugador3.Text = "label2";
            // 
            // lbl_nombreJugador3
            // 
            this.lbl_nombreJugador3.AutoSize = true;
            this.lbl_nombreJugador3.Location = new System.Drawing.Point(370, 11);
            this.lbl_nombreJugador3.Name = "lbl_nombreJugador3";
            this.lbl_nombreJugador3.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreJugador3.TabIndex = 22;
            this.lbl_nombreJugador3.Text = "Nombre";
            // 
            // lbl_totalJugador3
            // 
            this.lbl_totalJugador3.AutoSize = true;
            this.lbl_totalJugador3.Location = new System.Drawing.Point(370, 74);
            this.lbl_totalJugador3.Name = "lbl_totalJugador3";
            this.lbl_totalJugador3.Size = new System.Drawing.Size(31, 13);
            this.lbl_totalJugador3.TabIndex = 21;
            this.lbl_totalJugador3.Text = "Total";
            // 
            // lbl_NomJugador3
            // 
            this.lbl_NomJugador3.AutoSize = true;
            this.lbl_NomJugador3.Location = new System.Drawing.Point(420, 11);
            this.lbl_NomJugador3.Name = "lbl_NomJugador3";
            this.lbl_NomJugador3.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomJugador3.TabIndex = 20;
            this.lbl_NomJugador3.Text = "label2";
            // 
            // lbl_apuestaJugador3
            // 
            this.lbl_apuestaJugador3.AutoSize = true;
            this.lbl_apuestaJugador3.Location = new System.Drawing.Point(370, 50);
            this.lbl_apuestaJugador3.Name = "lbl_apuestaJugador3";
            this.lbl_apuestaJugador3.Size = new System.Drawing.Size(46, 13);
            this.lbl_apuestaJugador3.TabIndex = 19;
            this.lbl_apuestaJugador3.Text = "Apuesta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_NomJugador1);
            this.panel1.Controls.Add(this.lbl_totaldineroJugador3);
            this.panel1.Controls.Add(this.txt_apuestaJugador1);
            this.panel1.Controls.Add(this.lbl_nombreJugador3);
            this.panel1.Controls.Add(this.lbl_ApuestaJugador1);
            this.panel1.Controls.Add(this.lbl_totalJugador3);
            this.panel1.Controls.Add(this.lbl_totalJugador1);
            this.panel1.Controls.Add(this.lbl_NomJugador3);
            this.panel1.Controls.Add(this.lbl_nombreJugador1);
            this.panel1.Controls.Add(this.lbl_apuestaJugador3);
            this.panel1.Controls.Add(this.lbl_totaldineroJugador1);
            this.panel1.Controls.Add(this.lbl_totaldineroJugador2);
            this.panel1.Controls.Add(this.txt_Apuestajugador2);
            this.panel1.Controls.Add(this.lbl_NombreJugador2);
            this.panel1.Controls.Add(this.txt_apuestaJugador3);
            this.panel1.Controls.Add(this.lbl_totalJugador2);
            this.panel1.Controls.Add(this.lbl_apuestaJugador2);
            this.panel1.Controls.Add(this.lbl_NomJugador2);
            this.panel1.Location = new System.Drawing.Point(74, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 125);
            this.panel1.TabIndex = 24;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(155, 255);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(13, 13);
            this.lbl_monto.TabIndex = 25;
            this.lbl_monto.Text = "0";
            // 
            // lbl_nombreMonto
            // 
            this.lbl_nombreMonto.AutoSize = true;
            this.lbl_nombreMonto.Location = new System.Drawing.Point(71, 255);
            this.lbl_nombreMonto.Name = "lbl_nombreMonto";
            this.lbl_nombreMonto.Size = new System.Drawing.Size(84, 13);
            this.lbl_nombreMonto.TabIndex = 26;
            this.lbl_nombreMonto.Text = "Monto apostado";
            // 
            // lbl_NombreTurno
            // 
            this.lbl_NombreTurno.AutoSize = true;
            this.lbl_NombreTurno.Location = new System.Drawing.Point(71, 231);
            this.lbl_NombreTurno.Name = "lbl_NombreTurno";
            this.lbl_NombreTurno.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreTurno.TabIndex = 27;
            this.lbl_NombreTurno.Text = "Turno";
            // 
            // lbl_turno
            // 
            this.lbl_turno.AutoSize = true;
            this.lbl_turno.Location = new System.Drawing.Point(155, 231);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(35, 13);
            this.lbl_turno.TabIndex = 28;
            this.lbl_turno.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 444);
            this.Controls.Add(this.lbl_turno);
            this.Controls.Add(this.lbl_NombreTurno);
            this.Controls.Add(this.lbl_nombreMonto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_apostar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbx_p2);
            this.Controls.Add(this.pbx_p1);
            this.Name = "Form1";
            this.Text = "Lucky 38";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_p2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_p1;
        private System.Windows.Forms.PictureBox pbx_p2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apuestaJugador1;
        private System.Windows.Forms.Label lbl_ApuestaJugador1;
        private System.Windows.Forms.Label lbl_NomJugador1;
        private System.Windows.Forms.Label lbl_totalJugador1;
        private System.Windows.Forms.Label lbl_nombreJugador1;
        private System.Windows.Forms.Label lbl_totaldineroJugador1;
        private System.Windows.Forms.Button btn_apostar;
        private System.Windows.Forms.TextBox txt_Apuestajugador2;
        private System.Windows.Forms.TextBox txt_apuestaJugador3;
        private System.Windows.Forms.Label lbl_totaldineroJugador2;
        private System.Windows.Forms.Label lbl_NombreJugador2;
        private System.Windows.Forms.Label lbl_totalJugador2;
        private System.Windows.Forms.Label lbl_NomJugador2;
        private System.Windows.Forms.Label lbl_apuestaJugador2;
        private System.Windows.Forms.Label lbl_totaldineroJugador3;
        private System.Windows.Forms.Label lbl_nombreJugador3;
        private System.Windows.Forms.Label lbl_totalJugador3;
        private System.Windows.Forms.Label lbl_NomJugador3;
        private System.Windows.Forms.Label lbl_apuestaJugador3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_nombreMonto;
        private System.Windows.Forms.Label lbl_NombreTurno;
        private System.Windows.Forms.Label lbl_turno;
    }
}

