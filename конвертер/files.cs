using System.Xml.Serialization;

namespace конвертер
{
    public class files
    {
        public string userformat;
        private bool result;
        private bool result1;
        private bool result2;

        public void viborFormata(List<human> humans)
        {
            Console.WriteLine("\nвведиtе путь до файла");
            Console.WriteLine("----------------------------");
            userformat = Console.ReadLine();
            result = userformat.Contains(".txt");
            result1 = userformat.Contains(".json");
            result2 = userformat.Contains(".xml");

            if (result == true) { txt(humans); }
            if (result1 == true) { json(humans); }
            if (result2 == true) { xml(humans); }
        }

        public void txt(List<human> humans)
        {
            human human = new human();
            foreach (human vivod in humans)
            {
                File.AppendAllText(userformat, human.name + "\n" + human.age + "\n" + human.color);
            }
        }
        public void json(List<human> humans)
        {
            human human = new human();
        }
        public void xml(List<human> humans)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<human>));
            using (FileStream fs = new FileStream(userformat, FileMode.OpenOrCreate))
            {
                xmls.Serialize(fs, humans);
            }
        }
    }
}