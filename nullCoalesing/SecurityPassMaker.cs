namespace nullCoalesing
{
    internal class SecurityPassMaker
    {
        public string GetDisplayName(Object o)
        {
            if (o is Staff x)
            {
                return x.Title;
            }

            return "too high priority";
        }
    }
}
