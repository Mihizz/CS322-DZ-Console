using System;


namespace CS322_DZ_Console
{
    class Program
    {
        //static int stepenovanje(int br, int stepen)
        //{
        //    if (br == 0 || stepen < 0)
        //    {
        //        return 0;
        //    }
        //    int br1 = 1;
        //    for (int i = 0; i < stepen; i++)
        //    {
        //        br1 *= br;
        //    }
        //    return br1;
        //}

        static void Main(string[] args)
        {
            //   Console.Write("Unesite broj: ");
            //   int broj = int.Parse(Console.ReadLine());

            //  Console.Write("Unesite stepen: ");
            //   int stepen = int.Parse(Console.ReadLine());

            //    Console.WriteLine(stepenovanje(broj, stepen));

            //  Pomocna pom1 = new Pomocna();
            //   Pomocna pom2 = new Pomocna();
            Pomocna p = new Pomocna();
          //  Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                //   Console.WriteLine(r.Next(200) + 1);
               Console.WriteLine(p.randomBroj200());
            }

         //   for (int i = 0; i < 50; i++) {
             //     Console.WriteLine(new Pomocna().randomBroj200());
          //  }
          //  Console.WriteLine(pom1.randomBroj200());
        //    Console.WriteLine(pom2.randomBroj200());

    //        Posetioc p1 = new Posetioc(pom1.randomRec(), pom1.randomRec(), pom1.randomBroj200());
        //    Posetioc p2 = new Posetioc(pom2.randomRec(), pom2.randomRec(), pom2.randomBroj200());

         //   p1.stampanje();
        //    p2.stampanje();

            Console.ReadLine();
        }
    }
}

