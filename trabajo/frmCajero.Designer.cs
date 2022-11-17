namespace trabajo
{
    partial class frmCajero
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnProcesar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblMensajePin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "N° DE PIN";
            // 
            // txtPin
            // 
            this.txtPin.Depth = 0;
            this.txtPin.Hint = "";
            this.txtPin.Location = new System.Drawing.Point(30, 130);
            this.txtPin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '\0';
            this.txtPin.SelectedText = "";
            this.txtPin.SelectionLength = 0;
            this.txtPin.SelectionStart = 0;
            this.txtPin.Size = new System.Drawing.Size(161, 23);
            this.txtPin.TabIndex = 1;
            this.txtPin.UseSystemPasswordChar = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.AutoSize = true;
            this.btnProcesar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcesar.Depth = 0;
            this.btnProcesar.Location = new System.Drawing.Point(208, 117);
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
            // lblMensajePin
            // 
            this.lblMensajePin.AutoSize = true;
            this.lblMensajePin.Location = new System.Drawing.Point(30, 169);
            this.lblMensajePin.Name = "lblMensajePin";
            this.lblMensajePin.Size = new System.Drawing.Size(16, 15);
            this.lblMensajePin.TabIndex = 3;
            this.lblMensajePin.Text = "...";
            // 
            // frmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo.Properties.Resources.atm_machine_isolated_on_white_background_free_vector__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 250);
            this.Controls.Add(this.lblMensajePin);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCajero";
            this.Text = "BANCO";
            this.Load += new System.EventHandler(this.frmCajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPin;
        private MaterialSkin.Controls.MaterialFlatButton btnProcesar;
        private Label lblMensajePin;
    }
}