extends ParallaxBackground
class_name Background

export(bool) var can_process
# can_process está sendo utilizado para distinguirmos se estamos na cena inicial ou dentro do jogo
export(Array, int) var layer_speed = [20, 15, 10, 5]
# layer_speed irá controlar a velocida em que cada layer do background se move através do index

func _ready():
	if not can_process:
		# se o can_process for true, o paralax irá se mover de forma automática na tela inicial,
		# por isso setamos o set_physics_process como false, para que a fisica seja desativada
		set_physics_process(false)
		
func _physics_process(delta):
	for index in get_child_count():
		# get_chuld_count retorna o index dos parentes diretos (filhos) de Background (Layer1, etc)
		if get_child(index) is ParallaxLayer:
			# get_child acessa o node filho através do index (Layer1)
			get_child(index).motion_offset.x -= delta * layer_speed[index]
			# Estamos subtraindo do x de motion_offset (delta = fps) para dar a sensação de paralax
			# quando o personagem se mover para direita
