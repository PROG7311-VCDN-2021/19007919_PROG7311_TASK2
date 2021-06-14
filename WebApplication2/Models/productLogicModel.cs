using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Controllers;
using WebApplication2.Models;

namespace WebApplication2.Models
{

    
    public class productLogicModel
    {
        ACME_DBEntities db = new ACME_DBEntities();
       
        public List<PRODUCT> products;

        

        public productLogicModel()
        {
            
            this.products = new List<PRODUCT>()
            {
                new PRODUCT
                {
                    PRODUCT_CODE = "ACC001",
                    PRODUCT_CATEGORY = "Computer Accessories",
                    PRODUCT_NAME = "Acme Inc Optical Mouse",
                    PRODUCT_PRICE = 299.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "ACC002",
                    PRODUCT_CATEGORY = "Computer Accessories",        
                    PRODUCT_NAME = "Acme Inc Mechanical Keyboard",
                    PRODUCT_PRICE = 599.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "ACC003",
                    PRODUCT_CATEGORY = "Computer Accessories",
                    PRODUCT_NAME = "Acme Inc 4K High FPS Monitor",
                    PRODUCT_PRICE = 9999.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "CLO001",
                    PRODUCT_CATEGORY = "Clothing",
                    PRODUCT_NAME = "Acme Inc Tee",
                    PRODUCT_PRICE = 299.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "CLO002",
                    PRODUCT_CATEGORY = "Clothing",
                    PRODUCT_NAME = "Acme Inc Beanie",
                    PRODUCT_PRICE = 199.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "CLO003",
                    PRODUCT_CATEGORY = "Clothing",
                    PRODUCT_NAME = "Acme Inc Back-Pack",
                    PRODUCT_PRICE = 499.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "PAR001",
                    PRODUCT_CATEGORY = "Computer Parts",
                    PRODUCT_NAME = "Acme ATX 3080 6GB",
                    PRODUCT_PRICE = 4999.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "PAR002",
                    PRODUCT_CATEGORY = "Computer Parts",
                    PRODUCT_NAME = "Acme MothershipX",
                    PRODUCT_PRICE = 2999.99M
                },
                new PRODUCT
                {
                    PRODUCT_CODE = "PAR003",
                    PRODUCT_CATEGORY = "Computer Parts",
                    PRODUCT_NAME = "Acme Turbine 8GB DDR4",
                    PRODUCT_PRICE = 999.99M
                }
              
            };
            
            
            
       }

       
       
public PRODUCT find(string id)
        {
           
          return  this.products.Single(p => p.PRODUCT_CODE.Equals(id));
           
            
        }
        
    }
    
}