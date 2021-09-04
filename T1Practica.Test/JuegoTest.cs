using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using T1Practica.clases;

namespace T1Practica.Test
{
    public class JuegoTest
    {

        [Test]
        public void Caso01()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PIEDRA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void Caso02()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PAPEL.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Ganó Genesis", result);
        }
        [Test]
        public void Caso03()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.TIJERA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Perdió Genesis", result);
        }
        [Test]
        public void Caso04()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PIEDRA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.TIJERA.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso05()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PIEDRA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PAPEL.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso06()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PIEDRA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void Caso07()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.TIJERA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PAPEL.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso08()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PAPEL.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PAPEL.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso09()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PAPEL.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.TIJERA.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso10()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.TIJERA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PAPEL.ToString() });
            Assert.AreEqual("Ganó Rubi", result);

        }
        [Test]
        public void Caso11()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PAPEL.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Ganó Genesis", result);
        }
        [Test]
        public void Caso12()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.TIJERA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Perdió Genesis", result);
        }
        [Test]
        public void Caso13()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PIEDRA.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.TIJERA.ToString() });
            Assert.AreEqual("Ganó Rubi", result);
        }
        [Test]
        public void Caso14()
        {
            var juego = new Juego();
            var result = juego.Jugar(new Jugador { Nombre = "Genesis", Eleccion = Tipos.PAPEL.ToString() }, new Jugador { Nombre = "Rubi", Eleccion = Tipos.PIEDRA.ToString() });
            Assert.AreEqual("Ganó Genesis", result);
        }
    }
}
