using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    Vector3 offset = new(0, 3.4f, -6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.SetPositionAndRotation(player.transform.position + (player.transform.rotation * offset), player.transform.rotation);
    }
}
