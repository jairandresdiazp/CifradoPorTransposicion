using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cifrado;

namespace CifradoPorTransposicion
{
    /// <summary>
    /// fomulario que permite cifrar datos por el metodo de transposicion
    /// </summary>
    public partial class CifradoTransposicion : Form
    {
        /// <summary>
        /// Objeto de tipo Cifrado.Transposicion 
        /// </summary>
        Transposicion Transposicion = new Transposicion();
        /// <summary>
        /// Contiene el texto a cifrar o descifrar
        /// </summary>
        string Input = null;
        /// <summary>
        /// Dimenciones de la matriz a trasnponer
        /// </summary>
        int Dimenciones = 0;
        /// <summary>
        /// Inicializacion del formulario
        /// </summary>
        public CifradoTransposicion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// evento clic del boton cifrar 
        /// </summary>
        /// <param name="sender">objeto que envia la peticion</param>
        /// <param name="e">argumentos del objeto</param>
        private void btn_cifrar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida que se aya ingresado una clave y que su longitud sea igual a las dimanciones de la matriz
                if (txt_key.Text != "" && txt_key.Text.Length == Dimenciones)
                {
                    //se actualiza la llave de cifrado del objeto Transposicion
                    Transposicion.Key = txt_key.Text;
                    //se llama el metodo cifrar del objeto Transposicion y se almacena el resultado para mostrar al usuario
                    txt_OutPut.Text = Transposicion.Cifrar();
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// evento clic del boton calcular 
        /// </summary>
        /// <param name="sender">objeto que envia la peticion</param>
        /// <param name="e">argumentos del objeto</param>
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                //se valida que el texto a cifrar sea diferente a vacio
                if (txt_Input.Text != "")
                {
                    //se almacena el valor a cifrar en la variable Input
                    Input = txt_Input.Text;
                    //se almacenan las dimenciones de la matriz haciendo el llamado del metodo Dimenciones del objeto Transposicion enviando la variable Input
                    Dimenciones = Transposicion.Dimenciones(Input);
                    //se muestra al usuario el label con las dimenciones de la matriz
                    lbl_Dimenciones.Text = "Matriz de " + Dimenciones + " X " + Dimenciones;
                    //al calcular las dimenciones de la matriz se modifica el Input ya que se remueven todos los espacios por lo cual se actualiza el valor de la variable input llamando la propiedad Input del objeto Transposicion 
                    Input = Transposicion.Input;
                    //se habilita el txt de la clave 
                    txt_key.Enabled = true;
                    //se actualiza la maxima cantidad de carcateres del txt de la clave para evitar errores de compilazion al agregar mas caracteres que la dimencion de la matriz
                    txt_key.MaxLength = Dimenciones;
                    //se muestra la matriz generada al usuario
                    dgv_Matriz.DataSource = Transposicion.Matriz;
                    for (int i = 0; i < Dimenciones; i++)
                    {
                        //se actualiza el rotulo de las filas
                        dgv_Matriz.Rows[i].HeaderCell.Value = (i).ToString();
                    }
                    //se refrescan los datos de la grilla que muestra los datos
                    dgv_Matriz.Refresh();
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// evento KeyPress del txt de la clave
        /// </summary>
        /// <param name="sender">objeto que envia la peticion</param>
        /// <param name="e">argumentos del objeto</param>
        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //se valida que los caracteres ingresados correspondan a numeros y a la tecla de borrado
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
                //se valida que los caracteres ingresados no superen la longitud de las dimenciones de la matriz se resta 1 para contar desde cero
                else if (int.Parse(e.KeyChar.ToString()) > Dimenciones - 1)
                {
                    e.Handled = true;
                    return;
                }
                else 
                {
                    //recorre los valores del campo clave
                    for (int i = 0; i < txt_key.Text.Length; i++)
                    {
                        //se valida que los carcateres ingresados no se encuentren repetidos y sean unicos
                        if (txt_key.Text.ToString().Substring(i, 1)==e.KeyChar.ToString())
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
