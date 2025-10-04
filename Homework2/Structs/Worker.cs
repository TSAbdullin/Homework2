using Tumakov.Enums;

namespace Tumakov.Structs
{
    struct Worker
    {
        string name; // поле, которое хранит имя рабочего
        University University; // поле, которое хранит институт 

        public Worker(string name,  University university) // конструктор, позволяющий быстро создавать экземпляры
        {
            this.name = name;
            this.University = university;
        }

        public override string ToString() // ну просто переопределил метод ToString(), чтобы сделать красивый вывод
        {
            return $"Имя: {name}\nИнститут: {University}";
        }
    }
}
