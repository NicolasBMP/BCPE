using System;

namespace DTO
{
    public class DtoCTAXCLI : DtoB
    {
        public string IDCCLIENTE { get; set; }
        public string NBRCLIENTE { get; set; }
        public string CODCUENTACOBRANZA { get; set; }
        public decimal DEUDATOTALCUENTA { get; set; }
        public string MONEDA { get; set; }
        public string RAZONNOPAGO { get; set; }
        public DateTime FECHAMODIFICACION { get; set; }
        public string USUARIOMODIFICACION { get; set; }
    }
}
