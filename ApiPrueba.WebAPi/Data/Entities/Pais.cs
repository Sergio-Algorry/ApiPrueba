using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.WebAPi.Data.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        public string CodPais { get; set; }
        public string NomPais { get; set; }
    }
}
