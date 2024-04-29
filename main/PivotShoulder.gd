extends Spatial

func _physics_process(delta : float):
	self.global_position = lerp(
	self.global_position , $"../Cop".global_position, delta * 20.0);
	self.transform = self.transform .interpolate_with(
				$"../Cop".transform,                  delta * 00.5);
	pass;
