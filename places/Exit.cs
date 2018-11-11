namespace eskayrim
{
    public class Exit
    {
        public Room direction;
        public string description;

        public Exit(Room to, string desc)
        {
            direction = to;
            description = desc;
        }
    }
}