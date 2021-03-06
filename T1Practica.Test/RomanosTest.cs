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

            var result = romano.numRomano(-1);
 
            Assert.AreEqual("no válido", result);
        }
        [Test]
        public void Caso02()
        {
            var romano = new Romanos();

            var result = romano.numRomano(1001);

            Assert.AreEqual("no válido", result);
        }
        [Test]
        public void Caso03()
        {
            var romano = new Romanos();

            var result = romano.numRomano(10);

            Assert.AreEqual("X", result);
        }
        [Test]
        public void Caso04()
        {
            var romano = new Romanos();

            var result = romano.numRomano(12);

            Assert.AreEqual("XII", result);
        }
        [Test]
        public void Caso05()
        {
            var romano = new Romanos();

            var result = romano.numRomano(20);

            Assert.AreEqual("XX", result);
        }
        [Test]
        public void Caso06()
        {
            var romano = new Romanos();

            var result = romano.numRomano(50);

            Assert.AreEqual("L", result);
        }
        [Test]
        public void Caso07()
        {
            var romano = new Romanos();

            var result = romano.numRomano(51);

            Assert.AreEqual("LI", result);
        }
        [Test]
        public void Caso08()
        {
            var romano = new Romanos();

            var result = romano.numRomano(80);

            Assert.AreEqual("LXXX", result);
        }
        [Test]
        public void Caso09()
        {
            var romano = new Romanos();

            var result = romano.numRomano(80);

            Assert.AreEqual("LXXX", result);
        }
        [Test]
        public void Caso10()
        {
            var romano = new Romanos();

            var result = romano.numRomano(80);

            Assert.AreEqual("LXXX", result);
        }
        [Test]
        public void Caso11()
        {
            var romano = new Romanos();

            var result = romano.numRomano(500);

            Assert.AreEqual("D", result);
        }
        [Test]
        public void Caso12()
        {
            var romano = new Romanos();

            var result = romano.numRomano(100);

            Assert.AreEqual("C", result);
        }
        [Test]
        public void Caso13()
        {
            var romano = new Romanos();

            var result = romano.numRomano(200);

            Assert.AreEqual("CC", result);
        }
        [Test]
        public void Caso14()
        {
            var romano = new Romanos();

            var result = romano.numRomano(250);

            Assert.AreEqual("CCL", result);
        }
    }
}
