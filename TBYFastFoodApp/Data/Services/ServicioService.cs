using System;
using System.Collections.Generic;
using System.Linq;
using TBYFastFoodApp.Data.Context;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Services
{
    public class ServicioService : IServicioService
    {
        private readonly TBYFastFoodDbContext _dbContext;

        public ServicioService(TBYFastFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Servicio> ObtenerServicios()
        {
            return _dbContext.Servicios.ToList();
        }

        public Servicio ObtenerServicio(int id)
        {
            return _dbContext.Servicios.FirstOrDefault(s => s.Id == id);
        }

        public void AgregarServicio(Servicio servicio)
        {
            _dbContext.Servicios.Add(servicio);
            _dbContext.SaveChanges();
        }

        public void ActualizarServicio(int id, Servicio servicio)
        {
            var servicioExistente = _dbContext.Servicios.FirstOrDefault(s => s.Id == id);

            if (servicioExistente == null)
            {
                throw new Exception("El servicio seleccionado no existe.");
            }

            servicioExistente.Nombre = servicio.Nombre;
            servicioExistente.Descripcion = servicio.Descripcion;
            servicioExistente.Precio = servicio.Precio;

            _dbContext.SaveChanges();
        }

        public void EliminarServicio(int id)
        {
            var servicioExistente = _dbContext.Servicios.FirstOrDefault(s => s.Id == id);

            if (servicioExistente != null)
            {
                _dbContext.Servicios.Remove(servicioExistente);
                _dbContext.SaveChanges();
            }
        }
    }
}
