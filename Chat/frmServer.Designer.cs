namespace Chat
{
    partial class frmServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbChatLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 257);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOnline.Location = new System.Drawing.Point(337, 67);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(71, 13);
            this.lblOnline.TabIndex = 6;
            this.lblOnline.Text = "Clients Online";
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(340, 83);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(115, 160);
            this.lstClients.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop Server";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbChatLog
            // 
            this.txbChatLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbChatLog.Location = new System.Drawing.Point(12, 21);
            this.txbChatLog.Multiline = true;
            this.txbChatLog.Name = "txbChatLog";
            this.txbChatLog.ReadOnly = true;
            this.txbChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbChatLog.Size = new System.Drawing.Size(289, 277);
            this.txbChatLog.TabIndex = 8;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 310);
            this.Controls.Add(this.txbChatLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.btnStart);
            this.Name = "frmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbChatLog;
    }
}

