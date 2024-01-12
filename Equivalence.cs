namespace LAST_TRY_lb4
{
    public class Equivalence : BinaryFunction
    {
        public Equivalence() : base() { }
        public Equivalence(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return (X && Y) || (!X && !Y);
        }
        public override string GetName()
        {
            return "Equivalence";
        }
    }
}
