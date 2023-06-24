using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace ProyectoBadBoysAndGirls
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }

        private void txtEscribir_TextChanged(object sender, EventArgs e)
        {
            if (txtEscribir.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtEscribir.Text), 200, 200);
                // muestra temporalmente
                pbGuardar.Image = bm;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtEscribir.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtEscribir.Text), 250, 2590);
                // muestra temporalmente
                pbGuardar.Image = bm;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtLeer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //btn abrir
            OpenFileDialog ofd = new OpenFileDialog();
            {
                ofd.Filter = "Imagen png |*.png";
                ofd.InitialDirectory = @"C:\Descargas\Codigos Barra";
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbAbrir.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string txt = br.Decode((Bitmap)pbAbrir.Image).ToString();
                //Mostramos en textbox
                txtLeer.Text = txt;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //btn guardar
            SaveFileDialog sfd = new SaveFileDialog();
            {
                sfd.Filter = "Imagen png|*.png";
                sfd.InitialDirectory = @"C:\Descargas\Codigos Barra";
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbGuardar.Image.Save(sfd.FileName);
            }
        }
    }
}
