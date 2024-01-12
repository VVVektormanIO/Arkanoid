namespace LAST_TRY_lb4
{
    public interface IBinaryFunction
    {
        bool X { get; set; }
        bool Y { get; set; }
        bool compute();
        string GetName();
    }
}
