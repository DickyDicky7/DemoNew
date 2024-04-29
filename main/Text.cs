using Godot;

public partial class Text : Control
{
    [Export]
    public NodePath PathRichTextLabelFPS { get; set; }
    [Export]
    public NodePath PathRichTextLabelOS  { get; set; }
    [Export]
    public NodePath PathRichTextLabelGyroscope     { get; set; }
    [Export]
    public NodePath PathRichTextLabelAccelerometer { get; set; }

    public RichTextLabel RichTextLabelFPS { get => GetNode<RichTextLabel>(PathRichTextLabelFPS); }
    public RichTextLabel RichTextLabelOS  { get => GetNode<RichTextLabel>(PathRichTextLabelOS ); }
    public RichTextLabel RichTextLabelGyroscope     { get => GetNode<RichTextLabel>(PathRichTextLabelGyroscope    ); }
    public RichTextLabel RichTextLabelAccelerometer { get => GetNode<RichTextLabel>(PathRichTextLabelAccelerometer); }

    public override void _Process(float delta)
    {
                    base._Process(      delta);

        RichTextLabelFPS.Text = $"FPS: {Engine.GetFramesPerSecond()}";
        RichTextLabelOS .Text = $"OS : {OS    .GetName           ()}";
        RichTextLabelGyroscope    .Text = $"Gyroscope    : {Input.GetGyroscope    ()}";
        RichTextLabelAccelerometer.Text = $"Accelerometer: {Input.GetAccelerometer()}";
    }
}
