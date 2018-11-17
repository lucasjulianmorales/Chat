namespace Cliente_Chat
{
    partial class frmCliente
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbChat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.indicator = new System.Windows.Forms.Panel();
            this.txbNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(465, 204);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(465, 249);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(12, 249);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(434, 20);
            this.txbInput.TabIndex = 9;
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(12, 39);
            this.txbChat.Multiline = true;
            this.txbChat.Name = "txbChat";
            this.txbChat.ReadOnly = true;
            this.txbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbChat.Size = new System.Drawing.Size(434, 174);
            this.txbChat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Friends";
            // 
            // lstFriends
            // 
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(465, 81);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(113, 108);
            this.lstFriends.TabIndex = 11;
            // 
            // indicator
            // 
            this.indicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator.Location = new System.Drawing.Point(12, 22);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 11);
            this.indicator.TabIndex = 14;
            // 
            // txbNick
            // 
            this.txbNick.Location = new System.Drawing.Point(465, 39);
            this.txbNick.Name = "txbNick";
            this.txbNick.Size = new System.Drawing.Size(113, 20);
            this.txbNick.TabIndex = 15;
            this.txbNick.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nick";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNick);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.txbChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFriends);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.TextBox txbChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.TextBox txbNick;
        private System.Windows.Forms.Label label2;
    }
}

