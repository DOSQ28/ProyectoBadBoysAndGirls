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
    public partial class Menu : Form
    {
        public Menu()
        {            
            InitializeComponent();
        }

        private void OcultoSubMenu()
        {
            panelUno.Visible = false;
            panelDos.Visible = false;
        }
        private void MuestraMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultoSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChill.Controls.Add(childForm);
            pnChill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnmenu_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(btnmenu, btnmenu.Width, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            OcultoSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FromEmpleados());
            OcultoSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultoSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultoSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OcultoSubMenu();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MuestraMenu(panelUno);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnMendia
            MuestraMenu(panelUno);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new FromOficina());
            OcultoSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new FromPartidas());
            OcultoSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new FromUsuarios());
            OcultoSubMenu();
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(btnmenu, btnmenu.Width, 0);
                        
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FromEmpleados());
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            //abrirChillForm(new Form2());
            //openChildFormInPanel(new FromEmpleados());
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\carita1.jpeg");
            OcultoSubMenu();
            FromEmpleados op = new FromEmpleados();
            op.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //abrirChillForm(new Form2());
            //openChildFormInPanel(new FromPartidas());
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\bg1.jpeg");
            OcultoSubMenu();
            FromPartidas op = new FromPartidas();
            op.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //abrirChillForm(new Form2());
            //openChildFormInPanel(new FromOficina());
            OcultoSubMenu();
            FromOficina op = new FromOficina();
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\peakpx.jpg");
            op.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //abrirChillForm(new Form2());
            //openChildFormInPanel(new FromUsuarios());
            FromUsuarios op = new FromUsuarios();
            op.Show();
            OcultoSubMenu();
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\bg1.jpeg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MuestraMenu(panelDos);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //openChildFormInPanel(new FromInventarios());
            OcultoSubMenu();
            FromInventarios op = new FromInventarios();
            op.Show();
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\activos fijos.jpg");
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("D:\\RecursosProyectos\\iconosEma png\\iconos png\\logoGru.jpg");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {            
            openChildFormInPanel(new QR());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
