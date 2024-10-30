extends CharacterBody2D

const SPEED = 100
var current_dir = ""


func _physics_process(delta: float) -> void:
	player_movement(delta)

func player_movement(delta):
	if Input.is_action_pressed("down"):
		velocity.x = 0
		velocity.y = SPEED
		current_dir = "down"
		play_anim(1)
	elif Input.is_action_pressed("up"):
		velocity.x = 0
		velocity.y = -SPEED
		current_dir = "up"
		play_anim(1)
	elif Input.is_action_pressed("left"):
		velocity.x = -SPEED
		velocity.y = 0
		current_dir = "left"
		play_anim(1)
	elif Input.is_action_pressed("right"):
		velocity.x = SPEED
		velocity.y = 0
		current_dir = "right"
		play_anim(1)
	else:
		velocity.x = 0
		velocity.y = 0
		play_anim(0)
		
	move_and_slide()

func play_anim(movement):
	var dir = current_dir
	var anim = $AnimatedSprite2D
	
	if dir == "down":
		if movement == 1:
			anim.play("walkDown")
		else:
			anim.play("idleDown")
	elif dir == "up":
		if movement == 1:
			anim.play("walkUp")
		else:
			anim.play("idleUp")
	elif dir == "left":
		anim.flip_h = true
		if movement == 1:
			anim.play("walkSide")
		else:
			anim.play("idleSide")
	elif dir == "right":
		anim.flip_h = false
		if movement == 1:
			anim.play("walkSide")
		else:
			anim.play("idleSide")
	else:
		anim.play("idleDown")
