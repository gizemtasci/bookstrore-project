/**
    * @brief 
    * @file ItemToPurchase.cs
    * @author Gizem Taşçı
    * @date 2019-04-25
    */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /**
    * @brief  ItemToPurchase class
    * Satın alınacak ürünlerin tipini ve miktarını tutan class'tır.
    */
   
    public class ItemToPurchase 
    {
        /**
       * @brief  Product fuction
       * Ürün bölümünün get set metotlarını tutar.
       * Product nesnesindenn türetilen nesnelerin bilgilerini döndürür.
      */
        public Product Product { get; set; }
        /**
       * @brief  Quantity fuction
       * Miktar bölümünün get set metotlarını tutar.
      */
        public int Quantity { get; set; }
    }
}
