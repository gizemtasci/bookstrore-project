/**
    * @brief 
    * @file MusicCD.cs
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
   * @brief  TypeOfMusic enum
   * Müzik tiplerini belirtir.
   */
    enum TypeOfMusic
    {
        Rock, Country, HipHop, Classic, ProgressiveRock, Pop, Folk
    }
    /**
    * @brief  Music class 
    * Product class'ından türetilmiştir.
    */
    
    class MusicCD : Product
    {
      
        /**
      * @brief  Singer fuction
      * Şarkıcı bölümünün get set metotlarını tutar.
      *
      */
        public string Singer { get; set; }
        /**
     * @brief  MusType fuction
     * Müzik tipleri bölümünün get set metotlarını tutar.
     *
     */
        public TypeOfMusic MusType { get; set; }
        /**
     * @brief  MusicCD constructor function
     * @param name
     * @param id
     * @param price
     * @param stock
     */
        public MusicCD(string name, long id, double price, int stock) : base()
        {
            Name = name;
            ID = id;
            Price = price;
            Stock = stock;
        }
        public MusicCD() { }
        /**
        * @brief  PrintProperties function
        * Müziklerin özelliklerini döndürür.
        * @return ID + "%" + Name + "%" + Singer + "%" + MusType.ToString() + "%" + Stock + "%" + Price.ToString("C")
        */
        
        public override string PrintProperties()
        {
            return ID + "%" + Name + "%" + Singer + "%" + MusType.ToString() + "%" + Stock + "%" + Price.ToString("C");
        }
    }
}
