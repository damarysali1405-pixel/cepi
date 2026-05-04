using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamarysAline
{
    internal class Produto
    {
        public string Nome;
        public double Preço;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preço * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preço.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}



