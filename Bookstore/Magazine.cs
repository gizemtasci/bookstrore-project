/**
    * @brief 
    * @file Magazine.cs
    * @author Faruk Aydın
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
    * @brief  TypeOfMagazine enum
    * Dergi tiplerini belirtir.
    */
    enum TypeOfMagazine
    {
        Business, Sport, Computer, Technology, Humor, Science,Fashion
    }
   

    /**
    * @brief  magazine class
    * Product class'ından türetilmiştir.
    */
    class Magazine : Product
    {
        /**
    * @brief  Magazine constructor function
    * @param name
    * @param id
    * @param price
    * @param stock
    * 
    */

        public Magazine(string name, long id, double price, int stock):base()
        {
            Name = name;
            ID = id;
            Price = price;
            Stock = stock;
        }
        public Magazine() { }

        /**
      * @brief  Issue fuction
      * Durum bölümünün get set metotlarını tutar.
      *
      */
        public string Issue { get; set; }
        /**
            * @brief  MagType fuction
            * Dergi tipleri bölümünün get set metotlarını tutar.
            *
           */
        public TypeOfMagazine MagType { get; set; }
        /**
        * @brief  PrintProperties function
        * Dergilerin özelliklerini döndürür.
        * @return ID + "%" + Name + "%" + MagType.ToString() + "%" + Issue + "%" + Stock + "%" + Price.ToString("C")
        */

        public override string PrintProperties()
        {
            return ID + "%" + Name + "%" + MagType.ToString() + "%" + Issue + "%" + Stock + "%" + Price.ToString("C");
        }
    }
}
