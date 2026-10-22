namespace trabajopractico
{
    partial class frminscripcion
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
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            rbtEfectivo = new RadioButton();
            rBtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbledad = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(136, 78);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 1;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(139, 112);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(15, 14);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboPlan.Location = new Point(136, 152);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 3;
            // 
            // cboTurno
            // 
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "mañana", "tarde", "noche" });
            cboTurno.Location = new Point(136, 185);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 4;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(136, 220);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 5;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(139, 264);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(15, 14);
            chkCasillero.TabIndex = 6;
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(12, 327);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(76, 19);
            rbtEfectivo.TabIndex = 7;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "EFECTIVO";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdtTarjeta
            // 
            rBtTarjeta.AutoSize = true;
            rBtTarjeta.Location = new Point(112, 327);
            rBtTarjeta.Name = "rBtTarjeta";
            rBtTarjeta.Size = new Size(68, 19);
            rBtTarjeta.TabIndex = 8;
            rBtTarjeta.TabStop = true;
            rBtTarjeta.Text = "TARJETA";
            rBtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(70, 362);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(40, 23);
            cboCuotas.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(88, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnlimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(182, 415);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 111);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 13;
            label2.Text = "ESTUDIANTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 81);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 155);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 15;
            label4.Text = "PLAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 188);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 16;
            label5.Text = "TURNO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 223);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 17;
            label6.Text = "CANTIDAD DE MESES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 9);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 18;
            label7.Text = "Datos Personales";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-1, 263);
            label8.Name = "label8";
            label8.Size = new Size(134, 15);
            label8.TabIndex = 19;
            label8.Text = "CASILLERO ($3000/mes)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 300);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 20;
            label9.Text = "FORMAS DE PAGO:";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(73, 81);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(37, 15);
            lbledad.TabIndex = 21;
            lbledad.Text = "EDAD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 365);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 22;
            label11.Text = "CUOTAS:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Emblema_GYM_SIGLO_en_azul;
            pictureBox1.Location = new Point(246, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frminscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 445);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(lbledad);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(cboCuotas);
            Controls.Add(rBtTarjeta);
            Controls.Add(rbtEfectivo);
            Controls.Add(chkCasillero);
            Controls.Add(txtMeses);
            Controls.Add(cboTurno);
            Controls.Add(cboPlan);
            Controls.Add(chkEstudiante);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Name = "frminscripcion";
            Text = "Form1";
            Load += frminscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private RadioButton rbtEfectivo;
        private RadioButton rBtTarjeta;
        private ComboBox cboCuotas;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbledad;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
