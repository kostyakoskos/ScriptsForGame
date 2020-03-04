//using UnityEngine;
using System;
using System.Collections.Generic;// для Icompareble.

// класс мана, унаследовать.
// класс какое-то начальное значение.
public class PlayerScript : IComparable<PlayerScript>
{
    //readonly - поля для чтения, можно менять только в конструкторе, в других местах можно только
    //считать их значение.
    private readonly int _id;//id не меня
    private readonly string _name;//readonly чтобы имя сделать константным
    private readonly int _age;
    // state
    private bool _sostoyanie;// может меняться
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
    private readonly bool human;
    private readonly bool _gnome;
    private readonly bool elf;
    private readonly bool ork;
    private readonly bool goblin;
    // about character
    //private bool male;
    //private bool female;
    private readonly bool _gender;// пол - const, true- male.
    public int health;
    public int maxhealth;// Изменяется с уровнем
    private int _exp;//опыт, ищменяется
    private int _mana;// изменяется
                      //public bool godMode;
                      //сортировка icomparable
    public int exp { set; get; }

    public string name//свойство для имени
    { get { return name; } }

    public int age// свойство возраст. Может быть от 2-х до 99.
    {
        get
        {
            return _age;
        }
        set
        {
            if (_age < 1 || age > 1000)
            {
                throw new ArgumentException();
            }
            else if (_age == 1000) // По законам этой вселенной тот, 
                                   //кто доживает до 1000-и лет, перерождается, сохраняя память от прошлой жизни!
            {
                age = 1;
            }
            else
            {
                age = _age;
            }
        }
    }

    public int id//свойство для id.
    { get { return id; } }

    public int mana//свойство для mana.
    { get { return mana; } }




    public PlayerScript() { }
    public PlayerScript(int id, string name, int age, bool gnome, bool gender, int exp, int health,
        int mana)
    // конструктор задающий начальные значения. По умолчанию - гном.
    {
        id = 1;
        while (id++ < 10)
        {
            _id = id;
        }
        _name = name;
        _age = age;
        _gnome = true;
        _gender = true;
        health = 100;
        this.exp = exp;
        _mana = mana = 1000;
        normal = true;
    }
    public int CompareTo(PlayerScript obj)//универсальная сортировка icomparable
    {
        if ((this.exp + this.age) > (obj.exp + obj.age))
            return 1;
        else if ((this.exp + this.age) < (obj.exp + obj.age))
            return -1;
        else
            return 0;
    }
    public override string ToString()
    {
        return String.Format("{0}\tопыт:", this.exp);
    }



   



    private void Start()
    {
        normal = true;
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

}
class Program
{
    static void Main()
    {
        List<PlayerScript> dic = new List<PlayerScript>();

        // Создадим множество автомобилей
        dic.Add(new PlayerScript(1, "vova1", 90, true, true, 10000, 100, 0));
        dic.Add(new PlayerScript(1, "vova2", 90, true, true, 300000, 100, 0));
        dic.Add(new PlayerScript(1, "vova", 90, true, true, 2000, 100, 0));

        Console.WriteLine("Исходный опыт: \n");
        foreach (PlayerScript a in dic)
            Console.WriteLine(a);

        Console.WriteLine("\nТеперь сортировка по опыту: \n");
        dic.Sort();
        foreach (PlayerScript a in dic)
            Console.WriteLine(a);
        Console.ReadKey();
    }
}