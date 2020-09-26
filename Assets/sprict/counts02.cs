using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counts02 : MonoBehaviour {
    int count2;
    public Text text;
    public Text hante;

    AudioSource audioSource;
    public AudioClip countSE;

    // Use this for initialization
    void Start() {
        audioSource = gameObject.AddComponent<AudioSource>();

        count2 = counts.getcount();
        print(count2);

        hante.text = "";

        text.text = count2.ToString();
    }

    // Update is called once per frame
    void Update() {
        if (count2 == 500) {
            hante.text = "ぴったり！素晴らしい！！";
            audioSource.PlayOneShot(countSE);
        } else if (count2 <= 480) {
            hante.text = "まだ早い！焦らずに！";
        } else if (count2 < 500) {
            hante.text = "惜しい！あと少し！";
        } else if (count2 <= 540) {
            hante.text = "惜しい！ちょっと遅いよ！";
        } else if (count2 < 800) {
            hante.text = "もう少し早めに押そう！";
        } else if (count2 >= 800) {
            hante.text = "ほ、放置してた？ (´；ω；`)";
        }
    }
}
