using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoLibreria.Services
{
    public interface IServicioLista
    {
        Task<IEnumerable<SelectListItem>> GetListaAutores();
        Task<IEnumerable<SelectListItem>> GetListaCategorias();
    }
}
