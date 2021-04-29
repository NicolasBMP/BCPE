using System.Configuration;

namespace DAO
{
    public class Conexion
    {
        public string StrCon { get; set; }
        public string StrConMySQL { get; set; }
        #region Conexion
        public Conexion() {
            StrCon = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        }
        #endregion
    }
}
