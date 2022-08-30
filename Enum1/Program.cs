namespace Enum1
{
    internal class Program
    {
        enum ZoneSpeed
        {
            SCHOOL = 20, CITY = 30, HIGHWAY = 55
        }

        enum Zones
        {
            SCHOOL = 1, CITY, HIGHWAY
        }

        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Please Enter A Zone Number ");
            Console.WriteLine("1.SCHOOL");
            Console.WriteLine("2.CITY");
            Console.WriteLine("3.HIGHWAY");
            Console.WriteLine("************************************");
            int zone = Convert.ToInt32(Console.ReadLine());

            while (zone <= 0 || zone > 3)
            {
                Console.WriteLine("Please Enter A Zone Number");
                zone = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("************************************");
            Console.WriteLine("Please Enter Your Current Speed");
            Console.WriteLine("************************************");
            int speed = Convert.ToInt32(Console.ReadLine());


            if (zone == 1 )
            {
                Console.WriteLine("Please Slow Down And Maintain The Speed Limit Of 20 In The School Zone");
            }
            else if (zone == 2 && speed > (int)ZoneSpeed.CITY)
            {
                Console.WriteLine("Please Slow Down And Maintain The Speed Limit Of 30 In The City Zone");
            }
            else if (zone == 3 && speed > (int)ZoneSpeed.HIGHWAY)
            {
                Console.WriteLine("Please Slow Down And Maintain The Speed Limit Of 55 In The Highway Zone");
            }
            else
            {
                Console.WriteLine("************************************");
                Console.WriteLine("Thank You For Maintaining The Speed Limit In Your Zone");
                Console.WriteLine("************************************");
            }
            Console.ReadKey();



        }

    }

}
    