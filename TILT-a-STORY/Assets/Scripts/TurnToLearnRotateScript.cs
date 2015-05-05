using UnityEngine;
using System.Collections;

public class TurnToLearnRotateScript : MonoBehaviour {
	public int count;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 60) {
			transform.Rotate (new Vector3 (0, 0, 30) * Time.deltaTime);
			count=0;
		} else {
			transform.Rotate (new Vector3 (0, 0, -30) * Time.deltaTime);
		}
		count++;
	}
}
