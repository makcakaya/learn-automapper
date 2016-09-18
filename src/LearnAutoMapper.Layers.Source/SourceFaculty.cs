using System;
using System.Collections.Generic;

namespace LearnAutoMapper.Layers.Source
{
    public sealed class SourceFaculty
    {
        public string Name { get; private set; }
        public IEnumerable<SourceCourse> Courses { get; private set; }
        public IEnumerable<SourceStudent> Students { get; private set; }

        public SourceFaculty(string name, IEnumerable<SourceCourse> courses, IEnumerable<SourceStudent> students)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(nameof(name)); }

            Name = name;
            Courses = courses;
            Students = students;
        }
    }
}
