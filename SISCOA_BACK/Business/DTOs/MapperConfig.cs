using AutoMapper;
using Entities.Models;

namespace Business.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSISCOA_Control, TSISCOA_Control_DTO>(); //GET
                cfg.CreateMap<TSISCOA_Control_DTO, TSISCOA_Control>(); //POST-PUT

            });
        }
    }
}
