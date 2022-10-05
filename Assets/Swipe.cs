using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 StartPos;
    Vector2 EndPos;
    float SwipeLength, Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.StartPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0)){
            this.EndPos = Input.mousePosition;
            SwipeLength = EndPos.x - StartPos.x;
            this.Speed = SwipeLength / 1000.0f;
        }

        transform.Translate(this.Speed, 0, 0);
        this.Speed *= 0.90f;
    }
}
