namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string programmerNickname = "Ace";
            int programmerAge = 30;
            char programmerID = 'Z';
            bool isNew = false;
            double hoursCoded = 2000.5;
            decimal hoursGoal = 10000.0m;

            Console.WriteLine($"There is a programming student nicknamed {programmerNickname} and their age is \n"  +
                $"  {programmerAge}and they are also known here as  {programmerID}  and T/F that they are a new programmer:  {isNew} \n " +
                $"and number of hours they have coded last semester is  {hoursCoded} " +
                $"and finally their number of hours goal for \n" +
                $" this semester is  {hoursGoal}!!!");

            

        }
    }
}
