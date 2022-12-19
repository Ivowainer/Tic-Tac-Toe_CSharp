using System;
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
        static void PreguntarPosicion(int jugador) //1 = jugador1 ; 2 = jugador2
        {
            int fila, columna;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Turno del jugador: { 0 }", jugador);

                // Pedir número de fila
                do
                {
                    Console.Write("Selecciona la fila (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());
                } while ((fila < 1) || (fila > 3));

                // Pedimos el número de columna 
                do
                {
                    Console.Write("Selecciona la columna (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());

                } while ((columna < 1) || (columna > 3));

                if (tablero[fila - 1, columna - 1] != 0)
                    Console.WriteLine("Casilla Ocupada");

            } while (tablero[fila - 1, columna - 1] != 0);

            // Si todo es correcto se le asigna al jugador correspondiente
            tablero[fila - 1, columna - 1] = jugador;
        }

        // Devuelve "True" si hay 3 en linea
        static bool ComprobarGanador()
        {

        }
    }
}
