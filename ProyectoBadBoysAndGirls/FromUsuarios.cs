// Agregamos la capa de negocio
// Establecer como Proyecto inicial
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
// agregamos 
using CapaNegocito;

namespace ProyectoBadBoysAndGirls
{
    public partial class FromUsuarios : Form
    {
        CP_Usuarios OCPG = new CP_Usuarios();
        // creo q es para editar
        private string id = null;
        //para el metodo de adicion
        private bool Editar = false;
        public FromUsuarios()
        {
            InitializeComponent();
            MostrarGral();
            txtId.Hide();
            BloqueBotones(true, false, true, true);
            BloqueoTextBox(false);
            txtNombre.Focus();
        }

        private void MostrarGral()
        {
            // tableUSUS 3
            CP_Usuarios OCPG = new CP_Usuarios();
            dgv.DataSource = OCPG.MostrarUsuario();
        }

        public void GeneraQR()
        {
            string txt = txtCi.Text+"  "+ txtNombre.Text+"  "+txtPaterno.Text + "  " + txtxMaterno.Text + "  " + txtCargo.Text + "  " + txtProfesion.Text + "  " + txtUsuario.Text + "  " + txtContraseña.Text + "  " + txtId.Text;
            if (txt != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txt), 200, 200);
                // muestra temporalmente
                pbGuardar.Image = bm;
            }
        }

        void BloqueBotones(bool nu, bool agre, bool mod, bool eli)
        {
            btnNuevo.Enabled = nu;
            btnGuardar.Enabled = agre;
            btnModificar.Enabled = mod;
            btnEli.Enabled = eli;
        }

        void BloqueoTextBox(bool sw)
        {
            txtCi.Enabled = sw;
            txtNombre.Enabled = sw;
            txtPaterno.Enabled = sw;
            txtxMaterno.Enabled = sw;
            txtCargo.Enabled = sw;
            txtProfesion.Enabled = sw;
            txtUsuario.Enabled = sw;
            txtContraseña.Enabled = sw;
        }

        void limpia()
        {
            txtCi.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtxMaterno.Text = "";
            txtCargo.Text = "";
            txtProfesion.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            FromUsuarios fu = new FromUsuarios();
            fu.ShowDialog();
        }
        private void MostrarUsuarios()
        {
            // tableUSUS 3
            CP_Usuarios OCP = new CP_Usuarios();
            dgv.DataSource = OCP.MostrarUsuario();
        }


        //btn guardar
        private void Insert()
        {
            if (Editar == false)
            {
                try
                {
                    //OCPG.InsertarUsuario();
                    MessageBox.Show("Se registro correctamente ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
                    //limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por: " + ex.Message, "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (Editar == true)
            {
                try
                {
                    //OCPG.EditarUsuario();
                    MessageBox.Show("Se modifico correctamente ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
                    //limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar los datos por: " + ex.Message, "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Para editar datagriew
        /*private void btnSelectDGV(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Editar = true;
                //cajatxt.tex=dgv.CurrentRow.Cells["AtributoBD"].Value.ToString();
                id = dgv.CurrentRow.Cells[""].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila por favor : ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnEliminar(DataGridView dgv, string id)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                idUsuario = dgv.CurrentRow.Cells[""].Value.ToString();
                OCPG.EliminarUsuario(idUsuario);
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Selecciona una fila por favor : ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        */
        private void index_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            BloqueoTextBox(true);
            limpia();            
            BloqueBotones(false, true, false, false);
            btnSalir.Text = "Cancelar";
            pbGuardar.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\carita1.jpeg");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            if (Editar == false)
            {
                try
                {

                    OCPG.InsertarUsuario(txtCi.Text, txtNombre.Text, txtPaterno.Text, txtxMaterno.Text, txtCargo.Text, txtProfesion.Text, txtUsuario.Text, txtContraseña.Text);
                    MessageBox.Show("Se registro correctamente ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarGral();
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por: " + ex.Message, "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (Editar == true)
            {
                try
                {
                    OCPG.EditarUsuario(txtCi.Text, txtNombre.Text, txtPaterno.Text, txtxMaterno.Text, txtCargo.Text, txtProfesion.Text, txtUsuario.Text, txtContraseña.Text,txtId.Text);
                    MessageBox.Show("Se modifico correctamente ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarGral();
                    limpia();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar los datos por: " + ex.Message, "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            BloqueoTextBox(false);
            BloqueBotones(true, false, true, true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            if (dgv.SelectedRows.Count > 0)
            {
                Editar = true;
                // para recuperar en el combo box              
                txtCi.Text = dgv.CurrentRow.Cells["CI"].Value.ToString();
                txtNombre.Text = dgv.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtPaterno.Text = dgv.CurrentRow.Cells["PATERNO"].Value.ToString();
                txtxMaterno.Text = dgv.CurrentRow.Cells["MATERNO"].Value.ToString();
                txtCargo.Text = dgv.CurrentRow.Cells["CARGO"].Value.ToString();
                txtProfesion.Text = dgv.CurrentRow.Cells["PROFESION"].Value.ToString();
                txtUsuario.Text = dgv.CurrentRow.Cells["USUARIO"].Value.ToString();
                txtContraseña.Text = dgv.CurrentRow.Cells["PASSWORD"].Value.ToString();

                txtId.Text = dgv.CurrentRow.Cells["USUARIO_NO"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila por favor : ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BloqueoTextBox(true);
            BloqueBotones(false, true, false, false);
            btnSalir.Text = "Cancelar";
            dgv.Enabled = false;
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                id = dgv.CurrentRow.Cells["USUARIO_NO"].Value.ToString();
                OCPG.EliminarUsuario(id);
                MostrarGral();
            }
            else
            {
                MessageBox.Show("Selecciona una fila por favor : ", "Bad Boys And Girls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BloqueBotones(true, false, true, true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (btnSalir.Text.Equals("Salir"))
            {
                Dispose();
            }
            else
            {
                MostrarGral();
                BloqueBotones(true, false, true, true);
                BloqueoTextBox(false);
                btnSalir.Text = "Salir";
                limpia();                
                dgv.Enabled = true;
                pbGuardar.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\carita1.jpeg");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CP_Usuarios OCPG = new CP_Usuarios();
            if (btnListar.Text.Equals("Lista Ascendente"))
            {
                dgv.DataSource = OCPG.MostrarUsuarioAscendente();
                btnListar.Text = "Lista Descendente";
            }
            else
            {
                dgv.DataSource = OCPG.MostrarUsuarioDescendente();
                btnListar.Text = "Lista Ascendente";
            }
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && !(e.KeyChar == 127) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo números", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo texto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo texto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtxMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo texto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo texto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !(e.KeyChar == 8))
            {
                MessageBox.Show("Ingrese solo texto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // si el valor es verdadero
                e.Handled = true;
                // retorna el valor en el parametro
                return;
            }
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.ToUpper();
            txtNombre.Select(txtNombre.Text.Length, 0);
            GeneraQR();
        }

        private void txtPaterno_TextChanged(object sender, EventArgs e)
        {
            txtPaterno.Text = txtPaterno.Text.ToUpper();
            txtPaterno.Select(txtNombre.Text.Length, 0);
            GeneraQR();
        }

        private void txtxMaterno_TextChanged(object sender, EventArgs e)
        {
            txtxMaterno.Text = txtxMaterno.Text.ToUpper();
            txtxMaterno.Select(txtxMaterno.Text.Length, 0);
            GeneraQR();
        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {
            txtProfesion.Text = txtProfesion.Text.ToUpper();
            txtProfesion.Select(txtProfesion.Text.Length, 0);
            GeneraQR();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            txtCargo.Text = txtCargo.Text.ToUpper();
            txtCargo.Select(txtCargo.Text.Length, 0);
            GeneraQR();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
