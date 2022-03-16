using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public class Imc
    {
        private float peso;
        private float altura;
        
        public float Altura
        {
            get => altura;
            set => altura = value; 
        }

        public float Peso
        {
            get => peso;
            set => peso = value;
        }

        public float calculadoraImc() 
        {
            float imc = peso / (altura * altura);
            return imc;
        }    
    }
}
