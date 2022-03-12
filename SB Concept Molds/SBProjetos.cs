using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;

namespace SB_Concept_Molds
{
    public partial class SBProjetos : Form
    {
        public SBProjetos()
        {
            InitializeComponent();
            treeView1.Nodes[0].ExpandAll();
        }
        private OleDbConnection conexaoBD()
        {
            string path = @"\SB Concept Molds\SB Concept Molds.accdb";
            FileInfo f = new FileInfo(path);
            string drive = Path.GetPathRoot(f.FullName);
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;  Data Source= j:\SB Concept Molds\SB Concept Molds.accdb; Persist Security Info=False;");
            return conexao;
        }
        private void SBProjetos_Load(object sender, EventArgs e)
        {
           
            //carregar dados da tabela projeto          
        

            string strSelect = "SELECT Nome_projeto,descrição,cliente,aceite,fase,última_atualização,data_entrega FROM projeto";
            OleDbConnection conexao = conexaoBD();
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(strSelect, conexao);
            DataSet ds = new DataSet();
            conexao.Open();
            dataadapter.Fill(ds, "projeto");
            conexao.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "projeto";
            //definir coluna como tipo data
            dataGridView1.Columns["data_entrega"].ValueType = typeof(System.DateTime);
            dataGridView1.Columns["última_atualização"].ValueType = typeof(System.DateTime);
            //definir coluna como tipo inteiro
            dataGridView1.Columns["fase"].ValueType = typeof(System.Int32);
            ((DataGridViewTextBoxColumn)dataGridView1.Columns["fase"]).MaxInputLength = 1;
            //alterar icon dentro do MDI Container
            Icon = new System.Drawing.Icon("icon.ico");
        }
        //a coluna fase só aceitar números de 1 a 7
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            //a coluna ult. atualizacao e dataentrega só aceitar números e a barra
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            } else if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '/') )
            {
                e.Handled = true;
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '1' && e.KeyChar <= '7') && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        //guardar dados na tabela projeto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //definir valor do sim e nao
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["aceite"];
                 if (chk.Value == chk.TrueValue)
                {
                    chk.Value = -1;
                }
                else if (chk.Value == DBNull.Value)
                {
                    chk.Value = 0;
                }
            }
            //atualizar a tabela da BD
           
            try
            {
                for (int i = dataGridView1.Rows.Count - 1; i > -1; i--)
                {
                    OleDbConnection conexao = conexaoBD();
                    DateTime date = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells["última_atualização"].Value); 
                    DateTime date2 = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells["data_entrega"].Value);
                   string strInsert = "INSERT INTO projeto (nome_projeto, descrição, cliente, aceite, fase,última_atualização,data_entrega) VALUES ('" + dataGridView1.Rows[i].Cells["nome_projeto"].Value + "', '"
                        + dataGridView1.Rows[i].Cells["descrição"].Value + "', '" + dataGridView1.Rows[i].Cells["cliente"].Value + "', " + dataGridView1.Rows[i].Cells["aceite"].Value + ", '" + dataGridView1.Rows[i].Cells["fase"].Value +
                      "', ? , ? )";
                    string strInsert2 = "INSERT INTO projetoatual (nome_proj, cliente)VALUES ('" + dataGridView1.Rows[i].Cells["nome_projeto"].Value + "', '" + dataGridView1.Rows[i].Cells["cliente"].Value + "')";
                    string strInsert3 = "INSERT INTO cliente (último_projeto, nome)VALUES ('" + dataGridView1.Rows[i].Cells["nome_projeto"].Value + "', '" + dataGridView1.Rows[i].Cells["cliente"].Value + "')";
                    OleDbCommand comando = new OleDbCommand(strInsert, conexao);
                    OleDbCommand comando2 = new OleDbCommand(strInsert2, conexao);
                    OleDbCommand comando3 = new OleDbCommand(strInsert3, conexao);
                    comando.Parameters.Add("última_atualização", OleDbType.DBDate).Value = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells["última_atualização"].Value);
                    comando.Parameters.Add("data_entrega", OleDbType.DBDate).Value = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells["data_entrega"].Value);
                    conexao.Open();
                    comando.CommandText = strInsert;
                    comando.ExecuteNonQuery();
                    comando2.CommandText = strInsert2;
                    comando2.ExecuteNonQuery();
                    comando3.CommandText = strInsert3;
                    comando3.ExecuteNonQuery();
                    conexao.Close();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Foi guardado com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //eliminar dados duplicados na tabela projeto
        int id, k;
        private void SBProjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from projeto", conexao);
            conexao.Open();
            OleDbCommand cd = new OleDbCommand("Delete from projeto where nome_projeto = ''", conexao);
            cd.ExecuteNonQuery();
            da.Fill(ds, "projeto");
            for (int i = 0; i < ds.Tables["projeto"].Rows.Count; i++)
            {

                DataRow row = ds.Tables["projeto"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["projeto"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["projeto"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {

                        id = int.Parse(row.ItemArray.GetValue(0).ToString());
                        deletedupes(id);

                    }
                }
            }

            conexao.Close();
        }

        private void SBProjetos_Leave(object sender, EventArgs e)
        {
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from projeto", conexao);
            conexao.Open();
            OleDbCommand cd = new OleDbCommand("Delete from projeto where nome_projeto = ''", conexao);
            cd.ExecuteNonQuery();
            da.Fill(ds, "projeto");
            for (int i = 0; i < ds.Tables["projeto"].Rows.Count; i++)
            {

                DataRow row = ds.Tables["projeto"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["projeto"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["projeto"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {

                        id = int.Parse(row.ItemArray.GetValue(0).ToString());
                        deletedupes(id);

                    }
                }
            }

            conexao.Close();
        }

        private void SBProjetos_MouseLeave(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.DontShow)
                new MessageForm().ShowDialog();
        }
        

        private void deletedupes(int num)
        {

            OleDbConnection conexao = conexaoBD();
            conexao.Open();

            OleDbCommand c = new OleDbCommand("Delete from projeto where id =?", conexao);
            c.Parameters.AddWithValue("id", num);
            c.ExecuteNonQuery();
          
            conexao.Close();
        }
    }
    }

