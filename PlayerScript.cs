//using UnityEngine;
using System;
// класс мана, унаследовать.
// класс какое-то начальное значение.
public class PlayerScript //: MonoBehaviour
{
    //readonly - поля для чтения, можно менять только в конструкторе, в других местах можно только
    //считать их значение.
    private readonly int _id;//id не меня
    private readonly string _name;//readonly чтобы имя сделать константным
    private readonly int _age;
    // state
    private bool sostoyanie;// может меняться
    //enum
    //когда зарождается, персонажк придать начальное состояние.
    // в кадом действии опускаться на ступеньку ниже, ниже минимаьного не опустимся
    // возраст в какихто пределах(1-100..)
    // статическая переменна и +1
    private bool normal;
    private bool weakened;
    private bool sick;
    private bool poison;
    private bool paralyzed;
    private bool dead;
    private bool move;
    // race
    private bool human;
    private bool gnome;
    private bool elf;
    private bool ork;
    private bool goblin;
    // about character
    //private bool male;
    //private bool female;
    private readonly bool gender;// пол - const
    private int health;
    private int max_health;// Изменяется с уровнем
    private int exp;//опыт, ищменяется
    private int mana;// изменяется
    //public bool godMode;

    public Sample1(int id, string name, int age)// конструктор
    {
        _id = id;
        _name = name;
        _age = age;
    }



    //public PlayerScript( int id, string name)
    //{
    //    Id = id;
    //    Name = name;
    //}
    // сделать константными имя...
    //public int id//свойства id
    //{
    //    get//возвращает значение, сет котролтрует, выбрасывает исключения
    //    {
    //        return Id;
    //    }
    //    set
    //    {
    //        if (value < 0)
    //            throw new ArgumentException();
    //        id = value;
    //    }
    //}
    //public string name
    //{ get { return Name; } }
    public override string ToString()
    {
        return ToString("G");
    }
    public string ToString(string fmt)
    {
        if (string.IsNullOrEmpty(fmt))
            fmt = "G";

        switch (fmt.ToUpperInvariant())
        {
            case "G":
                return string.Format("{0} {1}", _id, _name);

            default:
                string msg = string.Format("'{0}' is an invalid format string", fmt);
                throw new ArgumentException(msg);
        }
    }

    public PlayerScript(int id, string name, int max_health, bool gender)
    {
        id = 0;
        name = 0;
        max_health = 0;
        male = 0;
        female = 0;
    }



    private void Start()
    {
        normal = true;
    }
    // через интерфейс компэрэбл, сделать универсальным,  в качестве параметров сравнить по возрасту и опыту....
    // метод сортировки свой прописать(самых опытных...)
    void PlayersExp(GameObject enemy)//сравнение персонажей по опыту
    {
        PlayerScript playerScript;
        playerScript = enemy.GetComponent<PlayerScript>();
        int difference = exp - playerScript.exp;

        if (difference > 0)
        {
            //TODO

        }
        else
        {

            //TODO

        }


    }

    // функция update, при переходе состояний
    void Update()
    {
        if (health <= health * 0.1)
        {

            weakened = true;

        }
        else
        {
            weakened = false;
            normal = true;

        }

        if (health == 0)
        {

            dead = true;

        }
    }

    public static void Main()
    {
        Sample1 sample = new Sample1(5);//три строчки для вывода id
        Console.WriteLine(sample._id);
        Console.ReadKey();


        Object obj = new Object();
        Console.WriteLine(obj.ToString());
    }
}