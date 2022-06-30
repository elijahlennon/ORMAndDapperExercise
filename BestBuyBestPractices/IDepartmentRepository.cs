using System;
using System.Collections.Generic;
using BestBuyBestPractices;

namespace IntroSQL
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
