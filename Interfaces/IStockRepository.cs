using WebApplication1.Models;
using System.Threading.Tasks;
using api.Data;
using WebApplication1.Dtos.Stock;

namespace WebApplication1.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();

        Task<Stock?> GetByIdAsync(int id); //FirstORDefault Can be null
        Task<Stock> CreateAsync(Stock stockModel);

        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);

    }
}
