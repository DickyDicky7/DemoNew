using Godot;

public partial class Cop : VehicleBody
{

    [Export]
    public float MaxSteering = 000.05f;
    [Export]
    public float EnginePower = 100.00f;
    [Export]
    public float AccelerationSteering = 02.5f;

    public override void _PhysicsProcess(float delta)
    {
                    base._PhysicsProcess(      delta);

        Steering = Mathf.MoveToward(Steering, Input.GetAxis("R","L") * MaxSteering, delta * AccelerationSteering);
     EngineForce = Input.GetAxis("D","U")                            * EnginePower;

        //GD.Print(EngineForce);
    }
}
