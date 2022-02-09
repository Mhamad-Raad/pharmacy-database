using SDA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDA.BLL
{
    public class Observer
    {
        public List<Stock> notify()
        {
            StockDAL s = new StockDAL();
            List<Stock> stocks = s.list();
            List<Stock> notes = new List<Stock>();
            foreach (Stock stock in stocks)
            {
                if(stock.quantity == 1)
                {
                    notes.Add(stock);
                }
            }

            if(notes.Count > 0)
                return notes;

            else
                return null;
        }


    }
}