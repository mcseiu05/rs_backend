using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using RS.Domain.AP;
using Abp.AutoMapper;

namespace RS.Services.AP.Dto
{
    [AutoMapFrom(typeof(ApPanel))]
    public class ApPanelDto: EntityDto<int>
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
