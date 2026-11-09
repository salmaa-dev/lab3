using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincollect : MonoBehaviour

{
public AudioClip coin1;
public AudioClip coin2;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){

    if(other.tag == "Player") {
        Debug.Log("Score:hhhhhhhhhhhhhhh ");
        PlayerStats.score++;
        Debug.Log("Score: " + PlayerStats.score);
        AudioManager.Instance.PlayMusicSFX(coin1);
        Destroy(this.gameObject);

        //Debug.Log("Score: " + PlayerStats.score);
       
    }
}
}
