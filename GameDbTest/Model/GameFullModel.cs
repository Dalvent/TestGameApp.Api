namespace GameDbTest.Model
{
    public record GameFullModel(
        int Id,
        string Name,
        string ImageUrl,
        float CriticsScore,
        string[] Tags,
        string Description,
        DeveloperOfGameModel Developer,
        PublisherOfGameModel Publisher
    );
}