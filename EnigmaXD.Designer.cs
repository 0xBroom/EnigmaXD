namespace EnigmaXD
{
    partial class EnigmaXD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRotorS = new System.Windows.Forms.Label();
            this.lblRotorM = new System.Windows.Forms.Label();
            this.lblRotorD = new System.Windows.Forms.Label();
            this.btnRotor1Down = new System.Windows.Forms.Button();
            this.btnRotor2Down = new System.Windows.Forms.Button();
            this.btnRotor1Up = new System.Windows.Forms.Button();
            this.btnRotor2Up = new System.Windows.Forms.Button();
            this.btnRotor3Down = new System.Windows.Forms.Button();
            this.btnRotor3Up = new System.Windows.Forms.Button();
            this.enc_decBtn = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblRotor1 = new System.Windows.Forms.Label();
            this.lblRotor2 = new System.Windows.Forms.Label();
            this.lblRotor3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRotorS
            // 
            this.lblRotorS.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorS.Location = new System.Drawing.Point(16, 16);
            this.lblRotorS.Name = "lblRotorS";
            this.lblRotorS.Size = new System.Drawing.Size(58, 24);
            this.lblRotorS.TabIndex = 20;
            this.lblRotorS.Text = "I";
            this.lblRotorS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotorM
            // 
            this.lblRotorM.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorM.Location = new System.Drawing.Point(111, 16);
            this.lblRotorM.Name = "lblRotorM";
            this.lblRotorM.Size = new System.Drawing.Size(32, 24);
            this.lblRotorM.TabIndex = 19;
            this.lblRotorM.Text = "II";
            this.lblRotorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotorD
            // 
            this.lblRotorD.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorD.Location = new System.Drawing.Point(193, 16);
            this.lblRotorD.Name = "lblRotorD";
            this.lblRotorD.Size = new System.Drawing.Size(32, 24);
            this.lblRotorD.TabIndex = 18;
            this.lblRotorD.Text = "III";
            this.lblRotorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRotor1Down
            // 
            this.btnRotor1Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor1Down.Location = new System.Drawing.Point(179, 171);
            this.btnRotor1Down.Name = "btnRotor1Down";
            this.btnRotor1Down.Size = new System.Drawing.Size(58, 53);
            this.btnRotor1Down.TabIndex = 17;
            this.btnRotor1Down.Text = "-";
            this.btnRotor1Down.Click += new System.EventHandler(this.BtnRotor1Down_Click);
            // 
            // btnRotor2Down
            // 
            this.btnRotor2Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor2Down.Location = new System.Drawing.Point(96, 171);
            this.btnRotor2Down.Name = "btnRotor2Down";
            this.btnRotor2Down.Size = new System.Drawing.Size(59, 53);
            this.btnRotor2Down.TabIndex = 16;
            this.btnRotor2Down.Text = "-";
            this.btnRotor2Down.Click += new System.EventHandler(this.BtnRotor2Down_Click);
            // 
            // btnRotor1Up
            // 
            this.btnRotor1Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor1Up.Location = new System.Drawing.Point(179, 40);
            this.btnRotor1Up.Name = "btnRotor1Up";
            this.btnRotor1Up.Size = new System.Drawing.Size(58, 56);
            this.btnRotor1Up.TabIndex = 15;
            this.btnRotor1Up.Text = "+";
            this.btnRotor1Up.Click += new System.EventHandler(this.BtnRotor1Up_Click);
            // 
            // btnRotor2Up
            // 
            this.btnRotor2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor2Up.Location = new System.Drawing.Point(96, 40);
            this.btnRotor2Up.Name = "btnRotor2Up";
            this.btnRotor2Up.Size = new System.Drawing.Size(59, 56);
            this.btnRotor2Up.TabIndex = 14;
            this.btnRotor2Up.Text = "+";
            this.btnRotor2Up.Click += new System.EventHandler(this.BtnRotor2Up_Click);
            // 
            // btnRotor3Down
            // 
            this.btnRotor3Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor3Down.Location = new System.Drawing.Point(16, 170);
            this.btnRotor3Down.Name = "btnRotor3Down";
            this.btnRotor3Down.Size = new System.Drawing.Size(58, 53);
            this.btnRotor3Down.TabIndex = 13;
            this.btnRotor3Down.Text = "-";
            this.btnRotor3Down.Click += new System.EventHandler(this.BtnRotor3Down_Click);
            // 
            // btnRotor3Up
            // 
            this.btnRotor3Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotor3Up.Location = new System.Drawing.Point(16, 40);
            this.btnRotor3Up.Name = "btnRotor3Up";
            this.btnRotor3Up.Size = new System.Drawing.Size(58, 56);
            this.btnRotor3Up.TabIndex = 12;
            this.btnRotor3Up.Text = "+";
            this.btnRotor3Up.Click += new System.EventHandler(this.BtnRotor3Up_Click);
            // 
            // enc_decBtn
            // 
            this.enc_decBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enc_decBtn.Location = new System.Drawing.Point(280, 108);
            this.enc_decBtn.Name = "enc_decBtn";
            this.enc_decBtn.Size = new System.Drawing.Size(164, 32);
            this.enc_decBtn.TabIndex = 20;
            this.enc_decBtn.Text = "Encriptar/Desencriptar";
            this.enc_decBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enc_decBtn.Click += new System.EventHandler(this.Enc_decBtn_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(91, 108);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(69, 32);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "Créditos";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(12, 148);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(432, 88);
            this.txtFinal.TabIndex = 17;
            // 
            // lblRotor1
            // 
            this.lblRotor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor1.Location = new System.Drawing.Point(179, 116);
            this.lblRotor1.Name = "lblRotor1";
            this.lblRotor1.Size = new System.Drawing.Size(58, 32);
            this.lblRotor1.TabIndex = 11;
            this.lblRotor1.Text = "A";
            this.lblRotor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotor2
            // 
            this.lblRotor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor2.Location = new System.Drawing.Point(96, 116);
            this.lblRotor2.Name = "lblRotor2";
            this.lblRotor2.Size = new System.Drawing.Size(59, 32);
            this.lblRotor2.TabIndex = 10;
            this.lblRotor2.Text = "A";
            this.lblRotor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotor3
            // 
            this.lblRotor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotor3.Location = new System.Drawing.Point(16, 116);
            this.lblRotor3.Name = "lblRotor3";
            this.lblRotor3.Size = new System.Drawing.Size(58, 32);
            this.lblRotor3.TabIndex = 9;
            this.lblRotor3.Text = "A";
            this.lblRotor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRotorS);
            this.groupBox1.Controls.Add(this.lblRotorM);
            this.groupBox1.Controls.Add(this.lblRotorD);
            this.groupBox1.Controls.Add(this.btnRotor1Down);
            this.groupBox1.Controls.Add(this.btnRotor2Down);
            this.groupBox1.Controls.Add(this.btnRotor1Up);
            this.groupBox1.Controls.Add(this.btnRotor2Up);
            this.groupBox1.Controls.Add(this.btnRotor3Down);
            this.groupBox1.Controls.Add(this.btnRotor3Up);
            this.groupBox1.Controls.Add(this.lblRotor1);
            this.groupBox1.Controls.Add(this.lblRotor2);
            this.groupBox1.Controls.Add(this.lblRotor3);
            this.groupBox1.Location = new System.Drawing.Point(452, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 232);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotors";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 108);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(73, 32);
            this.btnSettings.TabIndex = 19;
            this.btnSettings.Text = "Ajustes";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(12, 12);
            this.txtInit.Multiline = true;
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(432, 88);
            this.txtInit.TabIndex = 16;
            // 
            // EnigmaXD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 257);
            this.Controls.Add(this.enc_decBtn);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.txtInit);
            this.Name = "EnigmaXD";
            this.Text = "EnigmaXD";
            this.Load += new System.EventHandler(this.EnigmaXD_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRotorS;
        private System.Windows.Forms.Label lblRotorM;
        private System.Windows.Forms.Label lblRotorD;
        private System.Windows.Forms.Button btnRotor1Down;
        private System.Windows.Forms.Button btnRotor2Down;
        private System.Windows.Forms.Button btnRotor1Up;
        private System.Windows.Forms.Button btnRotor2Up;
        private System.Windows.Forms.Button btnRotor3Down;
        private System.Windows.Forms.Button btnRotor3Up;
        private System.Windows.Forms.Button enc_decBtn;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblRotor1;
        private System.Windows.Forms.Label lblRotor2;
        private System.Windows.Forms.Label lblRotor3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtInit;
    }
}

