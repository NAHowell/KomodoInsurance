//done


namespace _DevTeam
{
    public class TeamContentRepo
    {
        private List<TeamContent> _TeamList = new List<TeamContent>();

        public void AddoContenttolist(TeamContent content)
        {
            _TeamList.Add(content);
        }

        public List<TeamContent> GetContentList()
        {
            return _TeamList;
        }

        public bool UpdateContent(string originalNames, TeamContent newContent)
        {
            TeamContent oldContent = GetContent(originalNames);

            if (oldContent != null)
            {
                oldContent.MemberNames = newContent.MemberNames;
                oldContent.TeamName = newContent.TeamName;
                oldContent.TeamId = newContent.TeamId;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveContent(string teamName)
        {
            TeamContent content = GetContent(teamName);
            if (content == null)
            {
                return false;
            }
            int initialCount = _TeamList.Count;
            _TeamList.Remove(content);
            if (initialCount > _TeamList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TeamContent GetContent(string teamName)
        {
            foreach (TeamContent content in _TeamList)
            {
                if (content.TeamName.ToLower() == teamName.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
    }
}