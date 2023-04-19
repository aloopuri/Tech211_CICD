namespace FourPillarsApp
{
    public interface IMoveable
    {
        public virtual string Move()
        {
            return "Going along";
        }

        public string Move(int times);
    }
}