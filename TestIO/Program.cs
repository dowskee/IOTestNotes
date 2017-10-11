using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //write to a file

            //StreamWriter wr = new StreamWriter("Cars.txt", true); //string path

            //wr.WriteLine("Jeep\tCompass\t2015\t30000"); //writes to file(or application), instead of to console!

            //wr.WriteLine("Chevy\tCruze\t2016\t20000");

            //wr.Close(); //will essentially save your data

            //append by adding "true" after "Cars.txt". This means that every time you add something to the file, it will add it to text file

            //read from a file
            //once the text is read, it will be split into its proper pieces

            StreamReader rd = new StreamReader("Cars.txt");

            //string str = rd.ReadToEnd(); //this reads the contents of the file

            //Console.WriteLine(str); //prints contents to console
            List<Car> CarList = new List<Car>();
            string str = rd.ReadLine(); //ReadLine only reads one line of the file
            //use a loop to go through these lines one at a time, until we reach the end, which will be a null. 

            while (str != null) //while we still have more lines to read
            {
                //Console.WriteLine(str); //print the first/current line
                
                string[] tempCar = str.Split(); //This will take the line and split it in to four pieces, for the Car class (Make, Model, Year, Price)

                CarList.Add(new Car(tempCar[0], tempCar[1], int.Parse(tempCar[2]), double.Parse(tempCar[3]))); //this will reference the 
                //index of each piece(object) in the List array of Car, for Make, Model, Year, and Price. We need to assign value because Car has properties.
                str = rd.ReadLine(); //will fetch next line. If this is not written, the program will stop. 
            }
            //this is good for memory. This helps with efficiency as it breaks it down, instead of ReadToEnd, which dumps it all at once. 

            foreach (Car Element in CarList)
            {
                Console.WriteLine(Element.ToString()); //data is coming from your objects
            }

            //using ORM Frameworks will save you a lot of this code. 
        }
    }
}
