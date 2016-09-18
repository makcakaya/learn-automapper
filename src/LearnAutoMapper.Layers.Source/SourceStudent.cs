using System;

namespace LearnAutoMapper.Layers.Source
{
    public sealed class SourceStudent
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Year { get; private set; }

        public SourceStudent(string name, int age, int year)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(nameof(name)); }
            Name = name;
            Age = age;
            Year = year;
        }
    }
}
