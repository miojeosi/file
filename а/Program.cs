using Newtonsoft.Json;
using System.Xml.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace pop
{
    internal class pop
    {

        public static void Main()
        {
            human aleksei = new human();
            aleksei.name = "кто это ну ладно алексей";
            aleksei.rost = 180;
            aleksei.ves = 70;

            human sergei = new human();
            sergei.name = "ууу а это сергей";
            sergei.rost = 185;
            sergei.ves = 75;

            human margarita = new human();
            margarita.name = "здесь маргарита";
            margarita.rost = 170;
            margarita.ves = 65;

            List<human> Humans = new List<human>();
            Humans.Add(aleksei);
            Humans.Add(sergei);
            Humans.Add(margarita);


            Console.WriteLine("ввести путь к файлу(пока только один - C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.txt ");
            string a = Console.ReadLine();

            Console.WriteLine("как сохранить? добавьте в конец .txt or .json or .xml");
            string tip = Console.ReadLine();


            if (tip.Contains("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.txt"))
            {
                string txt = File.ReadAllText("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.txt");
                Console.WriteLine(txt);
                
            }
            if (tip.Contains("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.json"))
            {
                string txt = File.ReadAllText("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.txt");
                List<human> result = JsonConvert.DeserializeObject<List<human>>(txt);
            }
            if (tip.Contains("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.xml"))
            {
              //  Humans = new List<human>();
                XmlSerializer xml = new XmlSerializer(typeof(human));
                using (FileStream fs = new FileStream("C:\\Users\\Светлана\\OneDrive\\Рабочий стол\\Текстовый документ.xml", FileMode.Open));
                {
                    Stream fs = null;
                    object human = xml.Deserialize(fs);
                    //он вроде принимать дллжен в xml...
                }

            }
        }
    }
}
