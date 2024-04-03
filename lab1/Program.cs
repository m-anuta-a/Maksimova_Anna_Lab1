using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1;

internal static class Program
{
    public static void Main(string[] args)
    {
        //Rational
        Rational rational;

        //Tree
        var Book = new Tree("Все");
        var fantasy = new Tree ("Фэнтези", Book);
        var english_classic = new Tree ("Английская классика", Book);
        var rouling = new Tree("Джоан Роулинг", fantasy);
        var gir = new Tree("Керстин Гир", fantasy);
        var hp1 = new Tree("Гарри Поттер и Философский камень", rouling);
        var hp2 = new Tree("Гарри Поттер и Тайная комната", rouling);
        var hp3 = new Tree("Гарри Поттер и Узник Азкабана", rouling);
        var timeless1 = new Tree("Рубиновая книга", gir);
        var timeless2 = new Tree("Изумрудная книга", gir);
        var timeless3 = new Tree("Сапфировая книга", gir);
        var shekspir = new Tree("Уильям Шекспир", english_classic);
        var osten = new Tree("Джейн Остин", english_classic);
        var charls = new Tree("Чарльз Диккенс", english_classic);
        //fantasy.PrintList();
        //english_classic.PrintList();
        Book.PrintList();




    }
}
