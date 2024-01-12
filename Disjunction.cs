namespace LAST_TRY_lb4
{
    public class Disjunktion : BinaryFunction
    {
        public Disjunktion() : base() { }
        public Disjunktion(bool xValue, bool yValue) :
        base(xValue, yValue)
        { }
        public override bool compute()
        {
            return X || Y;
        }
        public override string GetName()
        {
            return "Disjunktion";
        }

    }
}
