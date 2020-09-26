using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class counts : MonoBehaviour {
    public static int count;
    public Text cText;
    int flag;

	// Use this for initialization
	void Start () {
       count = 0;
        flag = 1;
       cText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if(flag == 1) {
       count = count + 1;
        } else {
            count = count;
        }
        cText.text = count.ToString();
	}

    public static int getcount() {
        return count;
    }
    public void naka() {
        flag = 0;
        Invoke("scene", 1);
    }
    void scene() {
        SceneManager.LoadScene("owari");
    }
    }
