using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Travesía_por_la_jungla
{
    public partial class FrmAboutIt : Form
    {
        public FrmAboutIt()
        {
            InitializeComponent();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 420);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 130);
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 130);
        }
    }
}
