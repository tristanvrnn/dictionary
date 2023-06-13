using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();

        // Add words to the dictionary
        dictionary.Add('a', new List<string> { "Arbre", "Avion", "Animal" });
        dictionary.Add('b', new List<string> { "Bateau", "Bougie", "Banane" });
        dictionary.Add('c', new List<string> { "Chat", "Chien", "Carotte" });

        dictionary.Remove('c');

         foreach(KeyValuePair<char, List<string>> entry in dictionary)
        {
            Console.WriteLine(entry.Key + " ==> " + String.Join(" ; ", entry.Value));
        }
    }   

}