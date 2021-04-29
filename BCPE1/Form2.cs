using DTO;
using CTR;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace BCPE1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRAZONNP.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese una razon para el no pago");
                    return;
                }
                DtoCTAXCLI dto = new DtoCTAXCLI()
                {
                    IDCCLIENTE = txtIDCCLIENTE.Text,
                    RAZONNOPAGO = txtRAZONNP.Text,
                    FECHAMODIFICACION = DateTime.Now,
                    USUARIOMODIFICACION = "TEST"
                };
                ClassResultV cv = new CtrCTAXCLI().Usp_UpdateRNP(dto);
                if (!cv.HuboError)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            decimal tc = decimal.Parse(ConfigurationManager.AppSettings["TC"].ToString());
            DtoCTAXCLI dto = new DtoCTAXCLI()
            {
                IDCCLIENTE = "42098338",
                NBRCLIENTE = "MARIA CALDERON VALDIVIA",
                CODCUENTACOBRANZA = "1004883799277399",
                DEUDATOTALCUENTA = 1290.45M,
                MONEDA = "SOLES"
            };
            dto.DEUDATOTALCUENTA /= dto.MONEDA == "SOLES" ? tc : 1;
            txtIDCCLIENTE.Text = dto.IDCCLIENTE;
            txtNOMBRECLIENTE.Text = dto.NBRCLIENTE;
            txtCODIGOCUENTA.Text = dto.CODCUENTACOBRANZA;
            txtDEUDATOTAL.Text = dto.DEUDATOTALCUENTA.ToString();
            cmbMONEDA.SelectedText = dto.MONEDA;
        }
    }
}
