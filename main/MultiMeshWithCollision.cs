using Godot;

public partial class MultiMeshWithCollision : MultiMeshInstance
{
    public override void _Ready()
    {
                    base._Ready();

        for (int index = 0; index < Multimesh.InstanceCount;     ++index)
        {
            Transform transform = Multimesh.GetInstanceTransform(index);
            CollisionShape
            collisionShape        = new      ();
            collisionShape.Shape  = Multimesh
                     .Mesh.CreateTrimeshShape();

            collisionShape.Transform =
            collisionShape.Transform with
            {
                basis = collisionShape.Transform.basis
                                     with
                {
                    x = transform.basis.x,
                    y = transform.basis.y,
                    z = transform.basis.z,
                }
            };
            collisionShape.Scale    = new(01.000f, 01.000f, 01.000f);
            collisionShape.Rotation = new(25.132f, 25.132f, 25.132f);

            StaticBody
            staticBody           = new()    ;
            staticBody.Transform = transform;
            staticBody.AddChild(collisionShape);
                       AddChild(
            staticBody         );
        }
    }
}
