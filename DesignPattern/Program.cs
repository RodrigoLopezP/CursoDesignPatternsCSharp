using DesignPattern.FactoryPattern;
using DesignPattern.Models;
using DesignPattern.RepositoryPattern;
using DesignPattern.StrategyPattern;
using DesignPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inizio FactoryPattern
            SaleFactory storeSaleFactory = new StoreSaleFactory(15);//extra di 
            SaleFactory internetSaleFactory = new InternetSaleFactory(5);//sconto di

            ISale sale1 = storeSaleFactory.GetSale(); //gli butta una classe StoreSale
            sale1.Sell(50);//farà il metodo che c'è nella store sale

            ISale sale2= internetSaleFactory.GetSale();//gli butta una classe InternetSale
            sale2.Sell(120);
            //Fine FactoryPattern


            //var context = new Context(new CarStrategy());
            //context.Run();
            //context.Strategy = new MotoStrategy();
            //context.Run();
            //context.Strategy = new BicycleStrategy();
            //context.Run();
        }
    }
}
