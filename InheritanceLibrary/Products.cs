using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public abstract  class Products
    {
        public int ProdID { get; set; }
        public string Prodname { get; set; }
        public int Price { get; set; }

        public abstract int Categoryid { get; set; }


     
    }

    public class PharmaceuticalProduct : Products
    {
        public DateTime ExpiryDate { get; set; }
        public override int Categoryid { get; set; }
    }

    public class HumanPharma : PharmaceuticalProduct
    { 
    
    }

    public class PetsPharma : PharmaceuticalProduct 
    {
    
    
    }






    public class ElectronicProduct : Products
    {
        public override int Categoryid { get ; set ; }
        public int WarrantyPeriod { get; set; }


    }


}
