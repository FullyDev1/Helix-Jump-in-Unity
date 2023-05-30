using UnityEngine;

[ExecuteInEditMode]
public class Cylinder : MonoBehaviour {
	public float firstCirclePos;
	public float distanceBtwCircles;

	public readonly float circlesHeight = 0.6f;

	public void PlaceAllCirclesCorrectly() {
		float curPos = firstCirclePos;

		for (int i = 1; i < transform.childCount; i++) {
			transform.GetChild(i).position = Vector3.up * curPos;
			curPos -= distanceBtwCircles;
		}
	}

	void OnValidate() {
		PlaceAllCirclesCorrectly();
	}
}
