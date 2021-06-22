using AutoMapper;
using RS.Domain.AP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.Services.AP.Dto
{
    public class ApPanelMapProfile : Profile
    {
        public ApPanelMapProfile()
        {
            CreateMap<ApPanelDto, ApPanel>();
            CreateMap<ApPanel, ApPanelDto>();
        }
    }
}
