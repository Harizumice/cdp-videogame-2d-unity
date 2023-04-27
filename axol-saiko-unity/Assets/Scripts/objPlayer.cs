using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPlayer : MonoBehaviour{

 // Init Variables
    float xspeed;

    // Start is called before the first frame update // This is similary of Create Event of Game Maker
    void Start(){
        
    }

    // Update is called once per frame // This is similary of Step Event of Game Maker
    void Update(){
        xspeed = input.GetAxis("Horizontal");
        print(xspeed);
    }
}
