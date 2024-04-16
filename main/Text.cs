using Godot;

public partial class Text : Spatial
{
    [Export]
    public NodePath PathMeshFPS { get; set; }
    [Export]
    public NodePath PathMeshOS  { get; set; }
    [Export]
    public NodePath PathMeshGyroscope     { get; set; }
    [Export]
    public NodePath PathMeshAccelerometer { get; set; }

    public MeshInstance MeshFPS { get => GetNode<MeshInstance>(PathMeshFPS); }
    public MeshInstance MeshOS  { get => GetNode<MeshInstance>(PathMeshOS ); }
    public MeshInstance MeshGyroscope     { get => GetNode<MeshInstance>(PathMeshGyroscope    ); }
    public MeshInstance MeshAccelerometer { get => GetNode<MeshInstance>(PathMeshAccelerometer); }

    public override void _Process(float delta)
    {
                    base._Process(      delta);

        if (MeshFPS.Mesh is TextMesh meshFPS)
        {
            meshFPS.Text = $"FPS: {Engine.GetFramesPerSecond()}";
        }
        if (MeshOS .Mesh is TextMesh meshOS)
        {
            meshOS .Text = $"OS : {OS    .GetName           ()}";
        }
        if (MeshGyroscope    .Mesh is TextMesh meshGyroscope    )
        {
            meshGyroscope    .Text = $"Gyroscope    : {Input.GetGyroscope    ()}";
        }
        if (MeshAccelerometer.Mesh is TextMesh meshAccelerometer)
        {
            meshAccelerometer.Text = $"Accelerometer: {Input.GetAccelerometer()}";
        }
    }
}
