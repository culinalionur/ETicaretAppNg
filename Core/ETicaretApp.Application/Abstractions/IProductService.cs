﻿using ETicaretApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
