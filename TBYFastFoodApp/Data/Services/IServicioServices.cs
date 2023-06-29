using System.Collections.Generic;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Services
{
    public interface IServicioService
    {
        List<Servicio> ObtenerServicios();
        Servicio ObtenerServicio(int id);
        void AgregarServicio(Servicio servicio);
        void ActualizarServicio(int id, Servicio servicio);
        void EliminarServicio(int id);
    }
}
