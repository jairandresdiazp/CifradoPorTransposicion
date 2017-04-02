using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cifrado
{
    /// <summary>
    /// clase qeu hereda la interfaz InterfaceCifrado que contiene el funcionmiento basico de un metodo de cifrado
    /// </summary>
    public class Transposicion : InterfaceCifrado
    {
        /// <summary>
        /// corresponde ala llave de cifrado
        /// </summary>
        private string key;
        /// <summary>
        /// corresponde a la longitud de input a crifrar o descifrar
        /// </summary>
        private int length;
        /// <summary>
        /// corresponde al input que se cifra o descifra
        /// </summary>
        private string input;
        /// <summary>
        /// corresponde a las dimenciones de la matriz a transponer
        /// </summary>
        private int dimenciones = 0;
        /// <summary>
        /// corresponde a la matriz que almacena los datos
        /// </summary>
        private DataTable matriz= new DataTable ("Matriz");

        /// <summary>
        /// propiedad que permite modificar o recuperar la longitud del input a cifrar o descifrar 
        /// </summary>
        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }
        /// <summary>
        /// propiedad que permite modificar o recuperar el input a cifrar o descifrar 
        /// </summary>
        public string Input
        {
            get
            {
                return input;
            }

            set
            {
                input = value;
            }
        }
        /// <summary>
        /// propiedad que permite modificar o recuperar la clave para cifrar o descifrar 
        /// </summary>
        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }
        /// <summary>
        /// propiedad que permite modificar o recuperar la matriz a trasponer 
        /// </summary>
        public DataTable Matriz
        {
            get
            {
                return matriz;
            }

            set
            {
                matriz = value;
            }
        }
        /// <summary>
        /// permite calcular las dimenciones de una matriz cuadrada para un input
        /// </summary>
        /// <param name="Input">cadena de texto plano</param>
        /// <returns>la dimencion de la matriz cuadrada que puede almacenar el input</returns>
        public int Dimenciones(string Input)
        {
            try
            {
                //se remueven los espacios al inicio y final de la cadena
                Input = Input.Trim();
                //se remueven todos los espacios de la cadena
                Input = Input.Replace(" ", "");
                //se alacenna la longitud de la cadena sin espacios
                int Length = Input.Length;
                //se repite el ciclo tantas veces como la longitud de la cadena para poder crear matrices dinamicas
                for (int i = 0; i < Length; i++)
                {
                    //se repite el ciclo tantas veces como la longitud de la cadena para poder crear matrices dinamicas
                    for (int j = 0; j < Length; j++)
                    {
                        //se verifica si filas por columnas corresponde a la longitud de la matriz 
                        if (j * j == Length)
                        {
                            //se actualizan las dimenciones para la matriz cuadrada
                            dimenciones = j;
                            //se actualiza el incice a la longitu para forzar el fin del ciclo
                            j = Length;
                        }
                    }
                    //si las dimenciones son 0 se debe agragar un carcater de relleno =
                    if (dimenciones <= 0)
                    {
                        //se actualiza el input con el caracter de relleno
                        Input = Input + "=";
                        //se actualiza la longitud de la cadena 
                        Length = Input.Length;
                    }
                    //se forza el cierre del ciclo por que ya se tiene una dimencion valida
                    else
                    {
                        i = Length;
                    }
                }
                //si las dimenciones validas se crea la matriz
                if (dimenciones > 0)
                {
                    //se agregan las filas y columnas respectivamente
                    for (int i = 0; i < dimenciones; i++)
                    {
                        Matriz.Rows.Add();
                        Matriz.Columns.Add("" + i);
                    }
                    //se inicializa un indice para la matriz y la cadena
                    int index = 0;
                    //se recorren las filas
                    for (int f = 0; f < dimenciones; f++)
                    {
                        //se recorren las columnas
                        for (int c = 0; c < dimenciones; c++)
                        {
                            //se recupera el valor de la cadena en la pocicion del indice
                            string value = Input.Substring(index, 1);
                            //se almacena la variable en la pocicion icnidcada 
                            Matriz.Rows[f][c] = value;
                            //se incrementa el indice
                            index++;
                        }
                    }
                }
                //se actualiza la longitud del input
                this.Length = Length;
                //se actualiza el input
                this.Input = Input;
                //se retornan las dimenciones de la matriz
                return dimenciones;
            }
            catch (Exception)
            {
            }
            return 0;           
        }

        /// <summary>
        /// Cifra un texto basado en una llave o metodo
        /// </summary>
        /// <param name="Input">parametro de entrada texto sin cifrar</param>
        /// <returns>texto cifrado</returns>
        public string Cifrar(string Input)
        {
            throw new NotImplementedException("No se permite redefinir el texto luego de haber calculado las ddimenciones para este metodo de cifrado");
        }

        /// <summary>
        /// Cifra un texto basado en una llave o metodo
        /// </summary>
        /// <returns>texto cifrado</returns>
        public string Cifrar()
        {
            try
            {
                //objeto que almacena la cadena cifrada
                string OutPut = null;
                //se pone en una matriz toda la cadena 
                char[] Char = Key.ToString().ToCharArray();
                //se recorren las filas
                for (int c = 0; c < dimenciones; c++)
                {
                    //se almacena la columna que se va leer
                    int column = int.Parse(Char[c].ToString());
                    //se recorren las co0lumnas
                    for (int f = 0; f < dimenciones; f++)
                    {
                        //se alamcena el caracter de la matriz correspondiente con la posicion
                        OutPut = OutPut + Matriz.Rows[f][column].ToString();
                    }
                }
                //se retorna la cadena cifrada
                return OutPut;
            }
            catch (Exception)
            {
            }
            return null;
        }

        /// <summary>
        /// Descifra un texto basado en una llave o metodo
        /// </summary>
        /// <param name="Input">parametro de entrada texto cifrado</param>
        /// <returns>texto descifrado</returns>
        public string Descifrar(string Input)
        {
            throw new NotImplementedException("Este metodo no esta implementado");
        }

        /// <summary>
        /// Descifra un texto basado en una llave o metodo
        /// </summary>
        /// <returns>texto descifrado</returns>
        public string Descifrar()
        {
            throw new NotImplementedException("Este metodo no esta implementado");
        }

        /// <summary>
        /// Actualiza la llave de cifrado
        /// </summary>
        /// <param name="Key">nueva llave de cifrado</param>
        public void Getkey(string Key)
        {
            this.Key = Key;
        }

        /// <summary>
        /// Actualiza el input de cada metodo
        /// </summary>
        /// <param name="Input">nuevo input para cada metodo</param>
        public void GetInput(string Input)
        {
            this.Input = Input;
        }
    }
}
