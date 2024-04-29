extends ViewportContainer

export                 var ColorsTextureI : int = 0;
export(Array, Texture) var ColorsTextures          ;

func _ready   () -> void:
	$Timer_ChangeColorPalette.connect("timeout", self, "OnTimeout");
	pass;

func OnTimeout() -> void:
	material.set(
	"shader_param/u_colors_tex",
	ColorsTextures[
	ColorsTextureI])   ;
	ColorsTextureI += 1;
	ColorsTextureI %= ColorsTextures.size();
	pass;


