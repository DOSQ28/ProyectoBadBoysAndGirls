using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocito;
using ZXing;


namespace ProyectoBadBoysAndGirls
{
    public partial class FromInventarios : Form
    {
        CP_Inventarios OCPG = new CP_Inventarios();
        // creo q es para editar
        private string id = null, idEmp=null;
        //para el metodo de adicion
        private bool Editar = false;
        public FromInventarios()
        {
            InitializeComponent();
            MostrarGral();
            txtId.Hide();
            BloqueBotones(true, false, true, true);
            BloqueoTextBox(false);
            cbbusqueda();
        }

        private void MostrarGral()
        {
            // tableUSUS 3
            CP_Inventarios OCPG = new CP_Inventarios();
            dgv.DataSource = OCPG.MostrarAscendente();
        }

        void cbbusqueda() {
            cbBusqueda.Items.Add("AUXILIAR");
            cbBusqueda.Items.Add("COD_ENTIDAD");
            cbBusqueda.Items.Add("DESCRIPCION");
            cbBusqueda.Items.Add("ESTADO");
            cbBusqueda.Items.Add("FECHA_INGRESO");
        }

        void usuario()
        {
            CP_Usuarios cbusu = new CP_Usuarios();
            foreach (var item in cbusu.CbUsuario())
            {
               // CbUsu.Items.Add(item);
            }
        }
        public void GeneraQR()
        {
            string txt = txtAuxiliar.Text+"  " + txtCodigoEntidad.Text + "  " + txtCodigoAntiguo.Text + "  " + txtSerie.Text + "  " + txtDescripcion.Text + "  " + txtEstado.Text + "  " + txtEspecifica.Text + "  " +  txtProcedencia.Text+"  " + dtpFechadeIngreso.Value + "  " + txtObservacion.Text;
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
            btnEliminar.Enabled = eli;
        }

        void BloqueoTextBox(bool sw)
        {
            txtAuxiliar.Enabled = sw;
            cbPartida.Enabled = sw;
            txtCodigoEntidad.Enabled = sw;
            txtCodigoAntiguo.Enabled = sw;
            txtSerie.Enabled = sw;
            txtDescripcion.Enabled = sw;
            txtEstado.Enabled = sw;
            txtEspecifica.Enabled = sw;
            txtEmpNo.Enabled = sw;
            txtProcedencia.Enabled = sw;
            dtpFechadeIngreso.Enabled = sw;
            txtObservacion.Enabled = sw;
        }

        void limpia()
        {
            txtAuxiliar.Text = "";
            cbPartida.Items.Clear();
            txtCodigoEntidad.Text = "";
            txtCodigoAntiguo.Text = "";
            txtSerie.Text = "";
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            txtEspecifica.Text = "";
            txtEmpNo.Text = "";
            txtProcedencia.Text = "";
            dtpFechadeIngreso.Text = "";
            txtObservacion.Text = "";
            txtEmpNo.Text = "";
        }

        void comboBox()
        {
            CP_Partida cbusu = new CP_Partida();
            foreach (var item in cbusu.CbpARTIDA())
            {
                cbPartida.Items.Add(item);
            }
            /*CP_Empleados cbo = new CP_Empleados();
            for (int i = 0; i < cbo.CbEmpleados().Count; i++)
            {
                txtEmpNo.Items.Add(cbo.CbEmpleados()[i]);
            }*/
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
//            MessageBox.Show(dtpFechadeIngreso.Value+"");
  //          MessageBox.Show(OCPG.RecuperaFecha(txtId.Text)+"");
            Editar = false;
            BloqueoTextBox(true);
            limpia();
            comboBox();
            usuario();
            BloqueBotones(false, true, false, false);
            btnSalir.Text = "Cancelar";
            pbGuardar.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\carita1.jpeg");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usu = Convert.ToString(cbPartida.SelectedItem);
            usu = usu.Substring(0, usu.IndexOf('|'));            
            if (Editar == false)
            {
                try
                {                    
                    OCPG.Insertar(txtAuxiliar.Text, usu, txtCodigoEntidad.Text, txtCodigoAntiguo.Text, txtSerie.Text, txtDescripcion.Text, txtEstado.Text, txtEspecifica.Text,idEmp, txtProcedencia.Text, dtpFechadeIngreso.Value, txtObservacion.Text);
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
                    OCPG.Editar(txtAuxiliar.Text, usu, txtCodigoEntidad.Text, txtCodigoAntiguo.Text, txtSerie.Text, txtDescripcion.Text, txtEstado.Text, txtEspecifica.Text, usu, txtProcedencia.Text, dtpFechadeIngreso.Value, txtObservacion.Text, txtId.Text);
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
                comboBox();
                Editar = true;
                // para recuperar en el combo box              
                txtAuxiliar.Text = dgv.CurrentRow.Cells["AUXILIAR"].Value.ToString();
                CP_Partida cbpart = new CP_Partida();
                cbPartida.SelectedItem = cbpart.RUF(dgv.CurrentRow.Cells["PARTIDA"].Value.ToString());                
                txtCodigoEntidad.Text = dgv.CurrentRow.Cells["COD_ENTIDAD"].Value.ToString();
                txtCodigoAntiguo.Text = dgv.CurrentRow.Cells["COD_ANTIGUO"].Value.ToString();
                txtSerie.Text = dgv.CurrentRow.Cells["SERIE"].Value.ToString();
                txtDescripcion.Text = dgv.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                txtEstado.Text = dgv.CurrentRow.Cells["ESTADO"].Value.ToString();
                txtEspecifica.Text = dgv.CurrentRow.Cells["ESPECIFICA"].Value.ToString();                
                txtProcedencia.Text = dgv.CurrentRow.Cells["PROCEDENCIA"].Value.ToString();
                DateTime fe = OCPG.RecuperaFecha(txtId.Text);
                dtpFechadeIngreso.Value = fe;// dgv.CurrentRow.Cells["FECHA_INGRESO"].Value.ToString();
                txtObservacion.Text = dgv.CurrentRow.Cells["OBSERVACION"].Value.ToString();
                CP_Empleados emp = new CP_Empleados();
                txtEmpNo.Text = emp.RUF(dgv.CurrentRow.Cells["EMP_NO"].Value.ToString());
                txtId.Text = dgv.CurrentRow.Cells["INV_NO"].Value.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                id = dgv.CurrentRow.Cells["INV_NO"].Value.ToString();
                OCPG.Eliminar(id);
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
                usuario();
                dgv.Enabled = true;
                pbGuardar.Image = System.Drawing.Image.FromFile("D:\\UPEA\\8-1-2023\\soft\\PROYECTO_GRUPAL\\C#\\ProyectoBadBoysAndGirls\\ProyectoBadBoysAndGirls\\Resources\\carita1.jpeg");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CP_Inventarios OCPG = new CP_Inventarios();
            if (btnListar.Text.Equals("Lista Ascendente"))
            {
                dgv.DataSource = OCPG.MostrarAscendente();
                btnListar.Text = "Lista Descendente";
            }
            else
            {
                dgv.DataSource = OCPG.MostrarDescendente();
                btnListar.Text = "Lista Ascendente";
            }
        }

        private void FromInventarios_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtbus_TextChanged(object sender, EventArgs e)
        {
            string id = txtbus.Text;
            CP_Empleados cbusu = new CP_Empleados();            
            dgvEmpleado.DataSource= cbusu.Busqueda("%"+id+"%","");
        }

        private void REmp(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpNo.Text = dgvEmpleado.CurrentRow.Cells["CI"].Value.ToString() +"       "+ dgvEmpleado.CurrentRow.Cells["NOMBRE"].Value.ToString();
            idEmp = dgvEmpleado.CurrentRow.Cells["EMP_NO"].Value.ToString();
        }

        private void txtAuxiliar_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtAuxiliar.Text = txtAuxiliar.Text.ToUpper();
            txtAuxiliar.Select(txtAuxiliar.Text.Length, 0);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtEstado.Text = txtEstado.Text.ToUpper();
            txtEstado.Select(txtEstado.Text.Length, 0);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtDescripcion.Text = txtDescripcion.Text.ToUpper();
            txtDescripcion.Select(txtDescripcion.Text.Length, 0);
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtObservacion.Text = txtObservacion.Text.ToUpper();
            txtObservacion.Select(txtObservacion.Text.Length, 0);
        }

        private void txtProcedencia_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtProcedencia.Text = txtProcedencia.Text.ToUpper();
            txtProcedencia.Select(txtProcedencia.Text.Length, 0);
        }

        private void txtEspecifica_TextChanged(object sender, EventArgs e)
        {
            GeneraQR();
            txtEspecifica.Text = txtEspecifica.Text.ToUpper();
            txtEspecifica.Select(txtEspecifica.Text.Length, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {            
            if (cbBusqueda.SelectedItem!=null)
            {
                if (cbBusqueda.SelectedItem.Equals("AUXILIAR"))
                {
                    dgv.DataSource = OCPG.Busqueda("%" + txtBuscaroficinas.Text + "%", "", "", "");
                }
                if (cbBusqueda.SelectedItem.Equals("COD_ENTIDAD"))
                {
                    dgv.DataSource = OCPG.Busqueda("", "%" + txtBuscaroficinas.Text + "%", "", "");
                }
                if (cbBusqueda.SelectedItem.Equals("DESCRIPCION"))
                {
                    dgv.DataSource = OCPG.Busqueda("", "", "%" + txtBuscaroficinas.Text + "%", "");
                }
                if (cbBusqueda.SelectedItem.Equals("ESTADO"))
                {
                    dgv.DataSource = OCPG.Busqueda("", "", "", "%" + txtBuscaroficinas.Text + "%");
                }
            }
            else {
                MessageBox.Show("Escoja Por que campo desa buscar en el Combo Box");
                cbBusqueda.Focus();
            }
        }

        private void txtBuscaroficinas_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAuxiliar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gunaButton1_Click(object sender, EventArgs e)
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

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
