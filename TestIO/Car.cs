using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIO
{

        class Car
        {
            protected string make;
            protected string model;
            protected int year;
            protected double price;

            public string Make //get set for each data piece
            {
                set { make = value; }
                get { return make; }
            }

            public string Model
            {
                set { model = value; }
                get { return model; }
            }

            public int Year
            {
                set { year = value; }
                get { return year; }
            }

            public double Price
            {
                set { price = value; }
                get { return price; }
            }

            //constructors

            //default constructor
            public Car() //base constructor? 
            {
                make = "";
                model = "";
                year = 0;
                price = 0;
            }

            //consturctor with values
            public Car(string CarMake, string CarModel, int CarYear, double CarPrice)
            {
                make = CarMake; //calls Make from the array Car
                model = CarModel;
                year = CarYear;
                price = CarPrice;
            }

            public virtual void PrintInfo()
            {
                Console.WriteLine(Make.PadRight(8, ' ') + "\t" + Model.PadRight(8, ' ') + "\t" + Year.ToString().PadRight(8, ' ') + "\t" + "$" + Price.ToString("N2")); //property (capitalized)

                //to enable method override, we must go to the top, in our Person class. 
                //if the method is defined as virtual, you can override it

            }

            public override string ToString()
            {
                return (Make.PadRight(8, ' ') + "\t" + Model.PadRight(8, ' ') + "\t" + Year.ToString().PadRight(8, ' ') + "\t" + "$" + Price.ToString("N2"));
            }

        }
    
}
