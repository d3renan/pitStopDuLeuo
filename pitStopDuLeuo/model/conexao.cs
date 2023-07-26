using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pitStopDuLeuo.model
{
    internal class conexao
    {

        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renan.lrocha\source\repos\pitStopDuLeuo\pitStopDuLeuo\model\mercadinho.mdf;Integrated Security=True";
        }
    }
}
