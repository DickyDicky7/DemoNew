extends Spatial

export var PivotPath : NodePath; var Pivot : Spatial;

func _ready  (           ) -> void:
	Pivot = get_node(PivotPath);
	pass;

func _process(delta:float) -> void:
	
	var RoadPoints : Array = $RoadManager/Road_001.get_children();
	var RoadPointHead : RoadPoint = RoadPoints[0];
	var RoadPointNext : RoadPoint = RoadPoints[1];
	var RoadPointLast : RoadPoint = RoadPoints    .back        ();
	
	if (        Pivot.global_position.z >
		RoadPointHead.global_position.z + 100):
			
		RoadPointNext.prior_pt_init =  "";
		RoadPointHead. next_pt_init =  "";
		$RoadManager/Road_001.move_child(RoadPointHead,
		$RoadManager/Road_001. get_child_count() - 1 );
		RoadPointHead.prior_pt_init =    RoadPointHead.get_path_to(RoadPointLast);
		RoadPointLast. next_pt_init =    RoadPointLast.get_path_to(RoadPointHead);
		RoadPointHead.translation.z =    RoadPointLast.translation.z +50;
	
		print("###");
		print(RoadPointHead.name);
		print("###");
	
		#Experiment
		RoadPointHead.translation.x = rand_range(-30, +30);
#		if (randf() >= 0.5):
#			RoadPointHead.translation.y = +2;
#		else               :
#			RoadPointHead.translation.y = -2;
#		RoadPointHead.rotation_degrees.z = rand_range(-30, +30);
	
	pass;




