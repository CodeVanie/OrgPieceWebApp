using OrgPieceWebApp.Models;

namespace OrgPieceWebApp.Interfaces
{
    public interface IDashboardRepository
    {
        List<Race> GetAllUserRaces();
        List<Club> GetAllUserClubs();
        Task<AppUser> GetUserById(string id);
        Task<AppUser> GetByIdNoTracking(string id);
        bool Update(AppUser user);
        bool Save();
    }
}
