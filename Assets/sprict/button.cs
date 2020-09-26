using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip enterSE;
    // Use this for initialization
    void Start() {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    //ボタン------------------------------------------------
    public void saisyo() {
        audioSource.PlayOneShot(enterSE);
        Invoke("ssaisyo",1);
    }
    public void title() {
        audioSource.PlayOneShot(enterSE);
        Invoke("stitle", 1);
    }
    public void sousa() {
        audioSource.PlayOneShot(enterSE);
        Invoke("ssousa", 1);
    }
    public void owari() {
        audioSource.PlayOneShot(enterSE);
        Invoke("sowari", 1);
    }
    public void staff() {
        audioSource.PlayOneShot(enterSE);
        Invoke("sstaff", 1);
    }
    public void ritorai() {
        audioSource.PlayOneShot(enterSE);
        Invoke("naka", 1);
    }

    //シーン遷移------------------------------------
    void ssaisyo() {
        SceneManager.LoadScene("title");
    }
    void stitle() {
        SceneManager.LoadScene("sousa");
    }
    void ssousa() {
        SceneManager.LoadScene("hazime");
    }
    void sowari() {
        SceneManager.LoadScene("rogo");
    }
    void sstaff() {
        SceneManager.LoadScene("staff");
    }
}
