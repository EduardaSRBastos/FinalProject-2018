namespace SB_Concept_Molds
{
    partial class MessageForm
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
            this.cbNaoMostrar = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNaoMostrar
            // 
            this.cbNaoMostrar.AutoSize = true;
            this.cbNaoMostrar.Font = new System.Drawing.Font("Corbel", 10F);
            this.cbNaoMostrar.Location = new System.Drawing.Point(12, 101);
            this.cbNaoMostrar.Name = "cbNaoMostrar";
            this.cbNaoMostrar.Size = new System.Drawing.Size(173, 21);
            this.cbNaoMostrar.TabIndex = 0;
            this.cbNaoMostrar.Text = "Não mostrar novamente.";
            this.cbNaoMostrar.UseVisualStyleBackColor = true;
            this.cbNaoMostrar.CheckedChanged += new System.EventHandler(this.cbNaoMostrar_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(153, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Texto.Location = new System.Drawing.Point(78, 35);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(308, 40);
            this.Texto.TabIndex = 2;
            this.Texto.Text = "Se não clicar no botão guardar, irá perder \r\ntodas as alterações que fez.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 185);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbNaoMostrar);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.Text = "                                                Mensagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbNaoMostrar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}