using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSpawnPos : MonoBehaviour {

    public GameObject fire;
	public GameObject[] stones;
	
    private float delayTimer = 1.0f;
	private float delayTimerStone = 1.0f;
    float timer;
	float timerStone;
	public UIManager ui;
	public fireMove fireScript;
	public stoneMove[] stoneScript;
	bool doubleStone = false;
	public ScrollingObject[] bigStars;
	public ScrollingObject2[] smallStars;



	
	

    // Use this for initialization
    void Start () {

	}

	

	/* 
		scor maxim = 1000 -> cand apare ceva tare
		0-10 cate un foc de obisnuinta
		10-33 mai rapid
		512 scor maxim




	*/

	void Logic(){
		if(ui.score < 1){
			delayTimer = 0.9f;
			fireScript.speed = 9f;
		}

		else if(ui.score >= 1 && ui.score <= 10){
			delayTimer = 0.9f;
			fireScript.speed = 6f;
		
		}

		else if(ui.score > 10 && ui.score <= 30){
			delayTimer = 0.8f;
			delayTimerStone = 0.85f;
			fireScript.speed = 7f;
		}

		else if(ui.score> 30 && ui.score <= 50){
			delayTimer = 0.75f;
			delayTimerStone = 1.0f;
			fireScript.speed = 7.3f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = -2.2f;
				smallStars[i].scrollSpeed = -2f;
			}
			

		}

		else if(ui.score > 50 && ui.score <= 70){
			delayTimer = 0.72f;
			delayTimerStone = 0.9f;
			fireScript.speed = 7.5f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = -2.7f;
				smallStars[i].scrollSpeed = -2.5f;
			}
		}

		else if(ui.score > 70 && ui.score <= 90){
			delayTimer = 0.69f;
			delayTimerStone = 0.85f;
			fireScript.speed = 7.6f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = -2.9f;
				smallStars[i].scrollSpeed = -2.7f;
			}
		}

		else if(ui.score > 90 && ui.score <= 130){
			delayTimer = 0.65f;
			delayTimerStone = 0.7f;
			fireScript.speed = 7.7f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = -3.1f;
				smallStars[i].scrollSpeed = -2.9f;
			}
		}

		else if(ui.score > 130 && ui.score <= 150){
			delayTimer = 0.61f;
			delayTimerStone = 0.68f;
			fireScript.speed = 7.8f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = -3.4f;
				smallStars[i].scrollSpeed = -3.2f;
			}
		}

		else if(ui.score > 150 && ui.score <= 180){
			delayTimer = 0.59f;
			delayTimerStone = 0.68f;
			fireScript.speed = 7.9f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 3.7f;
				smallStars[i].scrollSpeed = 3.5f;
			}
		}


		else if(ui.score > 180 && ui.score < 200){
			delayTimer = 0.56f;
			delayTimerStone = 0.6f;
			fireScript.speed = 8f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4f;
				smallStars[i].scrollSpeed = 3.8f;
			}
		}

		else if(ui.score > 200 && ui.score < 220){
			delayTimer = 0.555f;
			delayTimerStone = 0.6f;
			fireScript.speed = 8.1f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.1f;
				smallStars[i].scrollSpeed = 3.9f;
			}
		}

		else if(ui.score > 220 && ui.score < 240){
			delayTimer = 0.55f;
			delayTimerStone = 0.59f;
			fireScript.speed = 8.15f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.2f;
				smallStars[i].scrollSpeed = 4f;
			}
		}

		else if(ui.score > 240 && ui.score < 256){
			delayTimer = 0.54f;
			delayTimerStone = 0.585f;
			fireScript.speed = 8.2f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.4f;
				smallStars[i].scrollSpeed = 4.2f;
			}
		}

		else if(ui.score > 256 && ui.score < 290){
			delayTimer = 0.53f;
			delayTimerStone = 0.575f;
			fireScript.speed = 8.22f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.5f;
				smallStars[i].scrollSpeed = 4.3f;
			}
		}

		else if(ui.score > 290 && ui.score < 350){
			delayTimer = 0.52f;
			delayTimerStone = 0.575f;
			fireScript.speed = 8.25f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.6f;
				smallStars[i].scrollSpeed = 4.4f;
			}
		}

		else if(ui.score > 350 && ui.score < 400){
			delayTimer = 0.51f;
			delayTimerStone = 0.57f;
			fireScript.speed = 8.275f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.7f;
				smallStars[i].scrollSpeed = 4.5f;
			}
		}

		else if(ui.score > 400 && ui.score < 450){
			delayTimer = 0.5f;
			delayTimerStone = 0.565f;
			fireScript.speed = 8.29f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.8f;
				smallStars[i].scrollSpeed = 4.6f;
			}
		}

		else if(ui.score > 450 && ui.score < 500){
			delayTimer = 0.49f;
			delayTimerStone = 0.555f;
			fireScript.speed = 8.31f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 4.9f;
				smallStars[i].scrollSpeed = 4.7f;
			}
		}

		else if(ui.score > 500 && ui.score < 511){
			delayTimer = 0.48f;
			delayTimerStone = 0.545f;
			fireScript.speed = 8.35f;
			for(int i = 0; i < 2; i++){
				bigStars[i].scrollSpeed = 5f;
				smallStars[i].scrollSpeed = 4.8f;
			}
		}
		if(ui.score == 511){
			delayTimer = 2.5f;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		timerStone -= Time.deltaTime;

		if(Random.Range(0, 5) == 1){
			doubleStone = true;
		}

		Logic();

		if(Random.Range(0, 20) == 1 && ui.score > 30)
			fireScript.speed = 8.8f;



		if(timer <= 0){

			if(ui.score > 25 && ui.score <= 100 && Random.Range(0, 20) == 1){
				delayTimer = 0.35f;
				Vector3 firePos = new Vector3(Random.Range(-2.8f, 2.8f), transform.position.y, transform.position.z);
				Instantiate(fire, firePos, transform.rotation);
				timer = delayTimer;
			}  else if(ui.score > 100 && Random.Range(0, 30) == 1){
				delayTimer = 0.3f;
				Vector3 firePos = new Vector3(Random.Range(-2.8f, 2.8f), transform.position.y, transform.position.z);
				Instantiate(fire, firePos, transform.rotation);
				timer = delayTimer;
			}	else if(ui.score == 512){
				for(int i = 0; i < 30; i++){
					delayTimer = 0.1f;
					Vector3 firePos = new Vector3(Random.Range(-2.8f, 2.8f), transform.position.y, transform.position.z);
					Instantiate(fire, firePos, transform.rotation);
					timer = delayTimer;
				}
			}
			else{
					Vector3 firePos = new Vector3(Random.Range(-2.8f, 2.8f), transform.position.y, transform.position.z);
					Instantiate(fire, firePos, transform.rotation);
					timer = delayTimer;
				}
			
		}

		

		// adaugare pietre
		int ind = Random.Range(0, 4);

		if(ui.score > 10){
			if(Random.Range(0, 18) == 13){
		
				if(timerStone <= 0){
					if(doubleStone == true){
						for(int i = 0; i < 2; i++){
							
							if(i == 1){
								stoneScript[ind].speed = 6f;
							}							
							Vector3 stonePos = new Vector3(Random.Range(-2.6f, 2.6f), transform.position.y, transform.position.z);
							Instantiate(stones[ind], stonePos, transform.rotation);
							timerStone = delayTimerStone;
						}
					}else{
						Vector3 stonePos = new Vector3(Random.Range(-2.6f, 2.6f), transform.position.y, transform.position.z);
						Instantiate(stones[ind], stonePos, transform.rotation);
						timerStone = delayTimerStone;
					}
					
				}
			}
		}else if(ui.score > 40 && ui.score < 512){
			if(Random.Range(0, 50) == 13){
				delayTimerStone = 0.4f;
				if(timerStone <= 0){
					Vector3 stonePos = new Vector3(Random.Range(-2.6f, 2.6f), transform.position.y, transform.position.z);
					Instantiate(stones[ind], stonePos, transform.rotation);
					timerStone = delayTimerStone;
				}
			}
		}
		

		doubleStone = false;
		stoneScript[ind].speed = 5f;
		
		
	}
}
