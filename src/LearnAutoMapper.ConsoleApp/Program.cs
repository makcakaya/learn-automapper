using LearnAutoMapper.Layers.Destination;
using LearnAutoMapper.Layers.Source;
using System;

namespace LearnAutoMapper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MapConcretes();
            MapInterfaces();
        }

        public static void MapConcretes()
        {
            var sourceStudent1 = new SourceStudent("Student 1", 20, 1);
            var sourceStudent2 = new SourceStudent("Student 2", 21, 2);

            var sourceCourse1 = new SourceCourse("Course 1", 1, true);
            var sourceCourse2 = new SourceCourse("Course 2", 2, false);

            var sourceFaculty = new SourceFaculty("Faculty", new SourceCourse[] { sourceCourse1, sourceCourse2 }, new SourceStudent[] { sourceStudent1, sourceStudent2 });
            var destinationFaculty = LayersMapper.Instance.Map<DestinationFaculty>(sourceFaculty);

            Console.WriteLine("Destination Faculty - Name: {0}", destinationFaculty.Name);
        }

        public static void MapInterfaces()
        {
            // TODO: Implement mapping from an interface to another.
            // ISourceType -> IDestinationType
        }
    }
}
