using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NikeContext _context;

        public UnitOfWork(NikeContext context)
        {
            _context = context;
        }
        private ICiudad _ciudades;
        private ICliente _clientes;
        private IDepartamento _departamentos;
        private IDireccion _direcciones;
        private IFormaPago _formaPagos;
        private IOrdenPedido _ordenPedidos;
        private IOrden _ordens;
        private IPago _pagos;
        private IPais _paises;
        private IPedido _pedidos;
        private IProducto _productos;
        private IRol _rols;
        private ITipoProducto _tipoProductos;
        private IUser _users;

        public ICiudad Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ciudades;
            }
        }
        public ICliente Clientes
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _clientes;
            }
        }
        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _departamentos;
            }
        }
        public IDireccion Direcciones
        {
            get
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _direcciones;
            }
        }
        public IFormaPago FormaPagos
        {
            get
            {
                if (_formaPagos == null)
                {
                    _formaPagos = new FormaPagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _formaPagos;
            }
        }
        public IOrdenPedido OrdenPedidos
        {
            get
            {
                if (_ordenPedidos == null)
                {
                    _ordenPedidos = new OrdenPedidoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ordenPedidos;
            }
        }
        public IOrden Ordenes
        {
            get
            {
                if (_ordens == null)
                {
                    _ordens = new OrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ordens;
            }
        }
        public IPago Pagos
        {
            get
            {
                if (_pagos == null)
                {
                    _pagos = new PagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _pagos;
            }
        }
        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _paises;
            }
        }
        public IPedido Pedidos
        {
            get
            {
                if (_pedidos == null)
                {
                    _pedidos = new PedidoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _pedidos;
            }
        }
        public IProducto Productos
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new ProductoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _productos;
            }
        }
        public IRol Rols
        {
            get
            {
                if (_rols == null)
                {
                    _rols = new RolRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _rols;
            }
        }
        public ITipoProducto TipoProductos
        {
            get
            {
                if (_tipoProductos == null)
                {
                    _tipoProductos = new TipoProductoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoProductos;
            }
        }
        public IUser Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _users;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public Task<int> SaveAsync() // 2611
        {
            return _context.SaveChangesAsync();
        }
    }
}