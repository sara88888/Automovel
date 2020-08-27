namespace Veiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btChave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.udCustokm = new System.Windows.Forms.NumericUpDown();
            this.udGastou = new System.Windows.Forms.NumericUpDown();
            this.udQuilometragem = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udContakm = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDeposito = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.udLtsaoscem = new System.Windows.Forms.NumericUpDown();
            this.udCapacidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.udAbastecer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udCustokm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udGastou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuilometragem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udContakm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLtsaoscem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAbastecer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(115, 58);
            this.tbMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.ReadOnly = true;
            this.tbMatricula.Size = new System.Drawing.Size(184, 26);
            this.tbMatricula.TabIndex = 1;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btChave);
            this.gb1.Controls.Add(this.label12);
            this.gb1.Controls.Add(this.label10);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.udCustokm);
            this.gb1.Controls.Add(this.udGastou);
            this.gb1.Controls.Add(this.udQuilometragem);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.udContakm);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Location = new System.Drawing.Point(33, 122);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb1.Size = new System.Drawing.Size(741, 301);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            // 
            // btChave
            // 
            this.btChave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btChave.Location = new System.Drawing.Point(33, 95);
            this.btChave.Name = "btChave";
            this.btChave.Size = new System.Drawing.Size(92, 90);
            this.btChave.TabIndex = 11;
            this.btChave.Text = "CHAVE";
            this.btChave.UseVisualStyleBackColor = false;
            this.btChave.Click += new System.EventHandler(this.btChave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "€";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Custo/Km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gastou";
            // 
            // udCustokm
            // 
            this.udCustokm.DecimalPlaces = 2;
            this.udCustokm.Location = new System.Drawing.Point(507, 206);
            this.udCustokm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.udCustokm.Name = "udCustokm";
            this.udCustokm.ReadOnly = true;
            this.udCustokm.Size = new System.Drawing.Size(106, 26);
            this.udCustokm.TabIndex = 5;
            // 
            // udGastou
            // 
            this.udGastou.DecimalPlaces = 2;
            this.udGastou.Location = new System.Drawing.Point(507, 72);
            this.udGastou.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.udGastou.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udGastou.Name = "udGastou";
            this.udGastou.ReadOnly = true;
            this.udGastou.Size = new System.Drawing.Size(106, 26);
            this.udGastou.TabIndex = 4;
            // 
            // udQuilometragem
            // 
            this.udQuilometragem.Location = new System.Drawing.Point(202, 206);
            this.udQuilometragem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udQuilometragem.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.udQuilometragem.Name = "udQuilometragem";
            this.udQuilometragem.ReadOnly = true;
            this.udQuilometragem.Size = new System.Drawing.Size(217, 26);
            this.udQuilometragem.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quilometragem total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udContakm
            // 
            this.udContakm.Location = new System.Drawing.Point(258, 72);
            this.udContakm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udContakm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udContakm.Name = "udContakm";
            this.udContakm.Size = new System.Drawing.Size(96, 26);
            this.udContakm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conta-quilómetros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDeposito
            // 
            this.pbDeposito.Location = new System.Drawing.Point(342, 489);
            this.pbDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDeposito.Name = "pbDeposito";
            this.pbDeposito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbDeposito.Size = new System.Drawing.Size(291, 35);
            this.pbDeposito.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depósito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udLtsaoscem
            // 
            this.udLtsaoscem.DecimalPlaces = 2;
            this.udLtsaoscem.Location = new System.Drawing.Point(504, 59);
            this.udLtsaoscem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.udLtsaoscem.Name = "udLtsaoscem";
            this.udLtsaoscem.ReadOnly = true;
            this.udLtsaoscem.Size = new System.Drawing.Size(90, 26);
            this.udLtsaoscem.TabIndex = 5;
            // 
            // udCapacidade
            // 
            this.udCapacidade.Location = new System.Drawing.Point(48, 491);
            this.udCapacidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.udCapacidade.Name = "udCapacidade";
            this.udCapacidade.ReadOnly = true;
            this.udCapacidade.Size = new System.Drawing.Size(90, 26);
            this.udCapacidade.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Litros aos cem";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Capacidade (lt)";
            // 
            // udAbastecer
            // 
            this.udAbastecer.Enabled = false;
            this.udAbastecer.Location = new System.Drawing.Point(207, 491);
            this.udAbastecer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.udAbastecer.Name = "udAbastecer";
            this.udAbastecer.Size = new System.Drawing.Size(88, 26);
            this.udAbastecer.TabIndex = 9;
            this.udAbastecer.ValueChanged += new System.EventHandler(this.udAbastecer_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Abastecer";
            // 
            // lblReserva
            // 
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(665, 489);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(38, 29);
            this.lblReserva.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(644, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Reserva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.udAbastecer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.udCapacidade);
            this.Controls.Add(this.udLtsaoscem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDeposito);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Veículo";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udCustokm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udGastou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuilometragem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udContakm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLtsaoscem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAbastecer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ProgressBar pbDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udQuilometragem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udContakm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udLtsaoscem;
        private System.Windows.Forms.NumericUpDown udCapacidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udAbastecer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown udCustokm;
        private System.Windows.Forms.NumericUpDown udGastou;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btChave;
    }
}

