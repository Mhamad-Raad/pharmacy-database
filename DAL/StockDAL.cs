using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDA.DAL.DataSet1TableAdapters;

namespace SDA.DAL
{
    public class StockDAL
    {
        stockTableAdapter sta = new stockTableAdapter();

        public List<Stock> list()
        {
            List<Stock> list = new List<Stock>();
            foreach (DataSet1.stockRow row in sta.GetData())
            {
              Stock stock = new Stock();
                stock.name = row.name;
                stock.price = (double)row.price;
                stock.quantity = row.stock;
                stock.description = row.description;
                stock.id = row.id;

                list.Add(stock);

            }

            return list;

        }

        public Stock getMedicine(String name) {
            Stock stock = new Stock();

            foreach (DataSet1.stockRow row in sta.GetData())
            {
                if(name == row.name)
                {
                    stock.name = row.name;
                    stock.price = (double)row.price;
                    stock.quantity = row.stock;
                    stock.description = row.description;
                    stock.id = row.id;
                    
                    return stock;
                }

            }

            return null;
                
        }

        public String Delete(Stock stock)
        {
            
            if(stock.quantity -1 == 0)
            {
                int i = sta.DeleteQuery(stock.id);
                if (i > 0)
                    return "Sold";
                else
                    return "Process failed";
            }

            else
            {
               int i= sta.UpdateQuery(stock.name, stock.description, stock.quantity-1, stock.id, (decimal)stock.price,stock.id);
                if (i > 0)
                    return "Sold";
                else
                    return "Process failed";
            }
           
        }

        public String Add(Stock stock)
        {   
           int i =  sta.Add(stock.name,stock.description, stock.quantity, stock.id, (decimal)stock.price);

            if (i > 0)
                return "Operation Successful";
            else
                return "there was an error please try again";
        }
    }
}