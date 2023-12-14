using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class OrdenPedidoDto
    {
        public int Id { get; set; }
        public int IdOrdenFk { get; set; }

        public int IdPedidoFk { get; set; }
    }
}