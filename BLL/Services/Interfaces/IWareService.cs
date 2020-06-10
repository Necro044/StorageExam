using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IWareService
    {
        Task CreateWare();
        Task ChangeDescription();
    }
}
