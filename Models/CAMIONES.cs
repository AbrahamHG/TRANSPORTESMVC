//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRANSPORTESMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAMIONES
    {
        public int ID_CAMION { get; set; }
        public string MATRICULA { get; set; }
        public string TIPO_CAMION { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public int CAPACIDAD { get; set; }
        public double KILOMETRAJE { get; set; }
        public string URLFOTO { get; set; }
        public bool DISPONIBILIDAD { get; set; }
    }
}