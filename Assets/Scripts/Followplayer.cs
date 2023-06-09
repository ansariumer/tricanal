using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        // if (Player != null)
        // {
        //     Transform Player;
        // }  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(Player.position.x, Player.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed * Time.deltaTime);
        
    }



    


}
