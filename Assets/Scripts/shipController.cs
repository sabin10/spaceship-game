using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour {

    public float shipSpeed;
    Vector3 position;
	Vector3 tempPos;
	public UIManager ui;
	public audioManager am;
	bool currentPlatformAndroid = false;

	Rigidbody2D rb;


	void Awake(){

	#if UNITY_ANDROID
		currentPlatformAndroid = true;
	#else
		currentPlatformAndroid = false;
	#endif

		am.shipSound.Play();

	}



	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
        position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if(currentPlatformAndroid == true){
			if(ui.gameOver == false && ui.gameWin == false){
				TouchMove();
			}

			
			//transform.position = position;
			
			tempPos = transform.position;
			if(tempPos.x > 12f){
				tempPos.x = -6f;
				position.x = -6f;
			} else if(tempPos.x < -12f){          
				tempPos.x = 6f;
				position.x = 6f;
			}

			transform.position = tempPos;	
			
		
			
		}	
		


		else{

			if(ui.gameOver == false && ui.gameWin == false){
				position.x += Input.GetAxis("Horizontal") * shipSpeed * Time.deltaTime;
			}

			transform.position = position;

			tempPos = transform.position;
			if(tempPos.x > 12f){
				tempPos.x = -6f;
				position.x = -6f;
			} else if(tempPos.x < -12f){          
				tempPos.x = 6f;
				position.x = 6f;
			}

			transform.position = tempPos;	
		}	
		
	}

	void TouchMove(){

		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);

			float middle = Screen.width / 2;

			if (touch.position.x < middle && touch.phase == TouchPhase.Began) {
				MoveLeft ();
			} 
			else if (touch.position.x > middle && touch.phase == TouchPhase.Began) {
				MoveRight ();
			}
		
		} 

		else {
			SetVelocityZero();
		}

	}

	public void MoveLeft(){
		rb.velocity = new Vector2 (-shipSpeed, 0);
	}
	
	public void MoveRight(){
		
		rb.velocity = new Vector2 (shipSpeed, 0);
	}
	
	public void SetVelocityZero(){
		rb.velocity = Vector2.zero;
	}





	void OnCollisionEnter2D(Collision2D col){
		if(ui.score != 512){
			if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Enemy2"){
				Destroy (gameObject);
				ui.gameOverActivated();
			}
		}
	}

	
}
