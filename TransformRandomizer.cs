using Godot;

[Tool]
public class TransformRandomizer : Resource
{
    [Export]
    public Vector3 MinTranslation     { get; set; } = new(0, 0, 0);
    [Export]
    public Vector3 MaxTranslation     { get; set; } = new(0, 0, 0);

    [Export]
    public Vector3 MinRotationDegrees { get; set; } = new(0, 0, 0);
    [Export]
    public Vector3 MaxRotationDegrees { get; set; } = new(0, 0, 0);

    [Export]
    public Vector3 MinScale           { get; set; } = new(1, 1, 1);
    [Export]
    public Vector3 MaxScale           { get; set; } = new(1, 1, 1);

    public (Vector3 translation, Vector3 rotationDegrees, Vector3 scale) Next()
    {
        return (
            new((float)GD.RandRange(MinTranslation.x, MaxTranslation.x),
                (float)GD.RandRange(MinTranslation.y, MaxTranslation.y),
                (float)GD.RandRange(MinTranslation.z, MaxTranslation.z)
               ),
            new((float)GD.RandRange(MinRotationDegrees.x, MaxRotationDegrees.x),
                (float)GD.RandRange(MinRotationDegrees.y, MaxRotationDegrees.y),
                (float)GD.RandRange(MinRotationDegrees.z, MaxRotationDegrees.z)
               ),
            new((float)GD.RandRange(MinScale.x, MaxScale.x),
                (float)GD.RandRange(MinScale.y, MaxScale.y),
                (float)GD.RandRange(MinScale.z, MaxScale.z)
               )
        );
    }

    public void ApplyNext(Spatial spatial)
    {
        (Vector3 translation, Vector3 rotationDegrees, Vector3 scale) = Next();
        spatial.Translation     = translation    ;
        spatial.RotationDegrees = rotationDegrees;
        spatial.Scale           = scale          ;
    }
}
