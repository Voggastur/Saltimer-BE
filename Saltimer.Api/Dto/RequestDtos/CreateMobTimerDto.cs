using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Saltimer.Api.Models;

namespace Saltimer.Api.Dto
{
    public class CreateMobTimerDto
    {
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string DisplayName { get; set; }

        [Required]
        [Range(1, 30)]
        public int RoundTime { get; set; }

        [Required]
        [Range(1, 30)]
        public int BreakTime { get; set; }
    }

    public class CreateMobTimerDtoToMobTimerSessionProfile : Profile
    {
        public CreateMobTimerDtoToMobTimerSessionProfile()
        {
            CreateMap<CreateMobTimerDto, MobTimerSession>();
        }
    }
}
