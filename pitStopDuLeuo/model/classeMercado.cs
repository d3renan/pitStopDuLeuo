using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitStopDuLeuo.model
{
    internal class classeMercado
    {
        private static int codigo;
        private static string produto;
        private static string marca;
        private static string validade;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Produto { get => produto; set => produto = value; }
        public static string Marca { get => marca; set => marca = value; }
        public static string Validade { get => validade; set => validade = value; }
    }
}
