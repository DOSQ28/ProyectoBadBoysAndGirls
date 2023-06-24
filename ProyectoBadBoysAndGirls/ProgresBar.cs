using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBadBoysAndGirls
{
    public partial class ProgresBar : Form
    {
        Menu me = new ProyectoBadBoysAndGirls.Menu();        
        public ProgresBar()
        {
            InitializeComponent();            
        }

        private void ProgresBar_Load(object sender, EventArgs e)
        {
            //aca si se puede , cargar los datos del usuario que esta ingresando 
            //   lbUsuario.Text = UserCache.Firstname + "" + UserCache.lastname;
            this.Opacity = 0.0;
            cirprogres.Value = 0;
            cirprogres.Minimum = 0;
            cirprogres.Maximum = 100;
            timer1.Start();            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                me.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.019;
            cirprogres.Value += 1;
            if (cirprogres.Value == 100)
            {
                timer1.Stop();
                timer2.Start();                
            }                        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cirprogres_Click(object sender, EventArgs e)
        {

        }
    }
}
