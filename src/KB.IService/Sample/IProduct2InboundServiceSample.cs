using KB.ContractModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KB.IService.Sample
{
    public interface IProduct2InboundServiceSample
    {
        Task<List<Product2Model>> GetAllProductsAsync();

        Task<int> GetAllProductCountAsync();

        Task<Product2Model> GetProductsAsync(string id);

        Task<Product2Model> AddProductAsync(string no, string name, double weight);

        Task RemoveProductAsync(string id);
    }
}
