using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	Transform _player;
	Vector3 initialPos;
	float deltaY;

	void Start() {
		_player = GameObject.FindGameObjectWithTag("Player").transform;

		initialPos = this.transform.position;
		deltaY = _player.position.y - initialPos.y;
	}

	void LateUpdate() {
		float playerY = _player.position.y;

		if (transform.position.y + deltaY > playerY) {
			initialPos.y = playerY - deltaY;
			transform.position = initialPos;
		}
	}
}
