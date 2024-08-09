using WebApplication1.Models;
namespace WebApplication1.Repository
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();

        
    }
}
