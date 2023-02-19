using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            twitchStream.name = "Luna Hilversum";
            twitchStream.lastStreamName = "Playing hogwarts legacy join now ---follow friday--- *!!*^#@HITTING 2000 SUBS@&#(@&";
            twitchStream.streamGame = (new Game("My little Pony"));
            twitchStream.followers = 1598;
            twitchStream.automod= true;


            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?



            Console.WriteLine("Hello, World!");
            Console.WriteLine("Streamer: " + twitchStream.name);
            Console.WriteLine("Last stream name: " + twitchStream.lastStreamName);
            Console.WriteLine("Now playing: " + twitchStream.streamGame);
            Console.WriteLine("Followers: " + twitchStream.followers);
            Console.WriteLine("Automod: " + twitchStream.automod);
        }
    }
}