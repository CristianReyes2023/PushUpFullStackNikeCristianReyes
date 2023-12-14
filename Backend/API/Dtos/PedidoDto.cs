using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PedidoDto
    {
        public int Id { get; set; }

        public int IdPagoFk { get; set; }

        public int IdClienteFk { get; set; }

    }
}