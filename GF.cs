using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGirlFriend
{
    class GF
    {
        //declaring some characteristics of the object
        private string name = "Helen";
        private string hairColour = "brown";
        private string hairType = "curly";
        private string comesFrom = "Germany";
        

        //inputs for modifying the object. To make inputs easier the chars will be assigned for each food/drink/music type
        private string food;
        private int foodInput;
        private string drink;
        private int drinkInput;
        private string music;
        private int musicInput;

        //outputs
        private double foodResult, drinkResult, musicResult, happiness;
        
        public void Start()
        {
            Introduction(); //This will introduce Helen
            ReadInput(); //This will allow the user to choose between a number of options to do things for Helen
            CalculateHappiness(); //This takes the user input and assigns a value to choices and then the total level of happiness
            DisplayHappiness();  //Shows a short "receipt" of how good a job the user did and displays what the true value is

        }
        private void Introduction()
        {
            Console.WriteLine("Hello Farid and Shadi - press enter to continue!\n");
            Console.ReadKey();
            Console.WriteLine("I thought I would present the reason for me moving away from Sweden. \n");
            Console.WriteLine("Her name is {0}, she has {1}, {2} hair and is from {3}", name, hairColour, hairType, comesFrom);
            Console.WriteLine("Now lets see what she likes");

        }
        private void ReadInput()
        {
            GiveFood(); 
            GiveDrink();
            PlayMusic();
        }
        private void GiveFood() //correct foodInput = 1
        {
            Console.WriteLine("Helen is a bit hungry, what do you give her to eat?" + "\nP.S. She is from Bavaria");
            Console.WriteLine("1 = a soft pretzel, 2 = a bacon sandwich, 3 = a tomato and mozarella salad");
            foodInput = Int16.Parse(Console.ReadLine()); //input as char to do ifelse statements
            if (foodInput ==1)
                food = "soft pretzel";
            if (foodInput ==2)
                food = "bacon sandwich";
            if (foodInput ==3)
                food = "tomato and mozarella salad";
          

        }
        private void GiveDrink() //correct drinkInput = 3
        {
            Console.WriteLine("Helen is now thirsty after her {0}", food);
            Console.WriteLine("What do you give her to drink?");
            Console.WriteLine("1 = orange juice, 2 = a beer, 3 = some tea");
            drinkInput = Int16.Parse(Console.ReadLine());
            if (drinkInput ==1)
                drink = "orange juice";
            if (drinkInput ==2)
                drink = "beer";
            if (drinkInput ==3)
                drink = "tea";
            
        }
        private void PlayMusic() //correct musicInput = 2
        {
            Console.WriteLine("Let's play some music for her, what genre do you play?");
            Console.WriteLine("1 = garage, 2 = rock, 3 = techno");
            musicInput = Int16.Parse(Console.ReadLine());
            if (musicInput ==1)
                music = "garage";
            if (musicInput ==2)
                music = "rock";
            if (musicInput ==3)
                music = "techno";
           
            Console.WriteLine("The {0} is turned up to 11!", music);
        }
         private void CalculateHappiness()
        {
            CalculateFoodResult();
            CalculateDrinkResult();
            CalculateMusicResult();
            CalculateTotalHappiness();
        }
        private void CalculateFoodResult()
        {
            if (foodInput ==1)
                foodResult = 33.33;
            else
                foodResult = 0;

        }
        private void CalculateDrinkResult()
        {
            if (drinkInput ==3)
                drinkResult = 33.33;
            else
                drinkResult = 0;
        }
        private void CalculateMusicResult()
        {
            if (musicInput ==2)
                musicResult = 33.33;
            else
                musicResult = 0;
        }
        private void CalculateTotalHappiness()
        {
            happiness = foodResult + drinkResult + musicResult;
        }
        private void DisplayHappiness()
        {
            Console.WriteLine("\nThanks for your inputs, let's see what Helen thought of it:");
            Console.WriteLine("Helen is currently at {0}% happiness!", happiness);
            Console.WriteLine("She likes Brezeln (pretzels) (doesn't tolerate vegetarian and can't eat tomatoes, drinking tea of all types as long as it is not cinnamon apple and listening to rock music");
        }
    }//end of Helen class
}
