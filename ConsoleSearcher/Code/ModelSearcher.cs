using System;
using System.Collections.Generic;
using System.Text;

using ConsoleSearcher.Model;

namespace ConsoleSearcher.Code
{
    public class ModelSearcher
    {
        public List<MyModel> Models { get; private set; }

        private Dictionary<int, string> dictionary;

        public ModelSearcher()
        {
            Models = new List<MyModel>();

            dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "Zero usual dictionary line");
            dictionary.Add(1, "First common dictionary line");
            dictionary.Add(2, "Second random dictionary line");
        }

        private List<int> FindTextInDictionary(string text)
        {
            var result = new List<int>();
            
            int[] values = (int[])Enum.GetValues(typeof(MyEnum));

            for (int i = 0; i < values.Length; i++)
            {
                if (dictionary[values[i]].Contains(text))
                {
                    result.Add(values[i]);
                }
            }

            return result;
        }

        private bool IfFitsAmongStrings(MyModel model, string text)
        {            
            if (model.FirstLine.Contains(text) || model.SecondLine.Contains(text)
                || model.ThirdLine.Contains(text) || model.Numbers.ToString().Contains(text))
                {
                    return true;
                }
            if (dictionary[(int)model.Numbers].Contains(text)) return true;
            return false;
        }

        public string FindModelsWithText(IEnumerable<MyModel> models, string text)
        {            
            if (text == "")
            {
                return "no result";
            }
            
            var result = new StringBuilder("");

            var dictionaryKeys = FindTextInDictionary(text);            

            foreach (int key in dictionaryKeys)
            {
                result.Append("Key: \"" + key + "\" with value \""+dictionary[key]+"\"\n");
            }

            result.Append('\n');

            int number = 1;
            foreach (MyModel model in models)
            {
                if (IfFitsAmongStrings(model, text))
                {
                    result.Append(number++ + ") Model № " + model.Id + "; ");
                    result.Append("First string field:\"" + model.FirstLine + "\"; ");
                    result.Append("Second string field:\"" + model.SecondLine + "\"; ");
                    result.Append("Third string field:\"" + model.ThirdLine + "\";\n");                    
                }
            }

            return result.ToString(); ;
        }
    }
}
