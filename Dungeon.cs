namespace Dungeon
{
    internal class DungeonApplication
    {
        static void Main(string[] args)
        {
            //TODO Create A Player

            bool exit = false;

            do
            {
                do
                {

                    //TODO Create A Monster

                    //TODO Create A Room

                    bool reload = false;

                    Console.WriteLine("A. Attach\nB. Run Away\nC. Character Info\nD.Monster Info \nE. Exit");
                    string userChoice = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "A":
                            break;

                        case "B":
                            break;

                        case "C":
                            break;

                        case "D":
                            break;

                        case "E":
                            break;

                        default:
                            break;
                    }

                } while (true);
            } while (true);













        }
    }
}