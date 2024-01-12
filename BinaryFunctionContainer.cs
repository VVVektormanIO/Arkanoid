using System.Collections.Generic;

namespace LAST_TRY_lb4
{
    public class BinaryFunctionContainer
    {
        private List<IBinaryFunction> functions;

        public BinaryFunctionContainer()
        {
            functions = new List<IBinaryFunction>();
        }

        public void AddFunction(IBinaryFunction function)
        {
            functions.Add(function);
        }

        public void ClearFunctions()
        {
            functions.Clear();
        }

        public List<string> CalculateAll(bool x, bool y)
        {
            List<string> results = new List<string>();

            foreach (var function in functions)
            {
                bool result = function.compute();
                results.Add($"{function.GetName()}({x}, {y}) = {result}");
            }

            return results;
        }
    }
}
