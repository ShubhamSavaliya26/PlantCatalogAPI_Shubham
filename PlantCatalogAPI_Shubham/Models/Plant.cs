using Microsoft.AspNetCore.Mvc;
namespace PlantCatalogAPI_Shubham.Models;

public class Plant
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsIndoor { get; set; }
}

