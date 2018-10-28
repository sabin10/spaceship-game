using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text scoreText;
	public bool gameOver;
	public bool gameWin;
	public int score;
	public Button[] buttons;
	public GameObject[] ships;
	public GameObject fireSpawnScript;
	public audioManager am;
	public GameObject gameOverText;
	public GameObject gameWinMenu;
	

	// Use this for initialization
	void Start () {
		gameOver = false;
		gameWin = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 3.0f, 0.7f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(score > 2){
			am.shipSound.volume = 1.0f;
		}
		if(score == 511){
			am.gameWin.Play();
		}
		if(score == 512){
			am.shipSound.Stop();
			gameWin = true;
			gameWinMenu.gameObject.SetActive(true);
		}
		scoreText.text = " " + score;
	}

	void scoreUpdate(){
		if (fireSpawnScript.activeSelf == true && gameOver == false && score < 512) {
			score += 1;
		}
	}

	public void gameOverActivated(){
		for(int i = 0; i < 3; i++){
			Destroy(ships[i]);
		}
		am.shipSound.Stop();

		if(gameWin == false){
			
			am.gameOver.Play();
			gameOver = true;
			gameOverText.gameObject.SetActive(true);
		
			foreach(Button button in buttons){
				button.gameObject.SetActive(true);
			}
		}
	}



	public void Play(){
		Application.LoadLevel("level1");
	}

	public void Pause(){
		if(Time.timeScale == 1)
			Time.timeScale = 0;
		else if(Time.timeScale == 0)
			Time.timeScale = 1;
	}

	public void Menu(){
		Application.LoadLevel("menuScene");
	}

	public void About(){
		Application.LoadLevel("aboutScene");
	}

	public void Exit(){
		Application.Quit();
	}

}