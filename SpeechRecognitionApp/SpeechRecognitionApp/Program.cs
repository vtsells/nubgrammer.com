using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace SpeechRecognitionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an in-process speech recognizer for the en-US locale.  
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-US")))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();


                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.  
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }

        // Handle the SpeechRecognized event.  
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var text = e.Result.Text;
            //uncomment to give test text instead of voice
            //text="what is 500,000 plus 200,000";

            if (text.Contains("plus"))
            {
                var splitTextByPlus = text.Split(new string[] { "plus" }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Text before plus: " + splitTextByPlus[0] + " Text after plus: " + splitTextByPlus[1]);
                var splitBySpace1 = splitTextByPlus[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var splitBySpace2 = splitTextByPlus[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var beforePlus = splitBySpace1[splitBySpace1.Length - 1].Replace(",", "");
                var afterPlus = splitBySpace2[0].Replace(",", "");
                long num1;
                long num2;
                var wasLong1 = long.TryParse(beforePlus, out num1);
                var wasLong2 = long.TryParse(afterPlus, out num2);
                if (!wasLong1)
                {
                    num1 = Regex.Matches(beforePlus, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]).FirstOrDefault();
                }
                if (!wasLong2)
                {
                    num2 = Regex.Matches(afterPlus, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]).FirstOrDefault();
                }
                Console.WriteLine("Number before plus: " + num1 + " Number after plus: " + num2);
                var answer = num1 + num2;
                SpeechSynthesizer sythesizer = new SpeechSynthesizer();
                sythesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
                sythesizer.Speak("The answer to your question is "+answer.ToString());
            }

            Console.WriteLine("Recognized text: " + e.Result.Text);
        }
        private static Dictionary<string, long> numberTable = new Dictionary<string, long>{
            {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
            {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
            {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
            {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
            {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
            {"hundred",100}
        };
    }
}