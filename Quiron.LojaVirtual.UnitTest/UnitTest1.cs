using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void Take()
        {
            //O operador Take é usado para selecionar os primeiros n objetos de uma coleção
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var resultados = from num in numeros.Take(5) select num;

            int[] teste = { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(resultados.ToArray(), teste);
        }

        [TestMethod]
        public void Skip()
        {
            //operador skip ingnora os primeiros n objetos de uma coleção

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 3, 4, 5 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }
    }
}
