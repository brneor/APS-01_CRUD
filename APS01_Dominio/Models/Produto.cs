using System;
using System.Collections.Generic;
using System.Text;

namespace APS01_Dominio.Models
{
    public class Produto : Model
    {
        public String Descricao { get; set; }
        public double Estoque { get; set; }
    }
}
