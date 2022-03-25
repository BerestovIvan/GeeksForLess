using AutoMapper;
using BLL.Models;
using GeeksForLess.Models.AuthenticationModels;

namespace GeeksForLess.Mapper
{
    public class MapperBLLAndApi : Profile
    {
        public MapperBLLAndApi()
        {
            CreateMap<RegisterPostModel, RegisterModel>().ReverseMap();
            CreateMap<LoginModel, LoginPostModel>().ReverseMap();
        }
    }
}
