using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPlayer : MonoBehaviour {

// Init Variables
   float   xspeed;
   float   yspeed;
   Vector3 direction_move;
   [SerializeField] float spd = 7;

// Start is called before the first frame update // This is similary of Create Event of Game Maker
   void Start(){
      
   }

// Update is called once per frame // This is similary of Step Event of Game Maker
   void Update()
   {
      xspeed = Input.GetAxis("Horizontal");
      yspeed = Input.GetAxis("Vertical");

      direction_move.x   = xspeed;
      direction_move.y   = yspeed;
        
      transform.position += direction_move * Time.deltaTime * spd;
   }
}
