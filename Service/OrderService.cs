﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSaleService
{
    public class OrderService
    {
        public eSaleModel.Order GetOrderById(string id)
        {
            eSaleDao.OrderDao orderDao = new eSaleDao.OrderDao();
            return orderDao.GetOrderById(id);
        }
    }
}
