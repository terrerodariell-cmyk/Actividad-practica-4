namespace GestorDeFormularios
{
    partial class FrmRegistropersonas
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
            txtNombre = new TextBox();
            label1 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cmbSexo = new ComboBox();
            btnAgregar = new Button();
            dgvPersonas = new DataGridView();
            btnLimpiar = new Button();
            cmbEstadoCivil = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtNacionalidad = new TextBox();
            label7 = new Label();
            txtOcupación = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label9 = new Label();
            txtTeléfono = new TextBox();
            label10 = new Label();
            txtDirección = new TextBox();
            label11 = new Label();
            txtNivelEducativo = new TextBox();
            label12 = new Label();
            txtCédula = new TextBox();
            label13 = new Label();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNombre.Location = new Point(320, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 25);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI Symbol", 9.75F);
            dtpFechaNacimiento.Location = new Point(139, 123);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(227, 25);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(296, 67);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 25);
            cmbSexo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.RoyalBlue;
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(288, 380);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(24, 432);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(1298, 190);
            dgvPersonas.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gold;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(500, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(141, 35);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado" });
            cmbEstadoCivil.Location = new Point(520, 67);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(100, 25);
            cmbEstadoCivil.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 67);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = " Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(434, 72);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 10;
            label3.Text = "Estado Civil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(28, 72);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Symbol", 9.75F);
            txtApellido.Location = new Point(96, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(126, 25);
            txtApellido.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(423, 34);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 17;
            label6.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNacionalidad.Location = new Point(520, 29);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(100, 25);
            txtNacionalidad.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(3, 77);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 15;
            label7.Text = "Ocupación";
            // 
            // txtOcupación
            // 
            txtOcupación.Font = new Font("Segoe UI Symbol", 9.75F);
            txtOcupación.Location = new Point(76, 67);
            txtOcupación.Name = "txtOcupación";
            txtOcupación.Size = new Size(133, 25);
            txtOcupación.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(14, 34);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 21;
            label8.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCorreo.Location = new Point(76, 29);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 25);
            txtCorreo.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(224, 35);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 19;
            label9.Text = "Teléfono";
            // 
            // txtTeléfono
            // 
            txtTeléfono.Font = new Font("Segoe UI Symbol", 9.75F);
            txtTeléfono.Location = new Point(305, 29);
            txtTeléfono.Name = "txtTeléfono";
            txtTeléfono.Size = new Size(112, 25);
            txtTeléfono.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(28, 138);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 27;
            label10.Text = "Dirección";
            // 
            // txtDirección
            // 
            txtDirección.Font = new Font("Segoe UI Symbol", 9.75F);
            txtDirección.Location = new Point(96, 133);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(126, 25);
            txtDirección.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(385, 131);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 25;
            label11.Text = "Nivel Educativo";
            // 
            // txtNivelEducativo
            // 
            txtNivelEducativo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNivelEducativo.Location = new Point(481, 123);
            txtNivelEducativo.Name = "txtNivelEducativo";
            txtNivelEducativo.Size = new Size(100, 25);
            txtNivelEducativo.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(31, 104);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 23;
            label12.Text = "Cédula";
            // 
            // txtCédula
            // 
            txtCédula.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCédula.Location = new Point(96, 104);
            txtCédula.Name = "txtCédula";
            txtCédula.Size = new Size(126, 25);
            txtCédula.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MidnightBlue;
            label13.Location = new Point(583, 82);
            label13.Name = "label13";
            label13.Size = new Size(223, 31);
            label13.TabIndex = 28;
            label13.Text = "Ingrese los datos";
            label13.Click += label13_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(888, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 35);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Gray;
            btnOrdenar.BackgroundImageLayout = ImageLayout.Center;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = SystemColors.ControlLightLight;
            btnOrdenar.Location = new Point(695, 380);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(141, 35);
            btnOrdenar.TabIndex = 32;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtOcupación);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNivelEducativo);
            panel1.Controls.Add(cmbEstadoCivil);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNacionalidad);
            panel1.Controls.Add(cmbSexo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTeléfono);
            panel1.Location = new Point(517, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 200);
            panel1.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtDirección);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtCédula);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(224, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 200);
            panel2.TabIndex = 34;
            // 
            // FrmRegistropersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1354, 705);
            Controls.Add(btnOrdenar);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminar);
            Controls.Add(label13);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPersonas);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.MidnightBlue;
            Name = "FrmRegistropersonas";
            Text = "Registro de personas";
            Load += FrmRegistropersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbSexo;
        private Button btnAgregar;
        private DataGridView dgvPersonas;
        private Button btnLimpiar;
        private ComboBox cmbEstadoCivil;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private Label label6;
        private TextBox txtNacionalidad;
        private Label label7;
        private TextBox txtOcupación;
        private Label label8;
        private TextBox txtCorreo;
        private Label label9;
        private TextBox txtTeléfono;
        private Label label10;
        private TextBox txtDirección;
        private Label label11;
        private TextBox txtNivelEducativo;
        private Label label12;
        private TextBox txtCédula;
        private Label label13;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Panel panel1;
        private Panel panel2;
    }
}