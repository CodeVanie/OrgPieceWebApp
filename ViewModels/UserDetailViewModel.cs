using OrgPieceWebApp.Models;

namespace OrgPieceWebApp.ViewModels;

public class UserDetailViewModel
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public int? Bounty { get; set; }
    public string? Position { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string ProfileImageUrl { get; set; }

    public string Location => (City, State) switch
    {
        (string city, string state) => $"{city}, {state}",
        (string city, null) => city,
        (null, string state) => state,
        (null, null) => "",
    };
}