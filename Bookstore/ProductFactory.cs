/**
    * @brief 
    * @file ProductFactory.cs
    * @author Gizem Taşçı
    * @date 2019-04-25
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /**
    * @brief ProductFactory class
    * factory method design pattern kullanılmıştır.
    */
   
    class ProductFactory
    {
     /**
   * @brief  FactoryMethod fuction
   * @param choise
   * @param name
   * @param price
   * @param stock
   * @param bl
   * Seçilen ürüne göre nesne oluşturup ID ataması yapar.
   */
        static public Product FactoryMethod(string choice,string name,double price, int stock,bool bl)
        {
            long ID = (bl)?(int.Parse(GetID())):0;//unique ID

            Product objChosen = null;
            if (choice == "Book")
            {
                objChosen = new Book(name,ID,price,stock);
            }

            if (choice == "Magazine")
            {
                objChosen = new Magazine(name, ID, price,stock);
            }

            if (choice == "MusicCD")
            {
                objChosen = new MusicCD(name, ID, price, stock);
            }
            return objChosen;
        }
        /**
  * @brief  GetID fuction
  * Unique ID ataması yapar.
  * @return numericUniqueID.Substring(0, 6)
  */
        public static string GetID()
        {
            string uniqueID = Guid.NewGuid().ToString();
            string numericUniqueID = string.Empty;
            foreach (char item in uniqueID)
            {
                if (char.IsNumber(item)) 
                {
                    numericUniqueID += item;
                }
            }
            return numericUniqueID.Substring(0, 6);
        }
    }
}
