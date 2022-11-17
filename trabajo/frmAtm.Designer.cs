namespace trabajo
{
    partial class frmAtm
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
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewSaldo = new System.Windows.Forms.TextBox();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RetirarDosMil = new System.Windows.Forms.Button();
            this.RetirarMil = new System.Windows.Forms.Button();
            this.RetirarQuinientos = new System.Windows.Forms.Button();
            this.RetirarDoscientosCin = new System.Windows.Forms.Button();
            this.RetirarCien = new System.Windows.Forms.Button();
            this.btnTrescientos = new System.Windows.Forms.Button();
            this.RetirarDoscientos = new System.Windows.Forms.Button();
            this.RetirarCincuenta = new System.Windows.Forms.Button();
            this.lblMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEfectivo = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(153, 70);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(19, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "\"\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewSaldo);
            this.groupBox1.Controls.Add(this.materialFlatButton2);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SaldoOpciones";
            // 
            // txtNewSaldo
            // 
            this.txtNewSaldo.Location = new System.Drawing.Point(141, 107);
            this.txtNewSaldo.Name = "txtNewSaldo";
            this.txtNewSaldo.Size = new System.Drawing.Size(126, 23);
            this.txtNewSaldo.TabIndex = 3;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(7, 101);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(121, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "AGREGAR SALDO";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click_1);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(155, 42);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(19, 19);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "\"\"";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(22, 34);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "SALDO";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RetirarDosMil);
            this.groupBox2.Controls.Add(this.RetirarMil);
            this.groupBox2.Controls.Add(this.RetirarQuinientos);
            this.groupBox2.Controls.Add(this.RetirarDoscientosCin);
            this.groupBox2.Controls.Add(this.RetirarCien);
            this.groupBox2.Controls.Add(this.btnTrescientos);
            this.groupBox2.Controls.Add(this.RetirarDoscientos);
            this.groupBox2.Controls.Add(this.RetirarCincuenta);
            this.groupBox2.Location = new System.Drawing.Point(334, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // RetirarDosMil
            // 
            this.RetirarDosMil.Location = new System.Drawing.Point(137, 198);
            this.RetirarDosMil.Name = "RetirarDosMil";
            this.RetirarDosMil.Size = new System.Drawing.Size(94, 49);
            this.RetirarDosMil.TabIndex = 7;
            this.RetirarDosMil.Text = "2000";
            this.RetirarDosMil.UseVisualStyleBackColor = true;
            this.RetirarDosMil.Click += new System.EventHandler(this.RetirarDosMil_Click);
            // 
            // RetirarMil
            // 
            this.RetirarMil.Location = new System.Drawing.Point(6, 196);
            this.RetirarMil.Name = "RetirarMil";
            this.RetirarMil.Size = new System.Drawing.Size(94, 49);
            this.RetirarMil.TabIndex = 6;
            this.RetirarMil.Text = "1000";
            this.RetirarMil.UseVisualStyleBackColor = true;
            this.RetirarMil.Click += new System.EventHandler(this.RetirarMil_Click);
            // 
            // RetirarQuinientos
            // 
            this.RetirarQuinientos.Location = new System.Drawing.Point(137, 143);
            this.RetirarQuinientos.Name = "RetirarQuinientos";
            this.RetirarQuinientos.Size = new System.Drawing.Size(94, 49);
            this.RetirarQuinientos.TabIndex = 5;
            this.RetirarQuinientos.Text = "500";
            this.RetirarQuinientos.UseVisualStyleBackColor = true;
            this.RetirarQuinientos.Click += new System.EventHandler(this.RetirarQuinientos_Click);
            // 
            // RetirarDoscientosCin
            // 
            this.RetirarDoscientosCin.Location = new System.Drawing.Point(137, 92);
            this.RetirarDoscientosCin.Name = "RetirarDoscientosCin";
            this.RetirarDoscientosCin.Size = new System.Drawing.Size(94, 45);
            this.RetirarDoscientosCin.TabIndex = 4;
            this.RetirarDoscientosCin.Text = "250";
            this.RetirarDoscientosCin.UseVisualStyleBackColor = true;
            this.RetirarDoscientosCin.Click += new System.EventHandler(this.RetirarDoscientosCin_Click);
            // 
            // RetirarCien
            // 
            this.RetirarCien.Location = new System.Drawing.Point(137, 36);
            this.RetirarCien.Name = "RetirarCien";
            this.RetirarCien.Size = new System.Drawing.Size(94, 50);
            this.RetirarCien.TabIndex = 3;
            this.RetirarCien.Text = "100";
            this.RetirarCien.UseVisualStyleBackColor = true;
            this.RetirarCien.Click += new System.EventHandler(this.RetirarCien_Click);
            // 
            // btnTrescientos
            // 
            this.btnTrescientos.Location = new System.Drawing.Point(6, 141);
            this.btnTrescientos.Name = "btnTrescientos";
            this.btnTrescientos.Size = new System.Drawing.Size(94, 49);
            this.btnTrescientos.TabIndex = 2;
            this.btnTrescientos.Text = "300";
            this.btnTrescientos.UseVisualStyleBackColor = true;
            this.btnTrescientos.Click += new System.EventHandler(this.btnTrescientos_Click);
            // 
            // RetirarDoscientos
            // 
            this.RetirarDoscientos.Location = new System.Drawing.Point(6, 90);
            this.RetirarDoscientos.Name = "RetirarDoscientos";
            this.RetirarDoscientos.Size = new System.Drawing.Size(94, 45);
            this.RetirarDoscientos.TabIndex = 1;
            this.RetirarDoscientos.Text = "200";
            this.RetirarDoscientos.UseVisualStyleBackColor = true;
            this.RetirarDoscientos.Click += new System.EventHandler(this.RetirarDoscientos_Click);
            // 
            // RetirarCincuenta
            // 
            this.RetirarCincuenta.Location = new System.Drawing.Point(6, 34);
            this.RetirarCincuenta.Name = "RetirarCincuenta";
            this.RetirarCincuenta.Size = new System.Drawing.Size(94, 50);
            this.RetirarCincuenta.TabIndex = 0;
            this.RetirarCincuenta.Text = "50";
            this.RetirarCincuenta.UseVisualStyleBackColor = true;
            this.RetirarCincuenta.Click += new System.EventHandler(this.RetirarCincuenta_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Depth = 0;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(165, 441);
            this.lblMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(19, 19);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "\"\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEfectivo);
            this.groupBox3.Controls.Add(this.materialFlatButton3);
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OpcionesCajero";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Depth = 0;
            this.lblEfectivo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEfectivo.Location = new System.Drawing.Point(22, 75);
            this.lblEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(19, 19);
            this.lblEfectivo.TabIndex = 1;
            this.lblEfectivo.Text = "\"\"";
            this.lblEfectivo.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(14, 26);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(183, 36);
            this.materialFlatButton3.TabIndex = 0;
            this.materialFlatButton3.Text = "VER EFECTIVO DISPONIBLE";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 512);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAtm";
            this.Text = "BANCO";
            this.Load += new System.EventHandler(this.frmAtm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lblSaldo;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private GroupBox groupBox2;
        private Button RetirarDosMil;
        private Button RetirarMil;
        private Button RetirarQuinientos;
        private Button RetirarDoscientosCin;
        private Button RetirarCien;
        private Button btnTrescientos;
        private Button RetirarDoscientos;
        private Button RetirarCincuenta;
        private MaterialSkin.Controls.MaterialLabel lblMensaje;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel lblEfectivo;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private TextBox txtNewSaldo;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private Button btnSalir;
    }
}