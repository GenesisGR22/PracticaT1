using System;
using System.Collections.Generic;
using System.Text;

namespace T1Practica.clases
{
    public class Juego
    {
        public string Jugar(Jugador jugador1, Jugador jugador2) {

			 
			int jugada1 = eleccionInt(jugador1.Eleccion);
			int jugada2 = 0;
			int Computador = 0;

			string resultado = "";


			
			int x = eleccionInt(jugador2.Eleccion);
			resultado ="Ganó "+ jugador2.Nombre.ToString();

			switch (x)
			{
				case 1:
					if (x == jugada1)
					{
						jugada2 = jugada2 + 0;
						Computador = Computador + 0;
						resultado = "Empate";
					}
					else if (x > jugada1)
					{
						jugada2 = jugada2 + 1;
						resultado ="Ganó " + jugador1.Nombre.ToString();
					}
					else
					{
						Computador = Computador + 1;
						resultado ="Perdió " + jugador1.Nombre.ToString();
					}

					break;
				case 2:
					if (x == jugada1)
					{
						jugada2 = jugada2 + 0;
						Computador = Computador + 0;
						resultado = "Empate";
					}
					else if (x > jugada1)
					{
						jugada2 = jugada2 + 1;
						resultado ="Ganó " + jugador1.Nombre.ToString();
					}
					else
					{
						Computador = Computador + 1;
						resultado ="Perdió " + jugador1.Nombre.ToString();
					}

					break;
				case 3:
					if (x == jugada1)
					{
						jugada2 = jugada2 + 0;
						Computador = Computador + 0;
						resultado ="Empate";
					}
					else if (x > jugada1)
					{
						jugada2 = jugada2 + 1;
						resultado ="Ganó " + jugador2.Nombre.ToString();
					}
					else
					{
						Computador = Computador + 1;
						resultado ="Perdió " + jugador1.Nombre.ToString();
					}

					break;



			}
			return resultado;

		}


		private int eleccionInt(string valor) {
			int rpta = 0;
            switch (valor)
            {
                case "PIEDRA":
					rpta  =  1;
                    break;

				case "PALE":
					rpta = 2;
					break;
				case "TIJERA":
					rpta = 3;
					break;
				default: rpta = 0; break;
			}

			return rpta;
        }
	}
}
