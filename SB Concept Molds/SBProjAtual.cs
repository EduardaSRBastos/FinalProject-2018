using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;

namespace SB_Concept_Molds
{
    public partial class SBProjAtual : Form
    {
        
       
        private OleDbConnection conexaoBD()
        {
            string path = @"\SB Concept Molds\SB Concept Molds.accdb";
            FileInfo f = new FileInfo(path);
            string drive = Path.GetPathRoot(f.FullName);
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;  Data Source= j:\SB Concept Molds\SB Concept Molds.accdb; Persist Security Info=False;");
            return conexao;
        }
        public SBProjAtual()
        {
            
            InitializeComponent();
            //cantos arredondados do quadrado com o nome do projeto atual
            Rectangle r = new Rectangle(0, 0, sqr_nome.Width, sqr_nome.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            sqr_nome.Region = new Region(gp);

            
        }
        string bolddate;
        private void SBProjAtual_Load(object sender, EventArgs e)
        {

            //alterar icon dentro do MDI Container
            Icon = new System.Drawing.Icon("icon.ico");
            OleDbConnection conexao = conexaoBD();
            //Defini valores de acordo os dados da BD
            string strSELECT = "SELECT nome_projeto FROM projeto where última_atualização = (select max(última_atualização) from projeto)";
            OleDbCommand modQtd = new OleDbCommand(strSELECT, conexao);
            conexao.Open();
            OleDbDataReader rdr = modQtd.ExecuteReader();
            rdr.Read();
            lbl_nome.Text = rdr["nome_projeto"].ToString();
            rdr.Close();
            string strSELECT2 = "SELECT cliente FROM projeto where última_atualização = (select max(última_atualização) from projeto)";
            OleDbCommand modQtd2 = new OleDbCommand(strSELECT2, conexao);
            OleDbDataReader rdr2 = modQtd2.ExecuteReader();
            rdr2.Read();
            txt_nome.Text = rdr2["cliente"].ToString();
            rdr2.Close();
            string strSELECT3 = "SELECT data_entrega FROM projeto where última_atualização = (select max(última_atualização) from projeto)";
            OleDbCommand modQtd3 = new OleDbCommand(strSELECT3, conexao);
            OleDbDataReader rdr3 = modQtd3.ExecuteReader();
            rdr3.Read();
            var data = Convert.ToDateTime(rdr3["data_entrega"]);
            bolddate = data.ToShortDateString();
            monthCalendar1.AddBoldedDate(Convert.ToDateTime(rdr3["data_entrega"]));
            monthCalendar1.SetSelectionRange(Convert.ToDateTime(rdr3["data_entrega"]), Convert.ToDateTime(rdr3["data_entrega"]));
            lbldataent.Text = "Data de Entrega:" + data.ToShortDateString();
            var dias = data - DateTime.Today;
            lbldias.Text = "Dias Restantes: " + dias.TotalDays;
            rdr3.Close();
            string strSELECT4 = "SELECT analisepecarelatorio,orcamento,orcamentocomplaneamento,preliminar,modelacaoinicial,modelacaomecanismo,modelacaoinjecao,modelacaorefrigeracao,assemblagemacessorios,execucaodetalhes,execucaofinal FROM projetoatual WHERE nome_proj = '" + lbl_nome.Text + "'";
            OleDbCommand modQtd4 = new OleDbCommand(strSELECT4, conexao);
            OleDbDataReader rdr4 = modQtd4.ExecuteReader();
            rdr4.Read();
           if(Convert.ToInt32(rdr4[0].ToString())==1)
            {
                checkBox1.Checked = true;
            }
            else { checkBox1.Checked = false; }
            if (Convert.ToInt32(rdr4[1].ToString()) == 1)
            {
                checkBox2.Checked = true;
            }
            else { checkBox2.Checked = false; }
            if (Convert.ToInt32(rdr4[2].ToString()) == 1)
            {
                checkBox3.Checked = true;
            }
            else { checkBox3.Checked = false; }
            if (Convert.ToInt32(rdr4[3].ToString()) == 1)
            {
                checkBox4.Checked = true;
            }
            else { checkBox4.Checked = false; }
            if (Convert.ToInt32(rdr4[4].ToString()) == 1)
            {
                checkBox5.Checked = true;
            }
            else { checkBox5.Checked = false; }
            if (Convert.ToInt32(rdr4[5].ToString()) == 1)
            {
                checkBox6.Checked = true;
            }
            else { checkBox6.Checked = false; }
            if (Convert.ToInt32(rdr4[6].ToString()) == 1)
            {
                checkBox7.Checked = true;
            }
            else { checkBox7.Checked = false; }
            if (Convert.ToInt32(rdr4[7].ToString()) == 1)
            {
                checkBox8.Checked = true;
            }
            else { checkBox8.Checked = false; }
            if (Convert.ToInt32(rdr4[8].ToString()) == 1)
            {
                checkBox9.Checked = true;
            }
            else { checkBox9.Checked = false; }
            if (Convert.ToInt32(rdr4[9].ToString()) == 1)
            {
                checkBox10.Checked = true;
            }
            else { checkBox10.Checked = false; }
            if (Convert.ToInt32(rdr4[10].ToString()) == 1)
            {
                checkBox11.Checked = true;
            }
            else { checkBox11.Checked = false; }
            rdr4.Close();
                conexao.Close();
            if (checkBox1.Checked == true) { checkBox2.Enabled = true; } else {  checkBox2.Enabled = false; }
            if (checkBox2.Checked == true) {  checkBox3.Enabled = true; } else {  checkBox3.Enabled = false; }
            if (checkBox3.Checked == true) { checkBox4.Enabled = true; } else { checkBox4.Enabled = false; }
            if (checkBox4.Checked == true) { checkBox5.Enabled = true; } else { checkBox5.Enabled = false; }
            if (checkBox5.Checked == true) { checkBox6.Enabled = true; } else { checkBox6.Enabled = false; }
            if (checkBox6.Checked == true) { checkBox7.Enabled = true; } else { checkBox7.Enabled = false; }
            if (checkBox7.Checked == true) { checkBox8.Enabled = true; } else { checkBox8.Enabled = false; }
            if (checkBox8.Checked == true) {  checkBox9.Enabled = true; } else { checkBox9.Enabled = false; }
            if (checkBox9.Checked == true) {  checkBox10.Enabled = true; } else {  checkBox10.Enabled = false; }
            if (checkBox10.Checked == true) { checkBox11.Enabled = true; } else {  checkBox11.Enabled = false; }
        }

        int id, k;

        private void monthCalendar1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.Show(bolddate, this, 561, 326, 1500);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from projetoatual", conexao);
            conexao.Open();
            int[] value = new int[gbTarefas.Controls.Count];
            try
            {
                    
                    if (checkBox1.Checked == true) {value[0] = 1; } else  { value[0] = 0;}
                    if (checkBox2.Checked == true) { value[1] = 1; } else { value[1] = 0; }
                    if (checkBox3.Checked == true) { value[2] = 1; } else { value[2] = 0; }
                    if (checkBox4.Checked == true) { value[3] = 1; } else { value[3] = 0; }
                    if (checkBox5.Checked == true) { value[4] = 1; } else { value[4] = 0; }
                    if (checkBox6.Checked == true) { value[5] = 1; } else { value[5] = 0; }
                    if (checkBox7.Checked == true) { value[6] = 1; } else { value[6] = 0; }
                    if (checkBox8.Checked == true) { value[7] = 1; } else { value[7] = 0; }
                    if (checkBox9.Checked == true) { value[8] = 1; } else { value[8] = 0; }
                    if (checkBox10.Checked == true) { value[9] = 1; } else { value[9] = 0; }
                    if (checkBox11.Checked == true) { value[10] = 1; } else { value[10] = 0; }
                
                

                //Inserir na BD os valores
                string strInsert = "INSERT INTO projetoatual (nome_proj, cliente,analisepecarelatorio,orcamento,orcamentocomplaneamento,preliminar,modelacaoinicial,modelacaomecanismo,modelacaoinjecao,modelacaorefrigeracao,assemblagemacessorios,execucaodetalhes,execucaofinal) VALUES ('" +
                        lbl_nome.Text + "', '" + txt_nome.Text + "', " + value[0] + ", " + value[1] + ", " + value[2] + ", " + value[3] + ", " + value[4] + ", " + value[5] + ", " + value[6] + ", " + value[7] + ", " + value[8] + ", " + value[9] + ", " + value[10] + ")";
                    OleDbCommand comando = new OleDbCommand(strInsert, conexao);
                    comando.CommandText = strInsert;
                    comando.ExecuteNonQuery();

                    OleDbCommand cd = new OleDbCommand("Delete from projetoatual where nome_proj = ''", conexao);
                    cd.ExecuteNonQuery();
                    da.Fill(ds, "projetoatual");
                    for (int l = 0; l < ds.Tables["projetoatual"].Rows.Count; l++)
                    {

                        DataRow row = ds.Tables["projetoatual"].Rows[l];
                        k++;
                        for (int j = k; j < ds.Tables["projetoatual"].Rows.Count; j++)
                        {
                            DataRow row2 = ds.Tables["projetoatual"].Rows[j];
                            if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                            {

                                id = int.Parse(row.ItemArray.GetValue(0).ToString());
                                deletedupes(id);

                            }
                        }
                    }
                 
                conexao.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Foi guardado com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { checkBox2.Enabled = true; } else { checkBox2.Enabled = false; }
            if (checkBox2.Checked == true) { checkBox3.Enabled = true; } else { checkBox3.Enabled = false; }
            if (checkBox3.Checked == true) { checkBox4.Enabled = true; } else { checkBox4.Enabled = false; }
            if (checkBox4.Checked == true) { checkBox5.Enabled = true; } else { checkBox5.Enabled = false; }
            if (checkBox5.Checked == true) { checkBox6.Enabled = true; } else { checkBox6.Enabled = false; }
            if (checkBox6.Checked == true) { checkBox7.Enabled = true; } else { checkBox7.Enabled = false; }
            if (checkBox7.Checked == true) { checkBox8.Enabled = true; } else { checkBox8.Enabled = false; }
            if (checkBox8.Checked == true) { checkBox9.Enabled = true; } else { checkBox9.Enabled = false; }
            if (checkBox9.Checked == true) { checkBox10.Enabled = true; } else { checkBox10.Enabled = false; }
            if (checkBox10.Checked == true) { checkBox11.Enabled = true; } else { checkBox11.Enabled = false; }
        }

        private void SBProjAtual_MouseLeave(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DontShow)
                new MessageForm().ShowDialog();
        }

        private void deletedupes(int num)
        {
            OleDbConnection conexao = conexaoBD();
            
            conexao.Open();

            OleDbCommand c = new OleDbCommand("Delete from projetoatual where id =?", conexao);
            c.Parameters.AddWithValue("id", num);
            c.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
