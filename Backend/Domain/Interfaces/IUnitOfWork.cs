using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork 
    {
        ICiudad Ciudades {get;}
        ICliente Clientes {get;}
        IDepartamento Departamentos {get;}
        IDireccion Direcciones {get;}
        IFormaPago FormaPagos {get;}
        IOrden Ordenes {get;}
        IOrdenPedido OrdenPedidos {get;}
        IPago Pagos {get;}
        IPais Paises {get;}
        IPedido Pedidos {get;}
        IProducto Productos {get;}
        ITipoProducto TipoProductos {get;}
        IUser Users {get;}

        Task<int> SaveAsync(); 
    }
}