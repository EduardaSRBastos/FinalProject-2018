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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {

            InitializeComponent();

            pictureBox1.Image = SystemIcons.Warning.ToBitmap();

        }
       
        private void cbNaoMostrar_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShow = this.cbNaoMostrar.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
