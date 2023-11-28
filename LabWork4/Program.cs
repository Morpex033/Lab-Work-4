namespace LabWork4
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Lab Work №4\n" + "Task 21");
            Console.WriteLine("Create Complex Number №A:");
            ComplexNumber complexNumberA = createComplexNumber();
            Console.WriteLine("Your Complex Number №A is: " + complexNumberA);
            Console.WriteLine("Create Complex Number №B:");
            ComplexNumber complexNumberB = createComplexNumber();
            Console.WriteLine("Your Complex Number №B is: " + complexNumberB);
            Console.WriteLine("Create Complex Number №C:");
            ComplexNumber complexNumberC = createComplexNumber();
            Console.WriteLine("Your Complex Number №C is: " + complexNumberC);
            Console.WriteLine("Create Complex Number №D:");
            ComplexNumber complexNumberD = createComplexNumber();
            Console.WriteLine("Your Complex Number №D is: " + complexNumberD);

            Console.WriteLine("Result according to the formula: " +
                (complexNumberB + complexNumberA - (complexNumberB / complexNumberC) * complexNumberD.Power(5)));
        }

        public static ComplexNumber createComplexNumber()
        {
            Console.WriteLine("Enter the real part of complex number: ");
            int realPart = inputNumber();
            Console.WriteLine("Enter the imaginary part of complex number without i: ");
            int imaginaryPart = inputNumber();

            return new ComplexNumber(realPart, imaginaryPart);
        }

        /*
         * Метод для ввода числа с клавиатуры.
         * В числе не должны присутствовать сторонние символы и число должно быть целое.
         */
        public static int inputNumber()
        {
            string input = "";
            int number = 0;
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    number = int.Parse(input);

                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}