using AutoMapper;
using BLL.Models;
using GeeksForLess.Models.AuthenticationModels;
using GeeksForLess.Models.PostModels;
using GeeksForLess.Models.PutModels;
using GeeksForLess.Models.ViewModels;

namespace GeeksForLess.Mapper
{
    public class MapperBLLAndApi : Profile
    {
        public MapperBLLAndApi()
        {
            CreateMap<RegisterPostModel, RegisterModel>().ReverseMap();
            CreateMap<LoginModel, LoginPostModel>().ReverseMap();

            CreateMap<TopicViewModel, TopicModel>().ReverseMap();
            CreateMap<TopicPostModel, TopicModel>().ReverseMap();
            CreateMap<TopicPutModel, TopicModel>().ReverseMap();
        }
    }
}
