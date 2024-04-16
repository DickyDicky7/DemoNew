using Godot;

public partial class Cop : VehicleBody
{
    
    [Export]
    public float MaxSteering = 000.80f;
    [Export]
    public float EnginePower = 300.00f;
    [Export]
    public float AccelerationSteering = 02.5f;

    public override void _PhysicsProcess(float delta)
    {
                    base._PhysicsProcess(      delta);

        Steering = Mathf.MoveToward(Steering, Input.GetAxis("R","L") * MaxSteering, delta * AccelerationSteering);
     EngineForce = Input.GetAxis("D","U")                            * EnginePower;
    }
}
