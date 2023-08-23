using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public UnityEngine.Vector3 offset;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
