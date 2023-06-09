// Объявление перечисления для ответа пользователя (да/нет)
enum EAnswerUser
{
    Yes = 1,
    No = 0
}

class Program
{
    static void Main(string[] args)
    {
        // Инициализация переменной ответа пользователя
        char userAnswer = 'д';


        // Цикл продолжается, пока пользователь отвечает "да"
    while (userAnswer == 'д')
        {
            // Объявление переменных для хранения чисел и операции
            double firstNumber;
            double secondNumber;
            double totalValue = 0;
            char oper;

            // Вывод сообщений в консоль для пользовательского ввода
            Console.WriteLine("Введите первое число:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            // Выполнение операции в зависимости от введенного оператора
            switch (oper)
            {
                case '+':
                    totalValue = firstNumber + secondNumber;
                    Console.WriteLine("Сумма " + firstNumber + " и " + secondNumber + " равна " + totalValue + ".");
                    break;

                case '-':
                    totalValue = firstNumber - secondNumber;
                    Console.WriteLine("Разность " + firstNumber + " и " + secondNumber + " равна " + totalValue + ".");
                    break;

                case '*':
                    totalValue = firstNumber * secondNumber;
                    Console.WriteLine("Умножение " + firstNumber + " на " + secondNumber + " равно " + totalValue + ".");
                    break;

                case '/':
                    // Обработка деления на 0
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно!");
                    }
                    else
                    {
                        totalValue = firstNumber / secondNumber;
                        Console.WriteLine("Деление " + firstNumber + " на " + secondNumber + " равно " + totalValue + ".");
                    }
                    break;

                // Обработка неизвестного оператора
                default:
                    Console.WriteLine("Неизвестный оператор.");
                    break;
            }

            // Запрос пользователя на продолжение работы с калькулятором
            Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
            userAnswer = Convert.ToChar(Console.ReadLine());
        }
    }
}