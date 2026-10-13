namespace portfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Slug { get; set; } = "";
    public string Title { get; set; } = "";
    public string ShortDescription { get; set; } = "";
    public string FullDescription { get; set; } = "";
    public string GitHubUrl { get; set; } = "";
    public string TechStack { get; set; } = "";
    public List<string> Features { get; set; } = new();
    public List<string> ImagePaths { get; set; } = new();
    public string CoverImage { get; set; } = "";
    public string Category { get; set; } = "";
}
