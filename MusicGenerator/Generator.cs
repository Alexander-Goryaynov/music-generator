using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator
{
    public static class Generator
    {
        static Random rand = new Random();
        static string[] notes;
        static string[] octaves; 
        static string[] lengths;
        static Generator()
        {
            notes = new string[] { "Do", "DoS", "Re", "ReS", "Mi",
            "Fa", "FaS", "Sol", "SolS", "La", "LaS", "Si", "Pause"};
            octaves = new string[] { "First", "Second", "Third" };
            lengths = new string[] { "Two", "Four", "Eight" };
        }
        public static string GenerateMusic()
        {
            string result = "";
            int amount = rand.Next(1, 20);
            for (int i = 0; i < amount; i++)
            {
                int index = rand.Next(0, notes.Length);
                result += notes[index];
                if (!notes[index].Equals("Pause"))
                {
                    index = rand.Next(0, octaves.Length);
                    result += octaves[index];
                }
                result += " ";
                index = rand.Next(0, lengths.Length);
                result += lengths[index] + " ";
            }
            return result;
        }
    }
}
