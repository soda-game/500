using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour {
    int countT;
    int SE;
    public Text countText;

    AudioSource audioSource;
    public AudioClip countSE;

    // Use this for initialization
    void Start () {
        countT = 3;
        SE = 0;
        countText.text = "";
        audioSource = gameObject.AddComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        countText.text = countT.ToString();
        if (countT == 3) {
            Invoke("two", 1);
        }
    }
    void two() {
        countT = 2;
        Invoke("one", 1);
    }
    void one() {
        countT = 1;
        Invoke("go", 1);
    }
    void go() {
        countT = 0;
        if (SE == 0) {
            audioSource.PlayOneShot(countSE);
            SE = 1;
        }
        Invoke("scene", 1);
    }
    void scene() {
        SceneManager.LoadScene("naka");
    }

}
