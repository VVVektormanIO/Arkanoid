namespace LAST_TRY_lb4
{
    public class Conjunction : BinaryFunction
    {
        public Conjunction() : base() { }
        public Conjunction(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return X && Y;
        }
        public override string GetName()
        {
            return "Conjunction";
        }
    }
}
