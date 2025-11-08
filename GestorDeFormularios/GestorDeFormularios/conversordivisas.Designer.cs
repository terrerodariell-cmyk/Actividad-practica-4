namespace GestorDeFormularios
{
    partial class Conversordivisas
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
            txtmonto = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResultado = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label8 = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtmonto
            // 
            txtmonto.Font = new Font("Microsoft YaHei UI", 9F);
            txtmonto.Location = new Point(238, 117);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(159, 23);
            txtmonto.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            cmbOrigen.Font = new Font("Microsoft YaHei UI", 9F);
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "CNY", "DOP" });
            cmbOrigen.Location = new Point(129, 183);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(180, 25);
            cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            cmbDestino.Font = new Font("Microsoft YaHei UI", 9F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "CNY", "DOP" });
            cmbDestino.Location = new Point(347, 183);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(180, 25);
            cmbDestino.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.Red;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.ForeColor = SystemColors.ButtonHighlight;
            btnConvertir.Location = new Point(126, 241);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(134, 33);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(180, 22);
            label1.Name = "label1";
            label1.Size = new Size(265, 31);
            label1.TabIndex = 4;
            label1.Text = "Conversor de Divisas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(123, 326);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 5;
            label2.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial Black", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.DarkGreen;
            lblResultado.Location = new Point(240, 326);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 22);
            lblResultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(240, 81);
            label4.Name = "label4";
            label4.Size = new Size(157, 22);
            label4.TabIndex = 7;
            label4.Text = "Monto a convertir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(129, 158);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 8;
            label5.Text = "Moneda origen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(347, 158);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 9;
            label6.Text = "Moneda destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(99, 53);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(439, 21);
            label3.TabIndex = 11;
            label3.Text = "_______________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(99, 290);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(439, 21);
            label8.TabIndex = 13;
            label8.Text = "_______________________________________";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Green;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(347, 241);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 33);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Conversordivisas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(666, 399);
            Controls.Add(btnLimpiar);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtmonto);
            Name = "Conversordivisas";
            Text = "conversordivisas";
            Load += Conversordivisas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmonto;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label label1;
        private Label label2;
        private Label lblResultado;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label8;
        private Button btnLimpiar;
    }
}