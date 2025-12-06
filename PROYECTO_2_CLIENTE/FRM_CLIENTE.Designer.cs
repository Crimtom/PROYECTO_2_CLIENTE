namespace PROYECTO_2_CLIENTE
{
    partial class FRM_CLIENTE
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
            this.BT_ENVIAR = new System.Windows.Forms.Button();
            this.BT_DESCONECTAR = new System.Windows.Forms.Button();
            this.BT_CONECTAR = new System.Windows.Forms.Button();
            this.TXT_CLIENTE = new System.Windows.Forms.TextBox();
            this.TXT_INFO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_ENVIAR
            // 
            this.BT_ENVIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BT_ENVIAR.Location = new System.Drawing.Point(692, 423);
            this.BT_ENVIAR.Name = "BT_ENVIAR";
            this.BT_ENVIAR.Size = new System.Drawing.Size(125, 42);
            this.BT_ENVIAR.TabIndex = 0;
            this.BT_ENVIAR.Text = "Enviar";
            this.BT_ENVIAR.UseVisualStyleBackColor = true;
            // 
            // BT_DESCONECTAR
            // 
            this.BT_DESCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BT_DESCONECTAR.Location = new System.Drawing.Point(692, 12);
            this.BT_DESCONECTAR.Name = "BT_DESCONECTAR";
            this.BT_DESCONECTAR.Size = new System.Drawing.Size(125, 42);
            this.BT_DESCONECTAR.TabIndex = 1;
            this.BT_DESCONECTAR.Text = "Desconectar";
            this.BT_DESCONECTAR.UseVisualStyleBackColor = true;
            // 
            // BT_CONECTAR
            // 
            this.BT_CONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BT_CONECTAR.Location = new System.Drawing.Point(561, 12);
            this.BT_CONECTAR.Name = "BT_CONECTAR";
            this.BT_CONECTAR.Size = new System.Drawing.Size(125, 42);
            this.BT_CONECTAR.TabIndex = 2;
            this.BT_CONECTAR.Text = "Enviar";
            this.BT_CONECTAR.UseVisualStyleBackColor = true;
            // 
            // TXT_CLIENTE
            // 
            this.TXT_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TXT_CLIENTE.Location = new System.Drawing.Point(12, 23);
            this.TXT_CLIENTE.Name = "TXT_CLIENTE";
            this.TXT_CLIENTE.Size = new System.Drawing.Size(531, 31);
            this.TXT_CLIENTE.TabIndex = 3;
            // 
            // TXT_INFO
            // 
            this.TXT_INFO.Location = new System.Drawing.Point(12, 87);
            this.TXT_INFO.Multiline = true;
            this.TXT_INFO.Name = "TXT_INFO";
            this.TXT_INFO.Size = new System.Drawing.Size(805, 330);
            this.TXT_INFO.TabIndex = 4;
            // 
            // FRM_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 477);
            this.Controls.Add(this.TXT_INFO);
            this.Controls.Add(this.TXT_CLIENTE);
            this.Controls.Add(this.BT_CONECTAR);
            this.Controls.Add(this.BT_DESCONECTAR);
            this.Controls.Add(this.BT_ENVIAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_CLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_ENVIAR;
        private System.Windows.Forms.Button BT_DESCONECTAR;
        private System.Windows.Forms.Button BT_CONECTAR;
        private System.Windows.Forms.TextBox TXT_CLIENTE;
        private System.Windows.Forms.TextBox TXT_INFO;
    }
}