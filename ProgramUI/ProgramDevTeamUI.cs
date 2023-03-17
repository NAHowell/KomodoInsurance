using System;
using _DevTeam;



//done

public class ProgramDevTeamUI
{
    private TeamContentRepo _teamContent = new TeamContentRepo();

    public void Run()
    {
        SeedData();
        Menu();
    }


    private void Menu()
    {
        bool keeprunning = true;
        while (keeprunning)
        {
            
            Console.Clear();

            System.Console.WriteLine(
                "Select a menu option:\n" +
                "1. Create new team\n" +
                "2. View all teams\n" +
                "3. Update existing team\n" +
                "4. Remove existing team\n" +
                "5. Exit"
            );


            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    CreateNewTeam();
                    break;
                case "2":
                    ViewAllTeams();
                    break;
                case "3":
                    UpdateExistingTeams();
                    break;
                case "4":
                    RemoveExistingTeams();
                    break;
                case "5":
                    System.Console.WriteLine("Good Bye");
                    keeprunning = false;
                    break;
                default:
                    System.Console.WriteLine("please enter a valid number!");
                    break;
            }
            System.Console.WriteLine("please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }

    private void CreateNewTeam()
    {
        Console.Clear();
        TeamContent newContent = new TeamContent();

        System.Console.WriteLine("Enter the Team name of the group:");
        newContent.TeamName = Console.ReadLine();

        System.Console.WriteLine("Enter the members of the team:");
        newContent.MemberNames = Console.ReadLine();

        System.Console.WriteLine("Enter the Id number of the team");
        string TeamIdString = Console.ReadLine();
        newContent.TeamId = double.Parse(TeamIdString);

        _teamContent.AddoContenttolist(newContent);
    }



    private void ViewAllTeams()
    {
        Console.Clear();
        List<TeamContent> ListOfContent = _teamContent.GetContentList();

        foreach (TeamContent content in ListOfContent)
        {
            System.Console.WriteLine($"Team Name: {content.TeamName}\n Team Id: {content.TeamId}\n Team Members: {content.MemberNames}");
        }
    }



    private void UpdateExistingTeams()
    {
        ViewAllTeams();

        System.Console.WriteLine("Enter the Team Name of the team you want to change:");

        string oldTeamName = Console.ReadLine();

        TeamContent newContent = new TeamContent();

        System.Console.WriteLine("Enter the Team Name:");
        newContent.TeamName = Console.ReadLine();

        System.Console.WriteLine("Enter the Id of the Team:");
        string TeamIdString = Console.ReadLine();
        newContent.TeamId = double.Parse(TeamIdString);

        System.Console.WriteLine("enter the members of the team:");
        newContent.MemberNames = Console.ReadLine();

        bool wasUpdated = _teamContent.UpdateContent(oldTeamName, newContent);

        if (wasUpdated)
        {
            System.Console.WriteLine("content was successfully updated!");
        }
        else
        {
            System.Console.WriteLine("could not update content....");
        }
    }



    private void RemoveExistingTeams()
    {
        ViewAllTeams();

        System.Console.WriteLine("Enter the Team Name of the team you want to remove");
        string input = Console.ReadLine();

        bool wasDeleted = _teamContent.RemoveContent(input);

        if (wasDeleted)
        {
            System.Console.WriteLine("The content was removed.");
        }
        else
        {
            System.Console.WriteLine("The content was not removed.");
        }
    }

    private void SeedData()
    {
        TeamContent TeamA = new TeamContent("Team A", "Tom Badger, Zack Mulith", 40004231);
        TeamContent TeamB = new TeamContent("Team B", "John Smith, Dennis Hall", 40004789);
        TeamContent TeamC = new TeamContent("Team C", "Noah Howell, Seth Howell", 40004543);

        _teamContent.AddoContenttolist(TeamA);
        _teamContent.AddoContenttolist(TeamB); 
        _teamContent.AddoContenttolist(TeamC);
    }


}