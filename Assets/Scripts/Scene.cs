﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// pindah scene menu
    public void MenuScene() {
		 SceneManager.LoadScene("Menu");
		
	}
	
	// pindah scene ke loading
	public void LoadingScene() {
		SceneManager.LoadScene("Loading");
	}

	// keluar dari game
	public void KeluarScene() {
		Application.Quit();
 }
}