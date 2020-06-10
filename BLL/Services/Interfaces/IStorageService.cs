﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IStorageService
    {
        Task AddStorage();
        Task ChangeDescription();
        Task DeleteStorage();
    }
}
