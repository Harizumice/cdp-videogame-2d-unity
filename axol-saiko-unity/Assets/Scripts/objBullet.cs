using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objBullet : MonoBehaviour{
 // Variables Init
    [SerializeField] float spd = 7;

 // Update is called once per frame
    void Update(){
        transform.position += transform.right * Time.deltaTime * spd;
    }
}
