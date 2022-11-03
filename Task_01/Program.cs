using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выучите описание шаблона Template method (Шаблонный метод). 
             * Обратите внимание на применимость шаблона, а также на состав его участников и связи отношения между ними. 
             * Напишите небольшую программу на языке C#, представляющую собой абстрактную реализацию данного шаблона. 
             */

            while (true)
            {
                Console.Write("Введите версию подписки - Bas, Pro или Pre: ");
                string licence = Console.ReadLine();

                switch (licence)
                {
                    case "Bas":
                        new Subscription().ShowInfo();
                        break;
                    case "Pro":
                        (new SpecialSubscription() as Subscription).ShowInfo();
                        break;
                    case "Pre":
                        new SpecialSubscription().ShowInfo();
                        break;
                    default:
                        return;
                }

                Console.ReadKey();
            }
        }
    }
    class Subscription
    {
        public virtual void ShowInfo()
        {
            PricePolicy();
            UsagePolicy();
            TermPolicy();
        }
        public virtual void PricePolicy() { 
            Console.WriteLine("Стоимость подписки 5$"); 
        }
        public virtual void UsagePolicy() {
            Console.WriteLine("Размер файлов не более 5Gb");
        }
        public virtual void TermPolicy() {
            Console.WriteLine("Время хранения файлов 6 мес.");
        }
    }
    class SpecialSubscription : Subscription
    {
        public new void ShowInfo()
        {
            PricePolicy();
            UsagePolicy();
            TermPolicy();
        }
        public override void PricePolicy()
        {
            Console.WriteLine("Стоимость подписки 10$");
        }
        public new void UsagePolicy()
        {
            Console.WriteLine("Размер файлов не более 50Gb");
        }
        public new void TermPolicy()
        {
            Console.WriteLine("Время хранения файлов 5 лет.");
        }
    }
}
