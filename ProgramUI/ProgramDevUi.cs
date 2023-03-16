using _Developer;


// done

public class ProgramDevUI
{
    private DeveloperRepo _Devlist = new DeveloperRepo();

    public void Run()
    {
        Menu();
    }

    private void Menu()
    {
        bool keeprunning = true;
        while (keeprunning)
        {
            Console.Clear();

            System.Console.WriteLine(
                "Select an option\n" +
                "1. Create new Developer\n" +
                "2. View all Developers and their information\n" +
                "3. Update existing Developer\n" +
                "4. Remove existing Developer\n" +
                "5. Exit\n"
            );

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //create new dev
                    CreateNewDev();
                    break;
                case "2":
                    //view dev info
                    DisplayDevInfo();
                    break;
                case "3":
                    //update existing dev
                    UpdateExistingDev();
                    break;
                case "4":
                    //remove existing dev
                    RemoveExistingDev();
                    break;
                case "5":
                    //exit
                    System.Console.WriteLine("Good Bye");
                    keeprunning = false;
                    break;
                default:
                    System.Console.WriteLine("Please enter a valid number!");
                    break;
            }
            System.Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();

        }
    }

    private void CreateNewDev()
    {
        Console.Clear();
        DeveloperContent newContent = new DeveloperContent();

        // name
        System.Console.WriteLine("Enter the Name of the Developer:");
        newContent.Name = Console.ReadLine();

        // Id 
        System.Console.WriteLine("Enter the Id of the Developer:");
        string IdAsString = Console.ReadLine();
        newContent.Id = double.Parse(IdAsString);

        // PluralSight
        System.Console.WriteLine("Enter if the Developer can use PluralSight (y/n):");
        string PluralSightString = Console.ReadLine().ToLower();
        if (PluralSightString == "y")
        {
            newContent.PluralSight = true;
        }
        else
        {
            newContent.PluralSight = false;
        }

        _Devlist.AddContentToList(newContent);
    }

    private void DisplayDevInfo()
    {
        Console.Clear();
        List<DeveloperContent> ListOfContent = _Devlist.Getcontent();
        foreach (DeveloperContent content in ListOfContent)
        {
            System.Console.WriteLine($"Name: {content.Name} Id: {content.Id} PluralSight Access: {content.PluralSight}\n");
        }
    }

    private void UpdateExistingDev()
    {
        DisplayDevInfo();

        System.Console.WriteLine("Enter the Name of the person you want to Update:");

        string oldName = Console.ReadLine();

        DeveloperContent newContent = new DeveloperContent();

        System.Console.WriteLine("Enter the Developers Name:");
        newContent.Name = Console.ReadLine();

        System.Console.WriteLine("Enter the Id of the Person:");
        string IdAsString = Console.ReadLine();
        newContent.Id = double.Parse(IdAsString);

        System.Console.WriteLine("Does this person have access to PluralSight(y/n)");
        string PluralSightString = Console.ReadLine().ToLower();
        if (PluralSightString == "y")
        {
            newContent.PluralSight = true;
        }
        else
        {
            newContent.PluralSight = false;
        }

        bool wasUpdated = _Devlist.UpdateContent(oldName, newContent);

        if (wasUpdated)
        {
            System.Console.WriteLine("content seccessfully updated!");
        }
        else
        {
            System.Console.WriteLine("could not update the content....");
        }
    }

    private void RemoveExistingDev()
    {
        DisplayDevInfo();

        System.Console.WriteLine("Enter the Name of the person you want to remove:");
        string input = Console.ReadLine();

        bool wasDeleted = _Devlist.RemoveContent(input);

        if (wasDeleted)
        {
            System.Console.WriteLine("The Person was removed.");
        }
        else
        {
            System.Console.WriteLine("The person was not removed.");
        }
    }

}