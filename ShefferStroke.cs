namespace LAST_TRY_lb4
{
    public class ShefferStroke : BinaryFunction
    {
        public ShefferStroke() : base() { }
        public ShefferStroke(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return !(X && Y);
        }
        public override string GetName()
        {
            return "ShefferStroke";
        }
    }
}
