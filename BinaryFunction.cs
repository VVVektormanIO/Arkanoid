namespace LAST_TRY_lb4
{
    public abstract class BinaryFunction : IBinaryFunction
    {
        private bool x;
        private bool y;
        public bool X
        {
            get { return x; }
            set { x = value; }
        }
        public bool Y
        {
            get { return y; }
            set { y = value; }
        }
        public BinaryFunction()
        {
            x = false;
            y = false;
        }
        public BinaryFunction(bool xValue, bool yValue)
        {
            x = xValue;
            y = yValue;
        }
        public virtual bool compute()
        {
            return false;
        }
        public virtual string GetName()
        {
            return "BinaryFunction";
        }
    }
}
