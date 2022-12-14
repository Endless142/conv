using System.Xml.Serialization;

namespace конвертер
{
    class Program
    {
        human human = new human();

        static void Main()
        {
            Console.WriteLine("введиtе путь к файлу, который хотите прочитать");
            Console.WriteLine("----------------------------");
            string userInside = Console.ReadLine();
            bool result = userInside.Contains(".txt");
            bool result1 = userInside.Contains(".json");
            bool result2 = userInside.Contains(".xml");

            if (result == true)
            {
                List<human> txtlist = new List<human>();
                string[] Stroki = File.ReadAllLines(userInside);
                for (int i = 0; i <= Stroki.Length; i += 3)
                {
                    human human = new human(Stroki[i], Convert.ToInt32(Stroki[i += 1]), Stroki[i += 2]);
                    txtlist.Add(human);
                }
                foreach (human vivodtxt in txtlist) { Console.WriteLine(vivodtxt); }
            }

            if (result1 == true)
            {
                string text = File.ReadAllText(userInside);
                {
                    Console.WriteLine(human.name, human.age, human.color);
                }
            }

            if (result2 == true)
            {
                //List<human> humannew = new List<human>();

                XmlSerializer xmls = new XmlSerializer(typeof(List<human>));
                TextReader textReader = new StreamReader(userInside);
                List<human> xmllist;
                xmllist = (List<human>)xmls.Deserialize(textReader);
                textReader.Close();
                //return humannew;
                foreach (human i in xmllist)
                { Console.WriteLine(i); }




                //using (FileStream fs = new FileStream(userInside, FileMode.Open))
                //{
                //    List<human> humannew = (List<human>)xmls.Deserialize(fs);
                //    Console.WriteLine(humannew);
                //}
                //foreach (human vivodxml in humannew)
                //{
                //    Console.WriteLine(vivodxml);
                //}
            }
            Console.ReadKey();
            //files files = new files();
            //files.viborFormata(list());
        }

        static List<human> list()
        {
            human human = new human();
            List<human> humans = new List<human>();
            human human1 = new human("алик", 17, "белый");
            human human2 = new human("суета", 10, "черный");
            human human3 = new human("анастасьон", 22, "фиол");
            humans.Add(human1);
            humans.Add(human2);
            humans.Add(human3);
            return humans;
        }
    }
}