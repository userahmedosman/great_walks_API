
using GreatWlaks.API.Models.Domain;
namespace GreatWalks.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
