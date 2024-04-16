using Godot;

public class CameraPivot : Spatial
{
    [Export]
    public float          MaxRotate = 10.00f;
    [Export]
    public float AccelerationRotate = 10.00f;

    public override void _PhysicsProcess(float delta)
    {
                    base._PhysicsProcess(      delta);

        RotationDegrees =
        RotationDegrees.MoveToward
        (
        RotationDegrees with
        {
            y = Input.GetAxis("R", "L") * MaxRotate,
            z = Input.GetAxis("R", "L") * MaxRotate,
        }
        , delta * AccelerationRotate);
    }
}
