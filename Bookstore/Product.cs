/**
    * @brief 
    * @file Product.cs
    * @author Fatma Karakaya
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
    * @brief Product class
    * Abstract class'tır.
    */
    
    public abstract class  Product
    {
        /**
    * @brief  Name fuction
    * İsim bölümünün get set metotlarını tutar.
    *
    */
        public string Name { get; set; }
        /**
    * @brief  ID fuction
    * ID bölümünün get set metotlarını tutar.
    *
    */
        public long ID { get; set; }
        /**
    * @brief  Price fuction
    * Ücret bölümünün get set metotlarını tutar.
    *
    */
        public double Price { get; set; }
        /**
    * @brief  Stock fuction
    * Stok bölümünün get set metotlarını tutar.
    *
    */
        public int Stock { get; set; }
        /**
    *@brief  CloneIT fuction
    *Pruduct nesnesini klonlar.
    *@return (Product)this.MemberwiseClone();
    */
      
        public Product CloneIT()
        {
            return (Product)this.MemberwiseClone();
        }
        /**
   * @brief  PrintProperties abstract fuction
   * Abstract methottur.
   */
        
        public abstract string PrintProperties();
    }
}
