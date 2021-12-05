using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        /*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
        - абстрактное свойство - название животного.
        В классе Animal нужно определить следующие методы:
        - конструктор, устанавливающий значение по умолчанию для названия;
        - абстрактный метод Say(), который выводит звук, который издает животное;
        - неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
        - Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
        - свойство – название животного;
        - метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
        Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.ShowInfo();
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }

        abstract class Animal
        {
            public abstract string NameAnimal { get; set; }
            public Animal()
            {
                NameAnimal = "Животное";
            }
            public abstract string Say();
            public void ShowInfo()
            {
                Console.WriteLine("{0} {1}", NameAnimal, Say());
            }
        }
        class Cat : Animal
        {
            string name;
            public override string NameAnimal
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Матроскин";
                }
            }
            public override string Say()
            {
                return "Мяу";
            }
        }
        class Dog : Animal
        {
            string name;
            public override string NameAnimal
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Шарик";
                }
            }
            public override string Say()
            {
                return "Гав";
            }
        }


        /*abstract class Figure
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
            public abstract string Name { get; set; }
        }

        class Rectangular: Figure
        {
            string name;
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea()
            {
                return Width * Height;
            }
            public override double GetPerimeter()
            {
                return (Width + Height) * 2;
            }
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }*/
    }
}
