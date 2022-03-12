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
    public partial class SBCliente : Form
    {
        public SBCliente()
        {
            InitializeComponent();
        }
        private OleDbConnection conexaoBD()
        {
            string path = @"\SB Concept Molds\SB Concept Molds.accdb";
            FileInfo f = new FileInfo(path);
            string drive = Path.GetPathRoot(f.FullName);
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;  Data Source= j:\SB Concept Molds\SB Concept Molds.accdb; Persist Security Info=False;");
            return conexao;
        }
        //a coluna nif só aceitar números

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //alterar icon dentro do MDI Container
            Icon = new System.Drawing.Icon("icon.ico");
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //inserir dados na tabela cliente
            
            try
            {
                for (int i = dataGridView1.Rows.Count - 1; i > -1; i--)
                {
                    OleDbConnection conexao = conexaoBD();
                    string strInsert = "INSERT INTO cliente (nome, nif, último_projeto) VALUES ('" + dataGridView1.Rows[i].Cells["nome"].Value + "', '"
                        + dataGridView1.Rows[i].Cells["NIF"].Value + "', '" + dataGridView1.Rows[i].Cells["último_projeto"].Value + "')";
                    OleDbCommand comando = new OleDbCommand(strInsert, conexao);
                    conexao.Open();
                    comando.CommandText = strInsert;
                    comando.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Foi guardado com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int id, k;
        private void SBCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //eliminar linha vazia na tabela cliente
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from cliente", conexao);
            conexao.Open();
            OleDbCommand cd = new OleDbCommand("Delete from projeto where cliente = ''", conexao);
            cd.ExecuteNonQuery();
            da.Fill(ds, "cliente");
            for (int i = 0; i < ds.Tables["cliente"].Rows.Count; i++)
            {

                DataRow row = ds.Tables["cliente"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["cliente"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["cliente"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {

                        id = int.Parse(row.ItemArray.GetValue(0).ToString());
                        deletedupes(id);

                    }
                }
            }
        }
        private void SBCliente_Load(object sender, EventArgs e)
        {
            //carregar dados da tabela cliente
           
            
                    string strSelect = "SELECT Nome,NIF,Último_Projeto FROM cliente";
            OleDbConnection conexao = conexaoBD();
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(strSelect, conexao);
                DataSet ds = new DataSet();
                conexao.Open();
                dataadapter.Fill(ds, "cliente");
                conexao.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "cliente";
            
        }

        private void SBCliente_Leave(object sender, EventArgs e)
        {
            //eliminar linha vazia na tabela cliente
            OleDbConnection conexao = conexaoBD();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from cliente", conexao);
            conexao.Open();
            OleDbCommand cd = new OleDbCommand("Delete from projeto where cliente = ''", conexao);
            cd.ExecuteNonQuery();
            da.Fill(ds, "cliente");
            for (int i = 0; i < ds.Tables["cliente"].Rows.Count; i++)
            {

                DataRow row = ds.Tables["cliente"].Rows[i];
                k++;
                for (int j = k; j < ds.Tables["cliente"].Rows.Count; j++)
                {
                    DataRow row2 = ds.Tables["cliente"].Rows[j];
                    if (row2.ItemArray.GetValue(1).ToString() == row.ItemArray.GetValue(1).ToString())
                    {

                        id = int.Parse(row.ItemArray.GetValue(0).ToString());
                        deletedupes(id);

                    }
                }
            }
        }

        private void SBCliente_MouseLeave(object sender, EventArgs e)
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

