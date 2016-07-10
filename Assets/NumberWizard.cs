﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min; 
	int guess;
	public int maxGuessAllowed = 5;
	
	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		max = 1000;
		min = 1; 
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	void NextGuess(){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		
		maxGuessAllowed = maxGuessAllowed -1;
		
		if(maxGuessAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
