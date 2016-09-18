namespace LearnAutoMapper.Layers.Interface
{
    public interface ICourse
    {
        string Name { get; }
        int Credit { get; }
        bool Mandatory { get; }
    }
}
