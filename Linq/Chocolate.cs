using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Chocolate
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Fat { get; set; }
        public string Cholestrol { get; set; }
        public string Carbohydrates  { get; set; }
        public string Protein { get; set; }
        public double Price { get; set; }

        public Chocolate(string name, string ingredients, string fat, string cholestrol, string carb, string protein, double price)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Fat = fat;
            this.Cholestrol = cholestrol;
            this.Carbohydrates = Carbohydrates;
            this.Protein = protein;
            this.Price = price;
        }

/*
        static void Main(string[] args)
        {
            List<Chocolate> chocolateList = new List<Chocolate>()
            {
                new Chocolate ("Ferro Rocher","Condensed Milk, Sugar, Wine, Milk Choclate" , "20g", "50mg", "34g", "4g", 9.99),
                new Chocolate ("Cadbury","Condensed Milk, Sugar, Milk Choclate" , "30g", "100mg", "38g", "14g", 8.99),
                new Chocolate ("Rees","Condensed Milk, Sugar, Peanuts, Milk Choclate" , "25g", "60mg", "39g", "24g", 6.99),
                new Chocolate ("Bounty","Condensed Milk, Sugar, Coconut, Milk Choclate" , "28g", "75mg", "40g", "12g", 10.99),
                new Chocolate ("Milkybar","Condensed Milk, Sugar, Milk Choclate" , "22g", "50mg", "34g", "14g", 12.99),
                new Chocolate ("Kiss","Condensed Milk, Sugar, Hazelnut, Milk Choclate" , "20g", "78mg", "55g", "9g", 13.99),
                new Chocolate ("Hersheys","Condensed Milk, Sugar, Cahewnut, Raisins, Milk Choclate" , "25g", "60mg", "29g", "4g", 8.99),
                new Chocolate ("Snickers","Condensed Milk, Sugar, Peanuts, Milk Choclate" , "23g", "50mg", "66g", "8g", 7.99),
                new Chocolate ("Toblerone","Condensed Milk, Sugar, Swiss Choclate" , "27g", "80mg", "44g", "10g", 18.99),
                new Chocolate ("Mars","Condensed Milk, Sugar, Caramel, Milk Choclate" , "20g", "50mg", "34g", "7g", 11.99)
            };


            // Question 1: return the name and price of the chocolates with a price less than or equal to 10.

            var getChocolates = from chocolate in chocolateList
                                where chocolate.Price <= 10
                                select new { chocolate.Name, chocolate.Price };

            Console.WriteLine("LINQ Query");

            foreach (var item in getChocolates)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("LINQ and Lamda Expression");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Chocolates with Price less than 10");

            var getChocolatesLambda = chocolateList.Where(chocolate => chocolate.Price <= 10);

            foreach (var item in getChocolatesLambda)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }



            Console.ReadKey();
        }

    */
    }
}
