using System.Runtime.CompilerServices;
System.Console.WriteLine("Please enter a number for either\n" + "1. Developer informtion\n" + "2. DevTeam informtion\n" + "Hit enter after you have typed your selection\n");
string option = Console.ReadLine();
switch (option)
{
    case "1":
        // Dev information
        ProgramDevUI program1 = new ProgramDevUI();
        program1.Run();
        break;
    case "2":
        // Dev team informtion
        ProgramDevTeamUI program2 = new ProgramDevTeamUI();
        program2.Run();
        break;
}