using System;

namespace DelegateExample;
class Program
{
    static void Main(string[] args)
    {
        //создание монитора
        StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
        //регистрация метода в делегате
        stockExchangeMonitor.PriceChangeHandler = ShowPrice;
        //запуск монитора
        stockExchangeMonitor.Start();
    }
    //метод вывода текущей цены на консоль
    public static void ShowPrice(int price)
    {
        Console.WriteLine($"New Price is {price}");
    }
}
