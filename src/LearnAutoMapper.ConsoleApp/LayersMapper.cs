using AutoMapper;
using AutoMapper.Configuration;
using LearnAutoMapper.Layers.Destination;
using LearnAutoMapper.Layers.Source;

namespace LearnAutoMapper.ConsoleApp
{
    public static class LayersMapper
    {
        public static IMapper Instance { get; private set; }

        static LayersMapper()
        {
            var expression = new MapperConfigurationExpression();
            expression.CreateMap<SourceStudent, DestinationStudent>();
            expression.CreateMap<SourceCourse, DestinationCourse>();
            expression.CreateMap<SourceFaculty, DestinationFaculty>();

            var config = new MapperConfiguration(expression);
            Instance = config.CreateMapper();
        }
    }
}
