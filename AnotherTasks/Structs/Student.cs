namespace AnotherTasks.Structs
{
    struct Student
    {
        public Guid Id { get; } // индентификатор студента
        public string FirstName { get; set; } // имя 
        public string SurName { get; set; } // фамилия
        public DateTime DateOfBirthday { get; } // дата рождения
        public string KategoryOfAlcoholism { get; set; } // категория алкоголизма
        public double VolumeOfDrinks { get; set; } // объем выпитой жидкости
        public Drinks Drink {  get; set; } // напиток, который употребляет студент

        public Student(string FirstName, string SurName, DateTime DateOfBirthday, string Kategory, double VolumeOfDrinks, Drinks drink)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.DateOfBirthday = DateOfBirthday;
            this.VolumeOfDrinks = VolumeOfDrinks;
            this.KategoryOfAlcoholism = Kategory;
            this.Drink = drink;
        }
    }
}
