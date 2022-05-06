using System;
using System.ComponentModel.DataAnnotations;
namespace MusicZone1.Models
{
    public  class Banda
    {
        public  string NomeBanda { get; set; }   

        public  int NumerodeElementos { get; set; }  

        public  string Genero { get; set; }  
        
        public  bool BandaTop { get; set; }    
    }
}
