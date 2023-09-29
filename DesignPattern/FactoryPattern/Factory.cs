using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    /*
    * INICIO JERARQUIZACION DE NUESTRO FACTORY
    */
    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }

    // Creator
    public abstract class SaleFactory
    {
        //questo metodo astratto restituisce un ogg di tipo ISALE
        public abstract ISale GetSale();
    }
    /*
     * FIN JERARQUIZACION DE NUESTRO FACTORY
     */

    /*Queste sono le classi nelle quali viene implementata la gerarchia sopra
     * la finalità e che poi possiamo instaziare un ogg di tipo SaleFactoy
     * e poi fare new StoreSaleFactory() o InternetSaleFactory(), dipendendo da quello che vogliamo che faccia la classe SELL
     * in questo modo abbiamo reso la sua dichiarazione dinamica, e se volessimo creare un'altra classe di tipo SaleFactory
     * ma con un comportamente diverso, basta creare un altro di questi Concrete Product
     */
    // Concrete Product
    public class StoreSale : ISale  //classe creata da questa factory
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        /// <summary>
        /// Verrà fatto un somma per calcolare il totale effettivo guadagnato
        /// </summary>
        /// <param name="total"></param>
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}");
        }
    }

    /// <summary>
    /// Verrà fatto una sottrazione, tenendo in conto che in questa classe è impostato uno sconto
    /// </summary>
    /// <param name="total"></param>
    public class InternetSale : ISale //classe creata da questa factory
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en INTERNET tiene un total de {total - _discount}");
        }
    }

 
    // Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
            //torna un uno StoreSale, presentando come ISALE,
            //dato che ha l interfaccia quindi questo basta
        }
    }

    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }
        public override ISale GetSale()
        {
            return new InternetSale(_discount);
            //torna un uno InternetSale, presentando come ISALE,
            //dato che ha l interfaccia quindi questo basta
        }
    }
}
