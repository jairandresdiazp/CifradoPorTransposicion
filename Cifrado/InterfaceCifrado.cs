using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cifrado
{
    /// <summary>
    /// Interfaz que crea metodos de cifrado
    /// </summary>
    interface InterfaceCifrado
    {
        /// <summary>
        /// Cifra un texto basado en una llave o metodo
        /// </summary>
        /// <param name="Input">parametro de entrada texto sin cifrar</param>
        /// <returns>texto cifrado</returns>
        string Cifrar(string Input);
        /// <summary>
        /// Descifra un texto basado en una llave o metodo
        /// </summary>
        /// <param name="Input">parametro de entrada texto cifrado</param>
        /// <returns>texto descifrado</returns>
        string Descifrar(string Input);
        /// <summary>
        /// Cifra un texto basado en una llave o metodo
        /// </summary>
        /// <returns>texto cifrado</returns>
        string Cifrar();
        /// <summary>
        /// Descifra un texto basado en una llave o metodo
        /// </summary>
        /// <returns>texto descifrado</returns>
        string Descifrar();
        /// <summary>
        /// Actualiza la llave de cifrado
        /// </summary>
        /// <param name="Key">nueva llave de cifrado</param>
        void Getkey(string Key);
        /// <summary>
        /// Actualiza el input de cada metodo
        /// </summary>
        /// <param name="Input">nuevo input para cada metodo</param>
        void GetInput(string Input);

    }
}
