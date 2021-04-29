using System;
using DTO;
using CTR;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace BCPE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoCTAXCLI dto = new DtoCTAXCLI()
                {
                    IDCCLIENTE = textBox1.Text
                };
                ClassResultV cr = new CtrCTAXCLI().Usp_GetAllCuentas(dto);
                if (!cr.HuboError)
                {
                    decimal tc = decimal.Parse(ConfigurationManager.AppSettings["TC"].ToString());
                    List<DtoCTAXCLI> list = cr.List.Cast<DtoCTAXCLI>().ToList();
                    list.ForEach(x => x.DEUDATOTALCUENTA /= (x.MONEDA == "PEN" ? tc : 1));
                    gvCuentas.DataSource = list;
                    gvCuentas.Refresh();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
