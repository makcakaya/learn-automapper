using System;

namespace LearnAutoMapper.Layers.Source
{
    public sealed class SourceCourse
    {
        public string Name { get; private set; }
        public int Credit { get; private set; }
        public bool Mandatory { get; private set; }

        public SourceCourse(string name, int credit, bool mandatory)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(nameof(name)); }

            Name = name;
            Credit = credit;
            Mandatory = mandatory;
        }
    }
}
