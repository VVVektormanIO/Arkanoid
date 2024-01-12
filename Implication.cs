namespace LAST_TRY_lb4
{
    public class Implication : BinaryFunction
    {
        public Implication() : base() { }
        public Implication(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return !X || Y;
        }
        public override string GetName()
        {
            return "Implication";
        }
    }
}
