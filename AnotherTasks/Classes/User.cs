namespace AnotherTasks.Classes
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public short PinCode { get; set; }

        public User(string name, int age, short pinCode, string city = "Underfined")
        {
            Name = name;
            Age = age;
            City = city;
            PinCode = pinCode;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nГород: {City}\nПин-код: {PinCode}";
        }
    }
}
