extends CharacterBody2D

const SPEED = 75
var current_dir: String


func _physics_process(delta: float) -> void:
	player_movement(delta)

func player_movement(delta):
	velocity = Vector2.ZERO
	
	if Input.is_action_pressed("down"):
		velocity.y = SPEED
		current_dir = "down"
		play_anim(1)
	if Input.is_action_pressed("up"):
		velocity.y = -SPEED
		current_dir = "up"
		play_anim(1)
	if Input.is_action_pressed("left"):
		velocity.x = -SPEED
		current_dir = "left"
		play_anim(1)
	if Input.is_action_pressed("right"):
		velocity.x = SPEED
		current_dir = "right"
		play_anim(1)
	
	if velocity.length() > 0:
		velocity = velocity.normalized() * SPEED
		play_anim(1)
	else:
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
