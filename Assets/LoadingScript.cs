using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {

    public Button btnStart;
    public Button btnSetting;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void checkbtn()
    {
        if(btnStart.onClick != null ){
            loadthescene("scnStart");
        } else if(btnSetting.onClick != null){
            loadthescene("scnMenu");
        }
    }

    public void loadthescene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    
}
