﻿using WebSales.Data;
using System.Collections.Generic;
using System.Linq;
using WebSales.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebSales.Services
{
    public class DepartmentService
    {
        private readonly WebSalesContext _context;

        public DepartmentService(WebSalesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
