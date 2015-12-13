using UnityEngine;
using System.Collections;

public class BasicMoverTarget : MonoBehaviour {

	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	public bool doSpin = true;
	public bool doMotion = false;
	// Update is called once per frame
	void Update () {

		if (doSpin) {
			//Vector3.up means rotate around y axes i.e. green axes. Time.deltaTime is the amount of time that's 
			//changed between last frame update and current frame update
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (doMotion) {
			// Move up and down over time
			// COsine sort of wave pattern
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
		}
	
	}
}
