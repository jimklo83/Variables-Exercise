namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Words
            string gangnamStyle;
            gangnamStyle = "Oppa Gangnam Style";
            
            char key;
            key = 'b';

            bool isAlive;
            isAlive = true;
            
            //Numbers
            int wholeNum;
            wholeNum = 5;

            double toilAndTrouble;
            toilAndTrouble = 4325789.75;

            decimal cashMoney;
            cashMoney = 14.99m;

            Console.WriteLine($"My favorite song is {gangnamStyle}, I've listened to it {wholeNum} times today and {toilAndTrouble} times throughout my whole life.");
            Console.WriteLine($"I spent {cashMoney} buying the song.");

        }
    }
}
