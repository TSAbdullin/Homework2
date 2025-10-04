namespace AnotherTasks.Structs
{
    public struct Drinks
    {
        public string TitleOfDrink; // Название напитка
        public int PercentOfAlcohol; // Процент спирта в напитке

        public Drinks(string titleOfDrink, int PercentOfAlcohol)
        {
            this.TitleOfDrink = titleOfDrink;
            this.PercentOfAlcohol = PercentOfAlcohol;
        }
    }
}
