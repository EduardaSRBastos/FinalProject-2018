using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SB_Concept_Molds
{
    public partial class SBPlaneamento : Form
    {
        public SBPlaneamento()
        {
            InitializeComponent();
        }
        private OleDbConnection conexaoBD()
        {
            string path = @"\SB Concept Molds\SB Concept Molds.accdb";
            FileInfo f = new FileInfo(path);
            string drive = Path.GetPathRoot(f.FullName);
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= j:\SB Concept Molds\SB Concept Molds.accdb; Persist Security Info=False;");
            return conexao;
        }
        private void SBPlaneamento_Load(object sender, EventArgs e)
        {
            this.tabela.CellPaint += new TableLayoutCellPaintEventHandler(tabela_CellPaint);
            //alterar icon dentro do MDI Container
            Icon = new System.Drawing.Icon("icon.ico");

            //Defini valores de acordo os dados da BD
            string strSELECT = "SELECT nome_projeto FROM projeto";
            OleDbConnection conexao = conexaoBD();
            OleDbCommand modQtd = new OleDbCommand(strSELECT, conexao);
            conexao.Open();
            OleDbDataReader rdr = modQtd.ExecuteReader();
            while (rdr.Read())
            {
                cb_mold.Items.Add(rdr[0]);

            }
            rdr.Close();
            
            conexao.Close();
            //primeiro item da combobox estar selecionado
            cb_mold.SelectedIndex = 0;
            
        }

        private void tabela_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //cores de fundo da tabela
            if (e.Row == 0)
            {
                if (e.Column == 0)
                    e.Graphics.FillRectangle(Brushes.RoyalBlue, e.CellBounds);
                else
                    e.Graphics.FillRectangle(Brushes.RoyalBlue, e.CellBounds);
            }
            else
            {
                if (e.Column == 0)
                    e.Graphics.FillRectangle(Brushes.RoyalBlue, e.CellBounds);
            }
            if (e.Column == 0 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
        }
        //Guardar valores na BD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string strInsert = "INSERT INTO planeamento (nome_proj, 1_1, 1_2, 1_3, 2_1, 2_2, 2_3, 3_1, 3_2, 3_3, 4_1, 4_2, 4_3, 5_1, 5_2, 5_3, 6_1, 6_2, 6_3, 7_1, 7_2, 7_3) VALUES ('" +
                 cb_mold.SelectedItem.ToString() + "', '" + time_analise.Text + "', '" + prev_analise.Text + "', '" + hr_analise.Text + "', '" + time_preliminar.Text + "', '" + prev_preliminar.Text + "', '" + hr_preliminar.Text + "', '" + time_aprovacaoprel.Text + "', '" + prev_aprovacaoprel.Text + "', '" + hr_aprovacaoprel.Text + "', '" + time_analisefinal.Text + "', '" + prev_analisefinal.Text + "', '" + hr_analisefinal.Text +
                "', '" + time_3d.Text + "', '" + prev_3d.Text + "', '" + hr_3d.Text + "', '" + time_aprovacao.Text + "', '" + prev_aprovacao.Text + "', '" + hr_aprovacao.Text + "', '" + time_lista.Text + "', '" + prev_lista.Text + "', '" + hr_lista.Text + "')";
                OleDbConnection conexao = conexaoBD();
                OleDbCommand comando = new OleDbCommand(strInsert, conexao);
                conexao.Open();
                comando.CommandText = strInsert;
                comando.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Foi guardado com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //eliminar dados da BD duplicados
        int id, k;
        private void SBPlaneamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from planeamento", conexao);
            conexao.Open();
            da.Fill(ds, "planeamento");
            for (int i = 0; i < ds.Tables["planeamento"].Rows.Count; i++)
            {
                
                DataRow row = ds.Tables["planeamento"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["planeamento"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["planeamento"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {
                        
                            id = int.Parse(row.ItemArray.GetValue(0).ToString());
                            deletedupes(id);
                      
                    }
                }
            }

            conexao.Close();
        }
        //processo para eliminar dados na BD
        private void deletedupes(int num)
        {

            OleDbConnection conexao = conexaoBD();
            conexao.Open();

            OleDbCommand c = new OleDbCommand("Delete from planeamento where id =?", conexao);
            c.Parameters.AddWithValue("id", num);
            c.ExecuteNonQuery();

            conexao.Close();
        }

        private void SBPlaneamento_Leave(object sender, EventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from planeamento", conexao);
            conexao.Open();
            da.Fill(ds, "planeamento");
            for (int i = 0; i < ds.Tables["planeamento"].Rows.Count; i++)
            {

                DataRow row = ds.Tables["planeamento"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["planeamento"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["planeamento"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {

                        id = int.Parse(row.ItemArray.GetValue(0).ToString());
                        deletedupes(id);

                    }
                }
            }

            conexao.Close();
        }

        private void SBPlaneamento_MouseLeave(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DontShow)
                new MessageForm().ShowDialog();
        }



        //adicionar dados da BD
        private void cb_mold_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            string strSELECT2 = "SELECT * FROM planeamento WHERE nome_proj = '" + cb_mold.SelectedItem.ToString() + "'";
            OleDbCommand modQtd2 = new OleDbCommand(strSELECT2, conexao);
            conexao.Open();
            OleDbDataReader rdr2 = modQtd2.ExecuteReader();
            while (rdr2.Read())
            {
                time_analise.Value = Convert.ToDateTime(rdr2[2]);
                prev_analise.Value = Convert.ToInt32(rdr2[3]);
                hr_analise.Value = Convert.ToInt32(rdr2[4]);
                time_preliminar.Value = Convert.ToDateTime(rdr2[5]);
                prev_preliminar.Value = Convert.ToInt32(rdr2[6]);
                hr_preliminar.Value = Convert.ToInt32(rdr2[7]);
                time_aprovacaoprel.Value = Convert.ToDateTime(rdr2[8]);
                prev_aprovacaoprel.Value = Convert.ToInt32(rdr2[9]);
                hr_aprovacaoprel.Value = Convert.ToInt32(rdr2[10]);
                time_analisefinal.Value = Convert.ToDateTime(rdr2[11]);
                prev_analisefinal.Value = Convert.ToInt32(rdr2[12]);
                hr_analisefinal.Value = Convert.ToInt32(rdr2[13]);
                time_3d.Value = Convert.ToDateTime(rdr2[14]);
                prev_3d.Value = Convert.ToInt32(rdr2[15]);
                hr_3d.Value = Convert.ToInt32(rdr2[16]);
                time_aprovacao.Value = Convert.ToDateTime(rdr2[17]);
                prev_aprovacao.Value = Convert.ToInt32(rdr2[18]);
                hr_aprovacao.Value = Convert.ToInt32(rdr2[19]);
                time_lista.Value = Convert.ToDateTime(rdr2[20]);
                prev_lista.Value = Convert.ToInt32(rdr2[21]);
                hr_lista.Value = Convert.ToInt32(rdr2[22]);
            }
            rdr2.Close();
            conexao.Close();
            
        }

       
    }
}
