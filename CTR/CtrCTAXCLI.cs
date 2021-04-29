using DAO;
using DTO;

namespace CTR
{
    public class CtrCTAXCLI
    {
        public ClassResultV Usp_GetAllCuentas(DtoB dtoBase) => new DaoCTAXCLI().Usp_GetAllCuentas(dtoBase);
        public ClassResultV Usp_UpdateRNP(DtoB dtoBase) => new DaoCTAXCLI().Usp_UpdateRNP(dtoBase);
    }
}
