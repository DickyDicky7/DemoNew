using Godot;

public partial class CarDashboard : Spatial
{
    [Export]
    public NodePath PathSteeringWheel { get; set; }
    public MeshInstance SteeringWheel { get => GetNode<MeshInstance>(PathSteeringWheel); }

    [Export]
    public float          MaxRotate = 45.00f;
    [Export]
    public float AccelerationRotate = 30.00f;

    public override void _Process(float delta)
    {
                    base._Process(      delta);

        SteeringWheel.RotationDegrees =
        SteeringWheel.RotationDegrees.MoveToward
        (
        SteeringWheel.RotationDegrees with
        {
            z = Input.GetAxis("R", "L") *          MaxRotate ,
        }
        ,       delta                   * AccelerationRotate);
    }
}
