

class Program
{     static void Main(string[] args)
    {
        // Create an instance of Pig
        MPVInterface.Pig pig = new MPVInterface.Pig();
        
        // Call the animalSound method
        pig.animalSound();
        
        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}