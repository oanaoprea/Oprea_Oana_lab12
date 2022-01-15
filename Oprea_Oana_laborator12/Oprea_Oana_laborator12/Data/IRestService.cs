using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Oprea_Oana_laborator12.Models;

namespace Oprea_Oana_laborator12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
