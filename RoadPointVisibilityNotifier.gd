extends VisibilityNotifier

func _ready() -> void:
	self.   connect("camera_exited", self, "OnCameraExited");
	pass;
	
func OnCameraExited( camera : Camera)  -> void:
	var RoadPointCurr : RoadPoint     =   self.get_parent();
	
	if (RoadPointCurr. next_pt_init == null
	||  RoadPointCurr.prior_pt_init == null):
		print("SHOULD CALL THIS");
		return;
	
	var RoadPointNext : RoadPoint     = RoadPointCurr.get_node(RoadPointCurr.next_pt_init);
	var RoadContainer : RoadContainer = RoadPointCurr.get_parent  ();
	var RoadPointLast : RoadPoint     = RoadContainer.get_children().back();
	RoadPointNext.prior_pt_init =  "";
	RoadPointCurr. next_pt_init =  "";
	RoadContainer.move_child(      RoadPointCurr,            RoadContainer .get_child_count() - 1);
	RoadPointCurr.prior_pt_init =  RoadPointCurr.get_path_to(RoadPointLast);
	RoadPointLast. next_pt_init =  RoadPointLast.get_path_to(RoadPointCurr);
	RoadPointCurr.translation.z =  RoadPointLast.translation.z +50;
	
	print("###");
	print(RoadPointCurr.name);
	print("###");
	
	#Experiment
	RoadPointCurr.translation.x = rand_range(-10, +10);
	
	pass;


