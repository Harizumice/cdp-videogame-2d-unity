using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPlayer : MonoBehaviour {

// Init Variables
   float   xspeed;
   float   yspeed;
   Vector3 direction_move;
   Vector2 facingDirection;

   [SerializeField] float spd = 7;
   [SerializeField] Transform aim;
   [SerializeField] Camera cam;
   [SerializeField] Transform prefab_bullet; 

// Start is called before the first frame update // This is similary of Create Event of Game Maker
   void Start(){
      
   }

// Update is called once per frame // This is similary of Step Event of Game Maker
   void Update()
   {
   // Movement To Player
      xspeed = Input.GetAxis("Horizontal");
      yspeed = Input.GetAxis("Vertical");

      direction_move.x   = xspeed;
      direction_move.y   = yspeed;
        
      transform.position += direction_move * Time.deltaTime * spd;

   // Move of the Target(Cursor)
      facingDirection = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
      aim.position    = transform.position + (Vector3)facingDirection.normalized;

   // Shoot One Bullet with Mouse Left or Right
      if(Input.GetMouseButton(0) || Input.GetMouseButton(1)){
         float angle = Mathf.Atan2(facingDirection.y,facingDirection.x) * Mathf.Rad2Deg;
         Quaternion rotation_target = Quaternion.AngleAxis(angle, Vector3.forward);
         Instantiate(prefab_bullet,transform.position, rotation_target);
      }
   }
}
