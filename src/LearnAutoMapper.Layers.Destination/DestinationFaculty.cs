using System;
using System.Collections.Generic;

namespace LearnAutoMapper.Layers.Destination
{
    public sealed class DestinationFaculty
    {
        public string Name { get; private set; }
        public IEnumerable<DestinationCourse> Courses { get; private set; }
        public IEnumerable<DestinationStudent> Students { get; private set; }

        public DestinationFaculty(string name, IEnumerable<DestinationCourse> courses, IEnumerable<DestinationStudent> students)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(nameof(name)); }

            Name = name;
            Courses = courses;
            Students = students;
        }
    }
}
