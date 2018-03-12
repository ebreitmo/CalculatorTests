namespace Calculator
{
    public interface ICalculator
    {
        int Add(int n1, int n2);
    }
    public class Calculator : ICalculator
    {
        public int Add(int n1, int n2)
        {
        int result = n1 - n2;
        return result;
        }
     }
}