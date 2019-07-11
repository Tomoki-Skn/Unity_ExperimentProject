using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public struct FadeFlgManager
{
    public bool isFadeInStart;
    public bool isFadeInFinish;
    public bool isFadeOutStart;
    public bool isFadeOutFinish;

    public void Reset()
    {
        isFadeInStart = false;
        isFadeInFinish = false;
        isFadeOutStart = false;
        isFadeOutFinish = false;
    }
}


public class Teleport : MonoBehaviour {

    float frameCount = new float();
    FadeFlgManager txtFade = new FadeFlgManager();
    public string sceneName;
    public GameObject TextObj;
    Text txt;
    bool b = false;
	// Use this for initialization
	void Start () {
        txt = TextObj.GetComponent<Text>();
        var col = txt.color;
        col.a = 0;
        txt.color = col;
        txtFade.Reset();
        frameCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
        FadeIn(ref txtFade);

    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            txtFade.isFadeInStart = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    void FadeIn(ref FadeFlgManager fm)
    {
        if(fm.isFadeInStart == true && fm.isFadeInFinish == false)
        {
            var col = txt.color;
            col.a += 0.02f;
            txt.color = col;
            if(col.a > 1.0f)
            {
                fm.isFadeInFinish = true;
            }
        }
        else if(fm.isFadeInFinish == true && fm.isFadeOutStart == false)
        {
            fm.isFadeOutStart = true;
        }else if(fm.isFadeOutStart == true && fm.isFadeOutFinish == false)
        {
            var col = txt.color;
            col.a -= 0.02f;
            txt.color = col;
            if (col.a < 0.0f)
            {
                fm.Reset();
            }

        }
    }
}
