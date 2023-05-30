using UnityEngine;

public class Rotator : MonoBehaviour {

	[SerializeField] float rotationSensitivity;

	void Update() {
		if (Input.GetMouseButton(0)) {
			float horizontal = Input.GetAxis("Mouse X");

			transform.Rotate(-Vector3.up * horizontal * rotationSensitivity * Time.deltaTime, Space.World);
		}
	}
}
