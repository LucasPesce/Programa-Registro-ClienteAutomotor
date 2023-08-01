using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_2_PARCIAL_I
{
    public partial class frmREGISTRO_SERVICIOS : Form
    {
        public frmREGISTRO_SERVICIOS()
        {
            InitializeComponent();
        }
        // Se carga el estado inicial de los componentes.
        private void frmREGISTRO_SERVICIOS_Load(object sender, EventArgs e)
        {
            // Se agregan los items del combo y se selecciona la opcion predeterminada
            cmbTIPO_ACEITE.Items.Add("Aceite Mineral");
            cmbTIPO_ACEITE.Items.Add("Aceite Semisintético");
            cmbTIPO_ACEITE.Items.Add("Aceite Sintético");
            cmbTIPO_ACEITE.SelectedIndex = 1;

            // Se deja vacio las cajas de texto.
            txtPATENTE.Text = "";
            txtCLIENTE.Text = "";
            txtLITRO_ACEITE.Text = "";

            // Se deja desmarcadas los item opcionales.
            chkFILTRO_ACEITE.Checked = false;
            chkFILTRO_AIRE.Checked = false;
            chkFILTRO_COMBUSTIBLE.Checked = false;

            txtIMPORTE.Text = "";
            txtIMPORTE.ReadOnly = true; // Se impide la edicion de este campo

            btnCALCULAR.Enabled = false;// Se inhabilita el boton calcular.
        }
        //EVENTO CARGAR CAJA DE TEXTO.
        private void txtPATENTE_TextChanged(object sender, EventArgs e)
        {
            // Mientras esta caja no se ecuentro con algun valor, se mantiene DesHabilitado el boton calcular
            if (txtCLIENTE.Text != "" && txtPATENTE.Text != "")
            {
                btnCALCULAR.Enabled = true;
            }
            else
            {
                btnCALCULAR.Enabled = false;
            }
        }

        // IDEM AL ANTERIOR
        private void txtCLIENTE_TextChanged(object sender, EventArgs e)
        {
            if (txtCLIENTE.Text != "" && txtPATENTE.Text != "")
            {
                btnCALCULAR.Enabled = true;
            }
            else
            {
                btnCALCULAR.Enabled = false;
            }
        }
        // EVENTO PARTICULAR DE LA OPCION TOPO DE ACEITE
        private void cmbTIPO_ACEITE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se elige la opcion 3 (ACEITE SINTETICO)
            // queda marcado predeterminadamente el Cambio de fltro de aire y se lo inHABILITA
            if(cmbTIPO_ACEITE.SelectedIndex == 2) 
            {
                chkFILTRO_AIRE.Checked = true;
                chkFILTRO_AIRE.Enabled = false;

            }
            else
            {
                chkFILTRO_AIRE.Enabled = true;
                chkFILTRO_AIRE.Checked = false;

            }
        }
        // EVENTO CAJA DE TEXTO.
        private void txtLITRO_ACEITE_TextChanged(object sender, EventArgs e)
        {
            if (txtCLIENTE.Text != "" && txtPATENTE.Text != "")
            {
                btnCALCULAR.Enabled = true;
            }
            else 
            {
                btnCALCULAR.Enabled = false;
            }
            // CONDICION QUE OBLIGA A QUE EN ESTE CAMPO SE LLENE CON UN VALOR DEL 1 AK 10
            if (!int.TryParse(txtLITRO_ACEITE.Text, out int litros) || litros <= 0 || litros > 10)
            {
                if (litros == 0)
                {
                    txtLITRO_ACEITE.Text = "";
                }
                else
                {
                    MessageBox.Show("Error. Valor no valido. En Litro de Aceite, ingrese un valor entre 1 a 10.");
                    txtLITRO_ACEITE.Text = "";
                }
            }

        }
        //EVENTO BOTON CALCULAR
        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            //VARIABLES
            int L_aceiteMineral = 750;
            int L_aceiteSemisintetico = 1000;
            int L_aceiteSintetico = 2500;
            int filtroAceite = 650;
            int filtroAire = 700;
            int filtroCombustible = 900;
            double TOTAL = 0;

            // Dependiendo del tipo de aceite, se realizara un calculo diferente, segun cada caso.
            switch (cmbTIPO_ACEITE.SelectedIndex)
            {
                case 0: TOTAL = L_aceiteMineral * int.Parse(txtLITRO_ACEITE.Text); break;

                case 1: TOTAL = L_aceiteSemisintetico * int.Parse(txtLITRO_ACEITE.Text); break;

                case 2: TOTAL = (L_aceiteSintetico * int.Parse(txtLITRO_ACEITE.Text)); break;
            }

            //Dependiendo los filstros a cambiar, sera el incremento correspondiente al IMPORTE TOTAL
            if (chkFILTRO_ACEITE.Checked == true)
            {
                TOTAL += filtroAceite;
            }

            if (chkFILTRO_AIRE.Checked == true)
            {
                TOTAL += filtroAire;
            }

            if (chkFILTRO_COMBUSTIBLE.Checked == true)
            {
                TOTAL += filtroCombustible;
            }

            txtIMPORTE.Text = TOTAL.ToString(); // Se muestra el IMPORTE TOTAL

            //Condicion que si se elige el ACEITE SINTETICO y se pide 5 litros o mas
            if (cmbTIPO_ACEITE.SelectedIndex == 2 && int.Parse(txtLITRO_ACEITE.Text) >= 5) 
            {
                //VARIABLES
                int CONTADOR = 0;
                double DESCUENTO;
                double totalConDESCUENTO;

                //Segun el filtro que que se pida, se suma al contador.
                if(chkFILTRO_ACEITE.Checked == true) { CONTADOR++; }
                if (chkFILTRO_AIRE.Checked == true) { CONTADOR++; }
                if (chkFILTRO_COMBUSTIBLE.Checked == true) { CONTADOR++; }

                //Si se pidieron mas de dos filtros se realiza un descuento
                if(CONTADOR >= 2)
                {
                    DESCUENTO = int.Parse(txtIMPORTE.Text) * 0.15;
                    totalConDESCUENTO = int.Parse(txtIMPORTE.Text) - DESCUENTO;

                    MessageBox.Show("Por su compra a conseguido un descuento del 15%, de un monto de $ "+DESCUENTO+
                        ", el importe total es de: $ "+totalConDESCUENTO);
                }

            }
        }

        //BOTON LIMPIAR, que deja todo como el estado inicial
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            txtPATENTE.Text = "";
            txtCLIENTE.Text = "";
            cmbTIPO_ACEITE.SelectedIndex = 1;
            txtLITRO_ACEITE.Text = "";
            chkFILTRO_ACEITE.Checked = false;
            chkFILTRO_AIRE.Checked = false;
            chkFILTRO_COMBUSTIBLE.Checked = false;
            txtIMPORTE.Text = "";
        }

        //BOTON CERRAR VENTANA
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
