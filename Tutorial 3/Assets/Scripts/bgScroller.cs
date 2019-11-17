using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroller : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSizez;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
      float newPosition=  Mathf.Repeat(Time.time * scrollSpeed, tileSizez);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
