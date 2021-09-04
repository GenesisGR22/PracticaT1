﻿using NUnit.Framework;
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

            Assert.AreEqual("", result);
        }
    }
}
