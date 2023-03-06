namespace OrgPieceWebApp.ViewModels
{
    public class EditProfileViewModel
    {
        public int? Bounty { get; set; }
        public string? Position { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public IFormFile? Image { get; set; }
    }
}