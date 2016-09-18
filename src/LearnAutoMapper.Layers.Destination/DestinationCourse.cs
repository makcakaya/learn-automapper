using System;

namespace LearnAutoMapper.Layers.Destination
{
    public sealed class DestinationCourse
    {
        public string Name { get; private set; }
        public int Credit { get; private set; }
        public bool Mandatory { get; private set; }

        public DestinationCourse(string name, int credit, bool mandatory)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException(nameof(name)); }

            Name = name;
            Credit = credit;
            Mandatory = mandatory;
        }
    }
}
