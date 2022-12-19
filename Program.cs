﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        // Creamos un tablero(int bidimensional) bidimensional para el tablero del juego
        static int[,] tablero = new int[3, 3]; // 3 filas - 3 columnas

        // Creamos un array para los simbolos del tablero: Espacio en blanco, jug.1, jug.2
        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");
        }

        static void DibujarTablero()
        {
            //Variables del conteo del ciclo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); //Espacio en blanco al inicio de la terminal
            Console.WriteLine("-------------");
            for(fila = 0; fila < 3; fila++)
            {
                Console.Write("|");
                for(columna = 0; columna < 3; columna++)
                {
                    Console.Write(" {0} |", simbolo[tablero[fila, columna]]);
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        // Preguntar donde escribir y dibuja en el tablero
        static void PreguntarPosicion(int jugador)
        {

        }
    }
}