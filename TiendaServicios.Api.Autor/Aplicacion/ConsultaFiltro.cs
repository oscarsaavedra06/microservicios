using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using TiendaServicios.Api.Autor.Modelo;
using TiendaServicios.Api.Autor.Persistencia;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class ConsultaFiltro
    {
        public class AutorUnico : IRequest<AutorDto>
        {

            public string AutorGuid { get; set; }

        }

        public class Manejador : IRequestHandler<AutorUnico, AutorDto>
        {
            private readonly AutorContext context;
            private readonly IMapper mapper;

            public Manejador(AutorContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<AutorDto> Handle(AutorUnico request, CancellationToken cancellationToken)
            {
                var autor = await context.AutorLibro.FirstOrDefaultAsync(x => x.AutorLibroGuid == request.AutorGuid);
                if (autor == null)
                {
                    throw new Exception("no se encontró el autor");
                }
                var autorDto = mapper.Map<AutorLibro, AutorDto>(autor);
                return autorDto;
            }
        }

    }
}
