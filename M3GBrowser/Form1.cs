using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3GBrowser
{
    public partial class frmBrowser : Form
    {
        List<string> Historial = new List<string>();
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Navegar.GoBack();
        }

        private void btnAlante_Click(object sender, EventArgs e)
        {
            Navegar.GoForward();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Navegar.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Navegar.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string cDireccion = txtDireccion.Text;
            if (cDireccion != "")
            {
                Navegar.Navigate(txtDireccion.Text);
            }

           
        }

        private void Navegar_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            Navegar.GoHome();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial.Add(Navegar.Url.ToString());
            AddHistorial();
        }
        private void AddHistorial()
        {
            foreach (string direcciones in Historial)
            {
                cboHistorial.Items.Add(direcciones);
            }
        }

        private void btnItla_Click(object sender, EventArgs e)
        {
            string cDireccion = "https://plataformavirtual.itla.edu.do/login/index.php";
            txtDireccion.Text = cDireccion;
            Navegar.Navigate(cDireccion);
           
        }

        private void btnOrbi_Click(object sender, EventArgs e)
        {
            string cDireccion = "https://orbi.edu.do/orb";
            txtDireccion.Text = cDireccion;
            Navegar.Navigate(cDireccion);
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            string cDireccion = "https://www.office.com/";
            txtDireccion.Text = cDireccion;
            Navegar.Navigate(cDireccion);
            
        }

        private void cboHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cDireccion = cboHistorial.SelectedItem.ToString();
            txtDireccion.Text = cDireccion;
            Navegar.Navigate(cDireccion);
        }
    }
}
