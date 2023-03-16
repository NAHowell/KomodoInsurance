//done


namespace _Developer
{
    public class DeveloperRepo
    {
        private List<DeveloperContent> _DevList = new List<DeveloperContent>();

        public void AddContentToList(DeveloperContent content)
        {
            _DevList.Add(content);
        }

        public List<DeveloperContent> Getcontent()
        {
            return _DevList;
        }

        public bool UpdateContent(string originalName, DeveloperContent newContent)
        {
            DeveloperContent oldContent = GetContentByName(originalName);

            if (oldContent != null)
            {
                oldContent.Name = newContent.Name;
                oldContent.Id = newContent.Id;
                oldContent.PluralSight = newContent.PluralSight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveContent(string name)
        {
            DeveloperContent content = GetContentByName(name);
            if (content == null)
            {
                return false;
            }
            int initialCount = _DevList.Count;
            _DevList.Remove(content);
            if (initialCount > _DevList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DeveloperContent GetContentByName(string name)
        {
            foreach (DeveloperContent content in _DevList)
            {
                if (content.Name.ToLower() == name.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

    }
}