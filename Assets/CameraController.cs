using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.3f);
    }
}
