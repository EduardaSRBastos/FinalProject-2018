using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB_Concept_Molds
{
    public partial class Início : Form
    {
        public Início()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }

        }

        private class MyColors : ProfessionalColorTable
        {
            //Alterar cores quando se passa o rato por cima do botão
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkBlue; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Transparent; }
            }
        }
        private void ProjAtual_Click(object sender, EventArgs e)
        {
            //Abrir form SBProjAtual neste form ao clicar no botão Projeto Atual
            SBProjAtual newMDIChild = new SBProjAtual();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Planeamento_Click(object sender, EventArgs e)
        {
            //Abrir form SBPlaneamento neste form ao clicar no botão Planeamento
            SBPlaneamento newMDIChild = new SBPlaneamento();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Início_Load(object sender, EventArgs e)
        {
            //Abrir form SBProjAtual ao iniciar
            SBProjAtual newMDIChild = new SBProjAtual();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Projetos_Click(object sender, EventArgs e)
        {
            //Abrir form SBProjetos ao iniciar
            SBProjetos newMDIChild = new SBProjetos();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Catalogo_Click(object sender, EventArgs e)
        {
            //Abrir form SBCatálogo ao iniciar
            SBCatálogo newMDIChild = new SBCatálogo();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            //Abrir form SBCliente ao iniciar
            SBCliente newMDIChild = new SBCliente();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Início_FormClosed(object sender, FormClosedEventArgs e)
        {

            Properties.Settings.Default.Reset();
        }

      
    }
}
