using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasRecordManagementSystem.Utility
{
    public static class ConnectionString
    {

        //private static string cName = "Data Source=.;  Initial Catalog=JoseGuzman;User ID=sa;Password=123";
        //private static string cName = "Data Source=.;Initial Catalog=BDControlEstacionamientos;Integrated Security=True";
        private static string cName = "Data Source=;Initial Catalog=RegistroTareas;Integrated Security=True";  
        public static string CName { get => cName; }
    }
}
