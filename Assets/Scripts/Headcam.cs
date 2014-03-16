using UnityEngine;
using System.Collections;

public class Headcam : MonoBehaviour {
	public float smooth = 3f;
	private LeapManager leapManager;
	
	// Use this for initialization
	void Start () {
	  leapManager = GameObject.FindGameObjectWithTag("Null").GetComponent<LeapManager>();
	}
	
	// Update is called once per frame
	void Update () {
	  // if we hold Alt
	  if(leapManager && leapManager.GetHandID() != 0)
	    {
	      Vector3 targetPos = leapManager.GetHandPos() * leapManager.DisplayFingerScale + leapManager.DisplayFingerPos;
	      //targetPos.y += 1f;

	      
	      //transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smooth);
	      transform.position = targetPos;
	      transform.Translate(0f, 0.5f, 0f);
	      //transform.localPosition.z = 0.4f;
	      transform.rotation = Quaternion.Euler(90, 180, 0);
	      //transform.rotation = Quaternion.Euler(Vector3.Lerp(new Vector3(0,0,0),leapManager.handRot,1));
//	      Quaternion handqua = leapManager.GetHandQuat();
//	      Vector3 handrot = handqua.eulerAngles;
	      //transform.Rotate(Vector3.Lerp(new Vector3(0,0,0),leapManager.handRot,10));
	    }
//	  Debug.Log(leapManager.handRot);
	}
}
