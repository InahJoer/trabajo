namespace trabajo
{
    partial class BANCO
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnProcesar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(250, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "INGRESE SU NÚMERO DE TARJETA";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(40, 138);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(241, 23);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.AutoSize = true;
            this.btnProcesar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesar.Depth = 0;
            this.btnProcesar.Location = new System.Drawing.Point(304, 125);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcesar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Primary = false;
            this.btnProcesar.Size = new System.Drawing.Size(81, 36);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(40, 176);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 15);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "...";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // BANCO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.materialLabel1);
            this.Name = "BANCO";
            this.Text = "BANCO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialFlatButton btnProcesar;
        private Label lblMensaje;
    }
}