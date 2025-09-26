public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            if (operation == "+")
            {
                int result = SimpleOperation.Addition(operand1, operand2);
                return $"{operand1} {operation} {operand2} = {result}";
            }
            else if (operation == "*")
            {
                int result = SimpleOperation.Multiplication(operand1, operand2);
                return $"{operand1} {operation} {operand2} = {result}";
            }
            else if (operation == "/")
            {
                int result = SimpleOperation.Division(operand1, operand2);
                return $"{operand1} {operation} {operand2} = {result}";
            }
            else if (operation == null)
            {
                throw new ArgumentNullException("Operation cannot be null.");
            }
            else if (operation == "")
            {
                throw new ArgumentException("Operation cannot be an empty string:.");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Operation is out of range.");
            }

        }
        catch (DivideByZeroException)
        {return "Division by zero is not allowed.";
            
        }  
    }
}
