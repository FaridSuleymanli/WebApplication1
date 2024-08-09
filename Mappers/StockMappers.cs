using System.Runtime.CompilerServices;
using WebApplication1.Dtos.Stock;
using WebApplication1.Models;
namespace WebApplication1.Mappers
{
    public static class StockMappers
    {
        public static StockDTO ToStockDto(this Stock stockModel)
        {
            return new StockDTO
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap
                

            };
        }


        public static Stock ToStockFromCreateDto(this CreateStockRequestDto stockDto )
        {
            return new Stock
            {

               Symbol = stockDto.Symbol,
               CompanyName = stockDto.CompanyName,
               MyProperty = stockDto.MyProperty,
               Purchase = stockDto.Purchase,
               LastDiv = stockDto.LastDiv,
               Industry = stockDto.Industry,
               MarketCap = stockDto.MarketCap,


            };
        }

    }
}
