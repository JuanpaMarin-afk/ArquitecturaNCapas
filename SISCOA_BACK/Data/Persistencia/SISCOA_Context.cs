using Entities.Models;
using System.Data.Entity;

namespace Data.Data
{
    public class SISCOA_Context : DbContext
    {
        //private static SISCOA_Context _instance = null;
        
        public SISCOA_Context() : base("ARQUITECTURA_N_CAPAS_Context")
        {

        }
        public DbSet<TSISCOA_Control> Controles { get; set; }

        public static SISCOA_Context Create()
        {
            /**if(_instance == null)
            {
                _instance = new SISCOA_Context();
            }
            return _instance;**/
            return new SISCOA_Context();
        }
    }
}
