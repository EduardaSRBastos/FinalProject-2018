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
using System.Diagnostics;
using System.IO;

namespace SB_Concept_Molds
{
    public partial class SBCatálogo : Form
    {
        public SBCatálogo()
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
        //Adicionar dados da BD para o Tree View
        private void SBCatálogo_Load(object sender, EventArgs e)
        {
            //alterar icon dentro do MDI Container
            Icon = new System.Drawing.Icon("icon.ico");
            string strSELECT = "SELECT * FROM catalogo";
            OleDbConnection conexao = conexaoBD();
            OleDbCommand modQtd = new OleDbCommand(strSELECT, conexao);
            conexao.Open();
            OleDbDataReader rdr = modQtd.ExecuteReader();
            { while (rdr.Read())
                {
                    for (int i = 1; i <= 10; i++)

                        treeView1.Nodes.Add(rdr[i].ToString());
                }
            }
            rdr.Close();
            conexao.Close();
          

}
        //Abrir localização da pasta
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = @"\SB Concept Molds\PDF";
            FileInfo f = new FileInfo(path);
            string drive = Path.GetPathRoot(f.FullName);
            try
                {
                    System.Diagnostics.Process.Start(drive + e.Node.Text);
                }
               
                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show("Pasta não existe.");
                }
            
        }

        
    }
}
