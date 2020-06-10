using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    interface IStorageService
    {
        Task AddWare();
        Task ChangeDescription();
        Task DeleteWare();
    }
}
