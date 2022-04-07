namespace task5var22
{
    public class Soccer : ComandSport
    {
        private int capacity;
        private double cost;
        
        
        public Soccer(string name, double prevalence, int comandPlayers, int NumberOfCommand, int capacity, double cost)
        {
            this.name = name;
            this.prevalence = prevalence;
            this.comandPlayers = comandPlayers;
            this.NumberOfCommand = NumberOfCommand;
            this.capacity = capacity;
            this.cost = cost;
        }


        public double profit()
        {
            return capacity * cost;
        }

        public double finance()
        {
            return profit() + promotion() - prize();
        }


        public override string ToString()
        {
            return $"Летний вид спорта: {name}\nПопулярность: {prevalence}\n" +
                   $"Кол-во комманд: {NumberOfCommand}\nКол-во игроков в комманде: {comandPlayers}\n" +
                   $"Призовые: {prize()}\nФанбаза: {funs()}\n Прибыль: {profit() + promotion()}\n" +
                   $"Итог по финансам: {finance()}";

        }
    }
}