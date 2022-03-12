namespace SB_Concept_Molds
{
    partial class SBProjAtual
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBProjAtual));
            this.titulo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.img_mold = new System.Windows.Forms.PictureBox();
            this.sqr_nome = new System.Windows.Forms.PictureBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.lbl_tarefa = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbldataent = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.gbTarefas = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_mold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqr_nome)).BeginInit();
            this.gbTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titulo.Location = new System.Drawing.Point(41, 73);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(388, 75);
            this.titulo.TabIndex = 13;
            this.titulo.Text = "Projeto Atual";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_nome.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_nome.Location = new System.Drawing.Point(147, 344);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(132, 26);
            this.lbl_nome.TabIndex = 15;
            this.lbl_nome.Text = "Nome Projeto";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // img_mold
            // 
            this.img_mold.BackColor = System.Drawing.Color.MediumTurquoise;
            this.img_mold.Image = global::SB_Concept_Molds.Properties.Resources.lapis;
            this.img_mold.Location = new System.Drawing.Point(165, 231);
            this.img_mold.Name = "img_mold";
            this.img_mold.Size = new System.Drawing.Size(102, 110);
            this.img_mold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_mold.TabIndex = 16;
            this.img_mold.TabStop = false;
            // 
            // sqr_nome
            // 
            this.sqr_nome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.sqr_nome.Location = new System.Drawing.Point(142, 226);
            this.sqr_nome.Name = "sqr_nome";
            this.sqr_nome.Size = new System.Drawing.Size(147, 155);
            this.sqr_nome.TabIndex = 14;
            this.sqr_nome.TabStop = false;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_data.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_data.Location = new System.Drawing.Point(491, 165);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(175, 34);
            this.lbl_data.TabIndex = 17;
            this.lbl_data.Text = "Data Entrega";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_cliente.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_cliente.Location = new System.Drawing.Point(136, 441);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(101, 34);
            this.lbl_cliente.TabIndex = 19;
            this.lbl_cliente.Text = "Cliente";
            this.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nome.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_nome.Location = new System.Drawing.Point(138, 477);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(72, 26);
            this.txt_nome.TabIndex = 20;
            this.txt_nome.Text = "Camilo";
            this.txt_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tarefa
            // 
            this.lbl_tarefa.AutoSize = true;
            this.lbl_tarefa.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tarefa.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarefa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_tarefa.Location = new System.Drawing.Point(804, 168);
            this.lbl_tarefa.Name = "lbl_tarefa";
            this.lbl_tarefa.Size = new System.Drawing.Size(105, 34);
            this.lbl_tarefa.TabIndex = 21;
            this.lbl_tarefa.Text = "Tarefas";
            this.lbl_tarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.monthCalendar1.Font = new System.Drawing.Font("Corbel", 1F);
            this.monthCalendar1.ForeColor = System.Drawing.Color.Maroon;
            this.monthCalendar1.Location = new System.Drawing.Point(461, 226);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(300, 300);
            this.monthCalendar1.MinimumSize = new System.Drawing.Size(220, 150);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Red;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Magenta;
            this.monthCalendar1.MouseHover += new System.EventHandler(this.monthCalendar1_MouseHover);
            // 
            // lbldataent
            // 
            this.lbldataent.AutoSize = true;
            this.lbldataent.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataent.Location = new System.Drawing.Point(481, 395);
            this.lbldataent.Name = "lbldataent";
            this.lbldataent.Size = new System.Drawing.Size(42, 19);
            this.lbldataent.TabIndex = 24;
            this.lbldataent.Text = "Data";
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.Location = new System.Drawing.Point(481, 427);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(32, 19);
            this.lbldias.TabIndex = 25;
            this.lbldias.Text = "Dia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(810, 477);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 23);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Análise de peça e relatório";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 23);
            this.checkBox2.TabIndex = 53;
            this.checkBox2.Text = "Orçamento do projeto";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(6, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(314, 23);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.Text = "Orçamento do projeto com o planeamento";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // gbTarefas
            // 
            this.gbTarefas.Controls.Add(this.checkBox6);
            this.gbTarefas.Controls.Add(this.checkBox11);
            this.gbTarefas.Controls.Add(this.checkBox10);
            this.gbTarefas.Controls.Add(this.checkBox9);
            this.gbTarefas.Controls.Add(this.checkBox8);
            this.gbTarefas.Controls.Add(this.checkBox4);
            this.gbTarefas.Controls.Add(this.checkBox7);
            this.gbTarefas.Controls.Add(this.checkBox5);
            this.gbTarefas.Controls.Add(this.checkBox1);
            this.gbTarefas.Controls.Add(this.checkBox2);
            this.gbTarefas.Controls.Add(this.checkBox3);
            this.gbTarefas.Location = new System.Drawing.Point(778, 188);
            this.gbTarefas.Name = "gbTarefas";
            this.gbTarefas.Size = new System.Drawing.Size(413, 283);
            this.gbTarefas.TabIndex = 63;
            this.gbTarefas.TabStop = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(6, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(351, 23);
            this.checkBox6.TabIndex = 65;
            this.checkBox6.Text = "Modelação de mecanismos e definição estrutural";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(6, 255);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(223, 23);
            this.checkBox11.TabIndex = 70;
            this.checkBox11.Text = "Execução de desenho 2d final";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(6, 232);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(305, 23);
            this.checkBox10.TabIndex = 69;
            this.checkBox10.Text = "Execução de detalhes e listas de materiais";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(6, 206);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(273, 23);
            this.checkBox9.TabIndex = 68;
            this.checkBox9.Text = "Assemblagem de acessórios externos";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(6, 182);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(207, 23);
            this.checkBox8.TabIndex = 67;
            this.checkBox8.Text = "Modelação de refrigeração";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(6, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(316, 23);
            this.checkBox4.TabIndex = 63;
            this.checkBox4.Text = "Preliminar 2D com conceito de mecanismos";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(6, 158);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(248, 23);
            this.checkBox7.TabIndex = 66;
            this.checkBox7.Text = "Modelação de sistema de injeção";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(6, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(399, 23);
            this.checkBox5.TabIndex = 64;
            this.checkBox5.Text = "Modelação inicial com linha de junta e definição de aços";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // SBProjAtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 677);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.lbldataent);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_tarefa);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.img_mold);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.sqr_nome);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.gbTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SBProjAtual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SB ProjAtual";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SBProjAtual_Load);
            this.MouseLeave += new System.EventHandler(this.SBProjAtual_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.img_mold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqr_nome)).EndInit();
            this.gbTarefas.ResumeLayout(false);
            this.gbTarefas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox sqr_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.PictureBox img_mold;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label lbl_tarefa;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbldataent;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox gbTarefas;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

