using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoCTAXCLI : DaoB
    {
        public ClassResultV Usp_GetAllCuentas(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            DtoCTAXCLI dto = (DtoCTAXCLI)dtoBase;
            List<SqlParameter> pr = new List<SqlParameter>
            {
                new SqlParameter("@IDCCLINETE", dto.IDCCLIENTE)
            };
            try
            {
                cr.List = new List<DtoB>();
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_GetAllCuentas", pr.ToArray());
                while (reader.Read())
                {
                    dto = new DtoCTAXCLI
                    {
                        NBRCLIENTE = GetValue("NBRCLIENTE", reader).Value_String,
                        CODCUENTACOBRANZA = GetValue("CODCUENTACOBRANZA", reader).Value_String,
                        DEUDATOTALCUENTA = GetValue("DEUDATOTALCUENTA", reader).Value_Decimal,
                        MONEDA = GetValue("MONEDA", reader).Value_String,
                        RAZONNOPAGO = GetValue("RAZONNOPAGO", reader).Value_String,
                        FECHAMODIFICACION = GetValue("FECHAMODIFICACION", reader).Value_DateTime,
                        USUARIOMODIFICACION = GetValue("USUARIOMODIFICACION", reader).Value_String
                    };
                    cr.List.Add(dto);
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Usp_GetAllCuentas";
            }
            objCn.Close();
            return cr;
        }
        
        public ClassResultV Usp_UpdateRNP(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            DtoCTAXCLI dto = (DtoCTAXCLI)dtoBase;
            List<SqlParameter> pr = new List<SqlParameter>
            {
                new SqlParameter("@IDCCLINETE", dto.IDCCLIENTE),
                new SqlParameter("@RAZONNOPAGO", dto.RAZONNOPAGO),
                new SqlParameter("@FECHAMODIFICACION", dto.FECHAMODIFICACION),
                new SqlParameter("@USUARIOMODIFICACION", dto.USUARIOMODIFICACION)
            };
            try
            {
                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_UpdateRNP", pr.ToArray());
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar Usp_UpdateRNP";
            }
            objCn.Close();
            return cr;
        }
    }
}
