namespace task5var22
{
    public abstract class ComandSport : Sport
    {
        public string name { get; set; }
        protected double prevalence;
        protected int comandPlayers;
        protected int NumberOfCommand;
        
        
        
        public ComandSport()
        {}

        
        public double promotion()
        {
            return (double) 7000000 * prevalence;
        }

        public double prize()
        {
            return 0.001 * promotion() / comandPlayers;
        }

        protected int funs()
        {
            return (int) promotion() / NumberOfCommand;
        }
    }
}