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
            bool terminado = false;

            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");

            do
            {
                // Turno al jugador 1
                PreguntarPosicion(1);

                // Dibujar la casilla que eligió el jugador 1
                DibujarTablero();

                //Comprobar si gana la partida el jugador1
                terminado = ComprobarGanador();

                if(terminado == true)
                {
                    Console.WriteLine("El jugador 1 ha ganado");
                } 
                else
                {
                    terminado = ComprobarEmpate();
                    if(terminado == true)
                    {
                        Console.WriteLine("Esto es un empate");
                    }

                    // Si jugador 1 no ganó, ni hubo empate, entonces es turno del jugador 2
                    else
                    {
                        // Turno del jugador 2
                        PreguntarPosicion(2);

                        // Dibujar la casilla que eligió el jugador 2
                        DibujarTablero();

                        //Comprobar si gana la partida el jugador2
                        terminado = ComprobarGanador();

                        if(terminado == true)
                        {
                            Console.WriteLine("El jugador 2 ha ganado");
                        }
                    }


                }

            } while (terminado == false); // Repetir hasta 3 en linea o empate
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
                Console.WriteLine("Turno del jugador: " + jugador);

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
                {
                    Console.WriteLine("Casilla Ocupada");
                }

            } while (tablero[fila - 1, columna - 1] != 0);

            // Si todo es correcto se le asigna al jugador correspondiente
            tablero[fila - 1, columna - 1] = jugador;
        }

        // Devuelve "True" si hay 3 en linea
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;
            bool ticTacToe = false;

            // Si en alguna de las filas todas las casillas son iguales y no están vacias
            for(fila = 0; fila < 3; fila++)
            {
                if ( (tablero[fila, 0] == tablero[fila, 1]) && (tablero[fila, 0] == tablero[fila, 2]) && (tablero[fila, 0] != 0) ){
                    ticTacToe = true;
                }
            }

            // Si en alguna de las columnas todas las casillas son iguales y no están vacias
            for (columna = 0; columna < 3; columna++)
            {
                if ( (tablero[0, columna] == tablero[1, columna]) && (tablero[0, columna] == tablero[2, columna]) && (tablero[0, columna] != 0 ))
                {
                    ticTacToe = true;
                }
            }

            // Si en alguna diagonal todas las casillas son iguales y no están vacias
            if ((tablero[0, 0] == tablero[1, 1]) && (tablero[0, 0] == tablero[2, 2]) && (tablero[0, 0] != 0))
            {
                ticTacToe = true;
            }

            if ((tablero[0, 2] == tablero[1, 1]) && (tablero[0, 2] == tablero[2, 0]) && (tablero[0, 2] != 0))
            {
                ticTacToe = true;
            }

            return ticTacToe;
        }

        // Devuelve "True" si hay empate
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila = 0;
            int columna = 0;

            for(fila = 0; fila < 3; fila++)
            {
                for(columna = 0; columna < 3; columna++)
                {
                    if (tablero[fila, columna] == 0)
                    {
                        hayEspacio = true;
                    }
                }
            }

            // Se regresa una negación para que el empate no se cumpla en Main
            return !hayEspacio;
        }


    }
}
