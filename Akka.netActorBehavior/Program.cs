
// See https://aka.ms/new-console-template for more information
using Akka.Actor;
using Akka.netActorBehavior;

Console.WriteLine("Hello, World!");
ActorSystem system = ActorSystem.Create("my-first-akka");

IActorRef musicPlayer = system.ActorOf<MusicPlayerActor>("musicPlayer");

musicPlayer.Tell(new PlaySongMessage("Smoke on the water"));

musicPlayer.Tell(new PlaySongMessage("Another brick in the wall"));

musicPlayer.Tell(new StopPlayingMessage());

musicPlayer.Tell(new StopPlayingMessage());

musicPlayer.Tell(new PlaySongMessage("Another brick in the wall"));

Console.Read();

system.Terminate();