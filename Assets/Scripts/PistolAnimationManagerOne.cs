using UnityEngine;
using System.Collections;

public class Pistol : MonoBehaviour {
	
	public bool isWalking = false;
	public bool isReloading = false;
	
	void Start() {
		
		GetComponent<Animation>().CrossFade("Idle");
		
	}
	
	void Update() {
		
		if(!GetComponent<Animation>().IsPlaying("Run")) {
			
			isWalking = false;
			
		}
		
		if(Input.GetKeyDown(KeyCode.R)) {
			
			isReloading= true;
			isWalking = false;
		}
		
		if(isReloading == true)
		{
			GetComponent<Animation>().CrossFade("Reload");
		}
		
		if(Input.GetKeyDown(KeyCode.W)) {
			
			isWalking = true;
			
		}
		
		if(isWalking == true && isReloading == false) {
			
			GetComponent<Animation>().CrossFade("Run");
			
		}
		else if(isWalking == false && isReloading == false) {
			
			GetComponent<Animation>().CrossFade("Idle");
			
		}
		
		if(Input.GetKeyUp(KeyCode.W)) {
			
			isWalking = false;
			GetComponent<Animation>().CrossFade("Idle");
			
		}
		
		if(isWalking == false) {
			
			GetComponent<Animation>().CrossFade("Idle");
			
		}
		
	}
	
}