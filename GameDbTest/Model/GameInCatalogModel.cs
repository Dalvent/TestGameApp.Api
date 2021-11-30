using System.Collections.Generic;

namespace GameDbTest.Model
{
    public record GameInCatalogModel(
        int Id,
        string Name,
        string ImageUrl,
        float CriticsScore,
        string[] Tags
    );
}