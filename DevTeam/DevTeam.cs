//done


namespace _DevTeam
{
    public class TeamContent
    {
       public string TeamName { get; set; }
       public string MemberNames { get; set; }
        public double TeamId { get; set; }

        public TeamContent( ) { }
        public TeamContent(string teamName)
        {
            TeamName = teamName;
        }

        public TeamContent(string teamName, string memberNames, double teamId)
        {
            MemberNames = memberNames;
            TeamName = teamName;
            TeamId = teamId;
        }
    }
}