using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicGenerator
{
    public static class Player
    {
        public static string[] ParseInput(string input)
        {
            var notes = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (notes.Length % 2 != 0)
            {
                throw new Exception("Неверно введены ноты");
            }
            return notes;
        }
        
        public static void Play(string[] notes, int bpm)
        {
            int speed = (int)(60.0 / Convert.ToDouble(bpm) * 1000);
            string json = File.ReadAllText(Directory.GetParent(
                Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName +
                @"\data.json");
            JObject data = JObject.Parse(json);
            for (int i = 0; i < notes.Length - 1; i += 2)
            {
                var note = notes[i];
                var lengthStr = notes[i + 1];
                float coefficient = 0.0f;
                try
                {
                    coefficient = (float)data["Lengths"][lengthStr];
                }
                catch
                {
                    throw new Exception("Не распознана длина одной из нот");
                }                
                int realLength = (int)(coefficient * speed);
                if (note.Equals("Pause"))
                {
                    Thread.Sleep(realLength);
                } 
                else
                {
                    int frequency = 0;
                    try
                    {
                        frequency = (int)data["Frequencies"][note];
                    }
                    catch
                    {
                        throw new Exception("Не распознана частота одной из нот");
                    }                        
                    Console.Beep(frequency, realLength);
                }
            }
        }
    }
}
