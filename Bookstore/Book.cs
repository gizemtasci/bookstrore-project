/**
    * @brief 
    * @file Book.cs
    * @author Faruk Aydın
    * @date 2019-04-25
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BookStore
{
    /**
    * @brief Book class
    * Product class'ından türetilmiştir. 
    * kitap nesnelerini id, ücret, adet gibi verilerin yapısını kapsar. 
    */
    
    class Book:Product
    {
        /**
         * @brief  constructor Book fuction
         * @param name
         * @param id
         * @param price
         * @param stock
        */
        public Book(string name, long id, double price,int stock) : base()
        {
            Name = name;
            ID = id;
            Price = price;
            Stock = stock;
        }
        public Book() { }

        /**
         * @brief  Author fuction
         * Yazar bölümünün get set metotlarını tutar.
        */
        public string Author { get; set; }

        /**
        * @brief  Publisher fuction
        * Yayıncı bölümünün get set metotlarını tutar.
       */
        public string Publisher { get; set; }

        /**
       * @brief  Page fuction
       * Sayfa bölümünün get set metotlarını tutar.
       */
        public int Page { get; set; }

        /**
      * @brief  ISBN fuction
      * ISBN bölümünün get set metotlarını tutar.
     */
        public string ISBN { get; set; }
        /**
        * @brief  PrintProperties fuction
        * overriding method
        * Ürünün özelliklerini döndürmek için kullanılan fonksiyondur.
        * @return ID + "%" + Name + "%" + Author + "%" + Publisher + "%" + ISBN + "%" + Page + "%" + Stock + "%" + Price.ToString("C")
       */
        
        public override string PrintProperties()
        {
            return ID + "%" + Name + "%" + Author + "%" + Publisher + "%" + ISBN + "%" + Page + "%" + Stock + "%" + Price.ToString("C");
        }       
     }
}
