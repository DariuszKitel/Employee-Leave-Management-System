using AutoMapper;
using Employee_Leave_Management_System.Web.Data.Entities;
using Employee_Leave_Management_System.Web.Models.Dtos;

namespace Employee_Leave_Management_System.Web.Config
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
