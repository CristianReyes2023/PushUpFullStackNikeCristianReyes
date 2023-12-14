using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PagoDto
    {
        public int Id { get; set; }
        public DateOnly FechaPago { get; set; }

        public int Total { get; set; }

        public int IdFormaPagoFk { get; set; }
    }
}