using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> goodsongs = new List<Dictionary<string, string>>();

            HashSet<Dictionary<string, string>> allsongs = new HashSet<Dictionary<string, string>>(){

                // we can also add these dictionaries outside of the hashset
                new Dictionary<string, string>(){
                    {"Nickleback", "Rockstar"}
                },
                 new Dictionary<string, string>(){
                    {"Nickleback", "How you remind me"}
                },
                new Dictionary<string, string>(){
                    {"Nickleback", "Far Away"}
                },
                 new Dictionary<string, string>(){
                    {"Johnny Cash", "Ring of fire"}
                },
                new Dictionary<string, string>(){
                    {"Spoon", "Everything hits at once"}
                },
            };
            foreach(Dictionary<string, string> songDictionary in allsongs){
                foreach(KeyValuePair<string, string> songKeyValuePair in songDictionary){
                    if(songKeyValuePair.Key != "Nickleback"){
                        goodsongs.Add(songDictionary);
                    }
                }
            }
            foreach(Dictionary<string,string> songDictionary in goodsongs){
                foreach(KeyValuePair<string, string> songKeyValuePair in songDictionary){
                    Console.WriteLine($"{songKeyValuePair.Key} : {songKeyValuePair.Value}");
            }}
    }
}
}

