using System;
using System.Threading;

namespace DelegateExample
{
    public class StockExchangeMonitor
    {
        //делегат оповещающий всех клиентов об изменении акций
        public delegate void PriceChange(int price);
        //свойство для регистрации клиентом ссылки на метод, считывающий цену
        public PriceChange? PriceChangeHandler { get; set; }
        //метод запуска монитора акций
        public void Start()
        {
            while (true)
            {
                //текущая цена на акцию
                int bankOfAmericaPrice = (new Random()).Next(100);
                //оповещение клиентов о новой цене акции (запуск подписанных клиентских методов)
                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }
    }
}
