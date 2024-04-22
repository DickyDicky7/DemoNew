extends Spatial

export var RoadPointVisibilityNotifier :  PackedScene;

func _ready() -> void:
	for RoadPointChild in $RoadManager/Road_001.get_children():
		RoadPointChild.add_child(RoadPointVisibilityNotifier.instance());

	print("###");
	print($RoadManager/Road_001/RP_001.prior_pt_init);
	print("###");
	
	pass;


func _process(delta):
#	print($RoadManager/Road_001/RP_002.get_child_count());
	pass;
