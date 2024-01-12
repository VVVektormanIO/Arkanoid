namespace LAST_TRY_lb4
{
    public class ExclusiveOr : BinaryFunction
    {
        public ExclusiveOr() : base() { }
        public ExclusiveOr(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return X ^ Y;
        }
        public override string GetName()
        {
            return "ExclusiveOr";
        }
    }
}
