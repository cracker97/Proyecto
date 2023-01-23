using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.CodeDom;

namespace CiclosFor// name of space of work
{
    class Program// main class
    {
        static void Main(string[] args)// entry point, punto de entrada al sistema
        {
            //    int limite = 10;
            //    int contador = 0;

            Console.WriteLine("sistemas de informacion de la empresa");
            //int[,,] CuboDatos = new int[100, limite, limite];

            //for(int fila=0; fila < 100;)
            //{
            //    for(int columna=0;  columna < limite;)
            //    {

            //        for(int pila=0; pila < limite;)
            //        {
            //            contador = contador + 1;

            //            CuboDatos[fila, columna, pila] = contador;
            //            Console.Write("[  " + CuboDatos[fila, columna, pila] + "   ]");

            //            pila++;


            //        }
            //        Console.WriteLine();
            //        columna++;
            //    }
            //    Console.WriteLine();
            //    fila++;

            //    System.Threading.Thread.Sleep(2000);
            //    Console.Clear();
            //}
            //sistemas de informacion de la empresa;
            //sistema de infomacion de la organizacion&& asi es como lo debemos de haver
            int limite = 10;
            int contador = 0;
            Int32[,,] CuboDatos1 = new Int32[limite, limite, limite];
            Int32[,,] CubosDatos2 = new Int32[limite, limite, limite];
            Int32[,,] cubosDatos3 = new Int32[limite, limite, limite];
            Int32[,,] cubosDatos4 = new Int32[limite, limite, limite];
            Int32[,,] CuboDatos5 = new Int32[limite, limite, limite];
            //Recorrer cuboDatos numero1;
            for (int fila1 = 0; fila1 < limite;)
            {
                for (int columna = 0; columna < limite;)
                {
                    for (int pila = 0; pila < limite;)
                    {
                        CuboDatos1[fila1, columna, pila] = 1;
                        Console.Write(" ["+CuboDatos1[fila1, columna, pila]+"]");
                        pila++;
                    }
                    Console.WriteLine();
                    columna++;
                }
                Console.WriteLine();
                fila1++;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine();
            //recorrer cuboDatosnumero2;
            for(int fila2=0; fila2 < limite;)
            {
                for(int columna2=0; columna2 < limite;)
                {
                    for(int pila2=0; pila2 < limite;)
                    {
                        CubosDatos2[fila2, columna2, pila2] = 2;
                        Console.Write(" ["+CubosDatos2[fila2, columna2, pila2]+"]");
                        pila2++;
                    }
                    Console.WriteLine();
                    columna2++;
                }
                Console.WriteLine();
                fila2++;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            //reocrrer CuboDatos numero3
            for(int fila3=0; fila3 < limite;)
            {
                for(int columna3=0; columna3 < limite;)
                {
                    for(int pila3=0; pila3 < limite;)
                    {
                        cubosDatos3[fila3, columna3, pila3] = 3;
                        Console.Write(" [" + cubosDatos3[fila3, columna3, pila3] + "]");
                        pila3++;
                    }
                    Console.WriteLine();
                    columna3++;
                }
                Console.WriteLine();
                fila3++;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            //Reocorrer cuboDatos4
            for(int fila4=0; fila4 < limite;)
            {
                for(int columna4=0; columna4 < limite;)
                {
                    for(int pila4=0; pila4 < limite;)
                    {
                        cubosDatos4[fila4, columna4, pila4] = 4;
                        Console.Write(" ["+cubosDatos4[fila4, columna4, pila4]+"]");
                        pila4++;
                    }
                    Console.WriteLine();
                    columna4++;
                }
                Console.WriteLine();
                fila4++;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            //Recorrer cuboDatos5
            for(int fila5=0; fila5 < limite;)
            {
                for(int columna5=0; columna5 < limite;)
                {
                    for(int pila5=0; pila5 < limite;)
                    {
                        CuboDatos5[fila5, columna5, pila5] = 5;
                        Console.Write(" ["+CuboDatos5[fila5, columna5, pila5]+"]");
                        pila5++;
                    }
                    Console.WriteLine();
                    columna5++;
                }
                Console.WriteLine();
                fila5++;
                System.Threading.Thread.Sleep(1000);// esperar un segundo
                Console.Clear();
            }
            //Suma de los 5 cubos de datos
            // declaracion del cubo matriz de datos de dalida
            System.Int32[,,] CuboDatosSalida = new Int32[limite,limite,limite];
            try// try to execute this code, 
            {
                for (int Filasuma = 0; Filasuma < limite;)
                {
                    for (int columnasuma = 0; columnasuma < limite;)
                    {
                        for (int pilasuma = 0; pilasuma < limite;)
                        {
                          CuboDatosSalida[Filasuma, columnasuma, pilasuma] = CuboDatos1[Filasuma, columnasuma, pilasuma] + CubosDatos2[Filasuma, columnasuma, pilasuma] + cubosDatos3[Filasuma, columnasuma, pilasuma] + cubosDatos4[Filasuma, columnasuma, pilasuma] + CuboDatos5[Filasuma, columnasuma, pilasuma];
                            Console.Write(" [" + CuboDatosSalida[Filasuma, columnasuma, pilasuma] + "]]");
                            pilasuma++;
                        }
                        Console.WriteLine();
                        columnasuma++;
                    }
                    Console.WriteLine();
                    Filasuma++;
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }catch(Exception exceptionEx) // if occurs an error, launch this general exception
            {
                Console.WriteLine("no se pudo ejecutar el procedimiento seleccionado,  puede deberse a un array out index, array fuera del indice");
            }
            Console.ReadLine();
        }
    }
}
