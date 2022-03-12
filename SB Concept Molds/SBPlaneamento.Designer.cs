namespace SB_Concept_Molds
{
    partial class SBPlaneamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBPlaneamento));
            this.titulo = new System.Windows.Forms.Label();
            this.cb_mold = new System.Windows.Forms.ComboBox();
            this.lbl_analise = new System.Windows.Forms.Label();
            this.lbl_preliminar = new System.Windows.Forms.Label();
            this.lbl_aprovprel = new System.Windows.Forms.Label();
            this.lbl_analisefinal = new System.Windows.Forms.Label();
            this.lbl_3d = new System.Windows.Forms.Label();
            this.lbl_aprov = new System.Windows.Forms.Label();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_prev = new System.Windows.Forms.Label();
            this.lbl_hrs = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.hr_lista = new System.Windows.Forms.NumericUpDown();
            this.hr_aprovacao = new System.Windows.Forms.NumericUpDown();
            this.hr_3d = new System.Windows.Forms.NumericUpDown();
            this.hr_analisefinal = new System.Windows.Forms.NumericUpDown();
            this.hr_aprovacaoprel = new System.Windows.Forms.NumericUpDown();
            this.hr_preliminar = new System.Windows.Forms.NumericUpDown();
            this.hr_analise = new System.Windows.Forms.NumericUpDown();
            this.prev_analisefinal = new System.Windows.Forms.NumericUpDown();
            this.prev_aprovacaoprel = new System.Windows.Forms.NumericUpDown();
            this.time_analise = new System.Windows.Forms.DateTimePicker();
            this.time_preliminar = new System.Windows.Forms.DateTimePicker();
            this.time_aprovacaoprel = new System.Windows.Forms.DateTimePicker();
            this.time_analisefinal = new System.Windows.Forms.DateTimePicker();
            this.time_3d = new System.Windows.Forms.DateTimePicker();
            this.time_aprovacao = new System.Windows.Forms.DateTimePicker();
            this.time_lista = new System.Windows.Forms.DateTimePicker();
            this.prev_analise = new System.Windows.Forms.NumericUpDown();
            this.prev_preliminar = new System.Windows.Forms.NumericUpDown();
            this.prev_3d = new System.Windows.Forms.NumericUpDown();
            this.prev_aprovacao = new System.Windows.Forms.NumericUpDown();
            this.prev_lista = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hr_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_aprovacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_3d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_analisefinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_aprovacaoprel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_preliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_analise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_analisefinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_aprovacaoprel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_analise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_preliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_3d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_aprovacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titulo.Location = new System.Drawing.Point(41, 73);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(389, 75);
            this.titulo.TabIndex = 14;
            this.titulo.Text = "Planeamento";
            // 
            // cb_mold
            // 
            this.cb_mold.BackColor = System.Drawing.SystemColors.Control;
            this.cb_mold.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_mold.Font = new System.Drawing.Font("Corbel", 14F);
            this.cb_mold.FormattingEnabled = true;
            this.cb_mold.Location = new System.Drawing.Point(5, 5);
            this.cb_mold.Name = "cb_mold";
            this.cb_mold.Size = new System.Drawing.Size(183, 31);
            this.cb_mold.TabIndex = 15;
            this.cb_mold.SelectedIndexChanged += new System.EventHandler(this.cb_mold_SelectedIndexChanged);
            // 
            // lbl_analise
            // 
            this.lbl_analise.AutoSize = true;
            this.lbl_analise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_analise.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_analise.Location = new System.Drawing.Point(5, 48);
            this.lbl_analise.Name = "lbl_analise";
            this.lbl_analise.Size = new System.Drawing.Size(183, 27);
            this.lbl_analise.TabIndex = 16;
            this.lbl_analise.Text = "Análise de Ficheiro";
            // 
            // lbl_preliminar
            // 
            this.lbl_preliminar.AutoSize = true;
            this.lbl_preliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_preliminar.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_preliminar.Location = new System.Drawing.Point(5, 94);
            this.lbl_preliminar.Name = "lbl_preliminar";
            this.lbl_preliminar.Size = new System.Drawing.Size(106, 27);
            this.lbl_preliminar.TabIndex = 17;
            this.lbl_preliminar.Text = "Preliminar";
            // 
            // lbl_aprovprel
            // 
            this.lbl_aprovprel.AutoSize = true;
            this.lbl_aprovprel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aprovprel.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_aprovprel.Location = new System.Drawing.Point(5, 140);
            this.lbl_aprovprel.Name = "lbl_aprovprel";
            this.lbl_aprovprel.Size = new System.Drawing.Size(362, 27);
            this.lbl_aprovprel.TabIndex = 18;
            this.lbl_aprovprel.Text = "Aprovação de Preliminar e Atualização";
            // 
            // lbl_analisefinal
            // 
            this.lbl_analisefinal.AutoSize = true;
            this.lbl_analisefinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_analisefinal.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_analisefinal.Location = new System.Drawing.Point(5, 186);
            this.lbl_analisefinal.Name = "lbl_analisefinal";
            this.lbl_analisefinal.Size = new System.Drawing.Size(204, 27);
            this.lbl_analisefinal.TabIndex = 19;
            this.lbl_analisefinal.Text = "Análise Ficheiro Final";
            // 
            // lbl_3d
            // 
            this.lbl_3d.AutoSize = true;
            this.lbl_3d.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3d.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_3d.Location = new System.Drawing.Point(5, 232);
            this.lbl_3d.Name = "lbl_3d";
            this.lbl_3d.Size = new System.Drawing.Size(99, 27);
            this.lbl_3d.TabIndex = 20;
            this.lbl_3d.Text = "3D Molde";
            // 
            // lbl_aprov
            // 
            this.lbl_aprov.AutoSize = true;
            this.lbl_aprov.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aprov.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_aprov.Location = new System.Drawing.Point(5, 278);
            this.lbl_aprov.Name = "lbl_aprov";
            this.lbl_aprov.Size = new System.Drawing.Size(237, 27);
            this.lbl_aprov.TabIndex = 21;
            this.lbl_aprov.Text = "Aprovação e Atualização";
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lista.Font = new System.Drawing.Font("Corbel", 16F);
            this.lbl_lista.Location = new System.Drawing.Point(5, 324);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(269, 27);
            this.lbl_lista.TabIndex = 22;
            this.lbl_lista.Text = "Listas de Materiais/Detalhes";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inicio.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.Location = new System.Drawing.Point(384, 2);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(128, 26);
            this.lbl_inicio.TabIndex = 23;
            this.lbl_inicio.Text = "Data de Início";
            // 
            // lbl_prev
            // 
            this.lbl_prev.AutoSize = true;
            this.lbl_prev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prev.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prev.Location = new System.Drawing.Point(681, 2);
            this.lbl_prev.Name = "lbl_prev";
            this.lbl_prev.Size = new System.Drawing.Size(194, 26);
            this.lbl_prev.TabIndex = 24;
            this.lbl_prev.Text = "Nr de Horas Previstas";
            // 
            // lbl_hrs
            // 
            this.lbl_hrs.AutoSize = true;
            this.lbl_hrs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hrs.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hrs.Location = new System.Drawing.Point(912, 2);
            this.lbl_hrs.Name = "lbl_hrs";
            this.lbl_hrs.Size = new System.Drawing.Size(113, 26);
            this.lbl_hrs.TabIndex = 25;
            this.lbl_hrs.Text = "Nr de Horas";
            // 
            // tabela
            // 
            this.tabela.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tabela.ColumnCount = 4;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.07155F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.91623F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08969F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71749F));
            this.tabela.Controls.Add(this.hr_lista, 3, 7);
            this.tabela.Controls.Add(this.hr_aprovacao, 3, 6);
            this.tabela.Controls.Add(this.hr_3d, 3, 5);
            this.tabela.Controls.Add(this.hr_analisefinal, 3, 4);
            this.tabela.Controls.Add(this.hr_aprovacaoprel, 3, 3);
            this.tabela.Controls.Add(this.hr_preliminar, 3, 2);
            this.tabela.Controls.Add(this.hr_analise, 3, 1);
            this.tabela.Controls.Add(this.prev_analisefinal, 2, 4);
            this.tabela.Controls.Add(this.prev_aprovacaoprel, 2, 3);
            this.tabela.Controls.Add(this.cb_mold, 0, 0);
            this.tabela.Controls.Add(this.lbl_lista, 0, 7);
            this.tabela.Controls.Add(this.lbl_hrs, 3, 0);
            this.tabela.Controls.Add(this.lbl_aprov, 0, 6);
            this.tabela.Controls.Add(this.lbl_inicio, 1, 0);
            this.tabela.Controls.Add(this.lbl_3d, 0, 5);
            this.tabela.Controls.Add(this.lbl_prev, 2, 0);
            this.tabela.Controls.Add(this.lbl_analisefinal, 0, 4);
            this.tabela.Controls.Add(this.lbl_aprovprel, 0, 3);
            this.tabela.Controls.Add(this.lbl_preliminar, 0, 2);
            this.tabela.Controls.Add(this.lbl_analise, 0, 1);
            this.tabela.Controls.Add(this.time_analise, 1, 1);
            this.tabela.Controls.Add(this.time_preliminar, 1, 2);
            this.tabela.Controls.Add(this.time_aprovacaoprel, 1, 3);
            this.tabela.Controls.Add(this.time_analisefinal, 1, 4);
            this.tabela.Controls.Add(this.time_3d, 1, 5);
            this.tabela.Controls.Add(this.time_aprovacao, 1, 6);
            this.tabela.Controls.Add(this.time_lista, 1, 7);
            this.tabela.Controls.Add(this.prev_analise, 2, 1);
            this.tabela.Controls.Add(this.prev_preliminar, 2, 2);
            this.tabela.Controls.Add(this.prev_3d, 2, 5);
            this.tabela.Controls.Add(this.prev_aprovacao, 2, 6);
            this.tabela.Controls.Add(this.prev_lista, 2, 7);
            this.tabela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabela.Location = new System.Drawing.Point(62, 182);
            this.tabela.Name = "tabela";
            this.tabela.RowCount = 8;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tabela.Size = new System.Drawing.Size(1148, 372);
            this.tabela.TabIndex = 26;
            // 
            // hr_lista
            // 
            this.hr_lista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_lista.Location = new System.Drawing.Point(912, 327);
            this.hr_lista.Name = "hr_lista";
            this.hr_lista.Size = new System.Drawing.Size(120, 22);
            this.hr_lista.TabIndex = 47;
            // 
            // hr_aprovacao
            // 
            this.hr_aprovacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_aprovacao.Location = new System.Drawing.Point(912, 281);
            this.hr_aprovacao.Name = "hr_aprovacao";
            this.hr_aprovacao.Size = new System.Drawing.Size(120, 22);
            this.hr_aprovacao.TabIndex = 46;
            // 
            // hr_3d
            // 
            this.hr_3d.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_3d.Location = new System.Drawing.Point(912, 235);
            this.hr_3d.Name = "hr_3d";
            this.hr_3d.Size = new System.Drawing.Size(120, 22);
            this.hr_3d.TabIndex = 45;
            // 
            // hr_analisefinal
            // 
            this.hr_analisefinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_analisefinal.Location = new System.Drawing.Point(912, 189);
            this.hr_analisefinal.Name = "hr_analisefinal";
            this.hr_analisefinal.Size = new System.Drawing.Size(120, 22);
            this.hr_analisefinal.TabIndex = 44;
            // 
            // hr_aprovacaoprel
            // 
            this.hr_aprovacaoprel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_aprovacaoprel.Location = new System.Drawing.Point(912, 143);
            this.hr_aprovacaoprel.Name = "hr_aprovacaoprel";
            this.hr_aprovacaoprel.Size = new System.Drawing.Size(120, 22);
            this.hr_aprovacaoprel.TabIndex = 43;
            // 
            // hr_preliminar
            // 
            this.hr_preliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_preliminar.Location = new System.Drawing.Point(912, 97);
            this.hr_preliminar.Name = "hr_preliminar";
            this.hr_preliminar.Size = new System.Drawing.Size(120, 22);
            this.hr_preliminar.TabIndex = 42;
            // 
            // hr_analise
            // 
            this.hr_analise.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_analise.Location = new System.Drawing.Point(912, 51);
            this.hr_analise.Name = "hr_analise";
            this.hr_analise.Size = new System.Drawing.Size(120, 22);
            this.hr_analise.TabIndex = 41;
            // 
            // prev_analisefinal
            // 
            this.prev_analisefinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_analisefinal.Location = new System.Drawing.Point(681, 189);
            this.prev_analisefinal.Name = "prev_analisefinal";
            this.prev_analisefinal.Size = new System.Drawing.Size(120, 22);
            this.prev_analisefinal.TabIndex = 39;
            // 
            // prev_aprovacaoprel
            // 
            this.prev_aprovacaoprel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_aprovacaoprel.Location = new System.Drawing.Point(681, 143);
            this.prev_aprovacaoprel.Name = "prev_aprovacaoprel";
            this.prev_aprovacaoprel.Size = new System.Drawing.Size(120, 22);
            this.prev_aprovacaoprel.TabIndex = 37;
            // 
            // time_analise
            // 
            this.time_analise.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_analise.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_analise.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_analise.Location = new System.Drawing.Point(384, 51);
            this.time_analise.Name = "time_analise";
            this.time_analise.Size = new System.Drawing.Size(200, 22);
            this.time_analise.TabIndex = 26;
            // 
            // time_preliminar
            // 
            this.time_preliminar.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_preliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_preliminar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_preliminar.Location = new System.Drawing.Point(384, 97);
            this.time_preliminar.Name = "time_preliminar";
            this.time_preliminar.Size = new System.Drawing.Size(200, 22);
            this.time_preliminar.TabIndex = 27;
            // 
            // time_aprovacaoprel
            // 
            this.time_aprovacaoprel.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_aprovacaoprel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_aprovacaoprel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_aprovacaoprel.Location = new System.Drawing.Point(384, 143);
            this.time_aprovacaoprel.Name = "time_aprovacaoprel";
            this.time_aprovacaoprel.Size = new System.Drawing.Size(200, 22);
            this.time_aprovacaoprel.TabIndex = 28;
            // 
            // time_analisefinal
            // 
            this.time_analisefinal.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_analisefinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_analisefinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_analisefinal.Location = new System.Drawing.Point(384, 189);
            this.time_analisefinal.Name = "time_analisefinal";
            this.time_analisefinal.Size = new System.Drawing.Size(200, 22);
            this.time_analisefinal.TabIndex = 29;
            // 
            // time_3d
            // 
            this.time_3d.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_3d.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_3d.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_3d.Location = new System.Drawing.Point(384, 235);
            this.time_3d.Name = "time_3d";
            this.time_3d.Size = new System.Drawing.Size(200, 22);
            this.time_3d.TabIndex = 30;
            // 
            // time_aprovacao
            // 
            this.time_aprovacao.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_aprovacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_aprovacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_aprovacao.Location = new System.Drawing.Point(384, 281);
            this.time_aprovacao.Name = "time_aprovacao";
            this.time_aprovacao.Size = new System.Drawing.Size(200, 22);
            this.time_aprovacao.TabIndex = 31;
            // 
            // time_lista
            // 
            this.time_lista.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.time_lista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_lista.Location = new System.Drawing.Point(384, 327);
            this.time_lista.Name = "time_lista";
            this.time_lista.Size = new System.Drawing.Size(200, 22);
            this.time_lista.TabIndex = 32;
            // 
            // prev_analise
            // 
            this.prev_analise.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_analise.Location = new System.Drawing.Point(681, 51);
            this.prev_analise.Name = "prev_analise";
            this.prev_analise.Size = new System.Drawing.Size(120, 22);
            this.prev_analise.TabIndex = 33;
            // 
            // prev_preliminar
            // 
            this.prev_preliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_preliminar.Location = new System.Drawing.Point(681, 97);
            this.prev_preliminar.Name = "prev_preliminar";
            this.prev_preliminar.Size = new System.Drawing.Size(120, 22);
            this.prev_preliminar.TabIndex = 34;
            // 
            // prev_3d
            // 
            this.prev_3d.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_3d.Location = new System.Drawing.Point(681, 235);
            this.prev_3d.Name = "prev_3d";
            this.prev_3d.Size = new System.Drawing.Size(120, 22);
            this.prev_3d.TabIndex = 40;
            // 
            // prev_aprovacao
            // 
            this.prev_aprovacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_aprovacao.Location = new System.Drawing.Point(681, 281);
            this.prev_aprovacao.Name = "prev_aprovacao";
            this.prev_aprovacao.Size = new System.Drawing.Size(120, 22);
            this.prev_aprovacao.TabIndex = 38;
            // 
            // prev_lista
            // 
            this.prev_lista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_lista.Location = new System.Drawing.Point(681, 327);
            this.prev_lista.Name = "prev_lista";
            this.prev_lista.Size = new System.Drawing.Size(120, 22);
            this.prev_lista.TabIndex = 36;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(969, 98);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 53);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SBPlaneamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 677);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SBPlaneamento";
            this.Text = "SBPlaneamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SBPlaneamento_FormClosed);
            this.Load += new System.EventHandler(this.SBPlaneamento_Load);
            this.Leave += new System.EventHandler(this.SBPlaneamento_Leave);
            this.MouseLeave += new System.EventHandler(this.SBPlaneamento_MouseLeave);
            this.tabela.ResumeLayout(false);
            this.tabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hr_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_aprovacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_3d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_analisefinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_aprovacaoprel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_preliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_analise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_analisefinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_aprovacaoprel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_analise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_preliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_3d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_aprovacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox cb_mold;
        private System.Windows.Forms.Label lbl_analise;
        private System.Windows.Forms.Label lbl_preliminar;
        private System.Windows.Forms.Label lbl_aprovprel;
        private System.Windows.Forms.Label lbl_analisefinal;
        private System.Windows.Forms.Label lbl_3d;
        private System.Windows.Forms.Label lbl_aprov;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_prev;
        private System.Windows.Forms.Label lbl_hrs;
        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.DateTimePicker time_analise;
        private System.Windows.Forms.DateTimePicker time_preliminar;
        private System.Windows.Forms.DateTimePicker time_aprovacaoprel;
        private System.Windows.Forms.DateTimePicker time_analisefinal;
        private System.Windows.Forms.DateTimePicker time_3d;
        private System.Windows.Forms.DateTimePicker time_aprovacao;
        private System.Windows.Forms.DateTimePicker time_lista;
        private System.Windows.Forms.NumericUpDown prev_analisefinal;
        private System.Windows.Forms.NumericUpDown prev_aprovacaoprel;
        private System.Windows.Forms.NumericUpDown prev_analise;
        private System.Windows.Forms.NumericUpDown prev_preliminar;
        private System.Windows.Forms.NumericUpDown prev_3d;
        private System.Windows.Forms.NumericUpDown prev_aprovacao;
        private System.Windows.Forms.NumericUpDown prev_lista;
        private System.Windows.Forms.NumericUpDown hr_lista;
        private System.Windows.Forms.NumericUpDown hr_aprovacao;
        private System.Windows.Forms.NumericUpDown hr_3d;
        private System.Windows.Forms.NumericUpDown hr_analisefinal;
        private System.Windows.Forms.NumericUpDown hr_aprovacaoprel;
        private System.Windows.Forms.NumericUpDown hr_preliminar;
        private System.Windows.Forms.NumericUpDown hr_analise;
        private System.Windows.Forms.Button btnGuardar;
    }
}