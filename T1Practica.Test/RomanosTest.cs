using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using T1Practica.clases;

namespace T1Practica.Test
{
    public class RomanosTest
    {
        [Test]
        public void Caso01()
        {
            var romano = new Romanos();

            var result = romano.numRomano(1);
 
            Assert.AreEqual(0, result);
        }
    }
}
