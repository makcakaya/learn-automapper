using System.Collections.Generic;

namespace LearnAutoMapper.Layers.Interface
{
    public interface IFaculty
    {
        string Name { get; }
        IEnumerable<ICourse> Courses { get; }
        IEnumerable<IStudent> Students { get; }
    }
}
