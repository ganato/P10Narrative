﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToLinearScene : MonoBehaviour {

	 public Text loading;

    // Use this for initialization
    void Start () {
        
        loading.text="";
    }
	
	// Update is called once per frame
	void Update () {


	}
    public void LoadScene()
    {
            loading.text="Indlæser...";
            SceneManager.LoadScene("linear", LoadSceneMode.Single);
    }
}
