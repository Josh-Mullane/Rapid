using System.Collections;
using System.Collections.Generic;
using UnityEngine;




void MoveListOrder()
{
    SpriteRenderer copy = children[0];
    children.Removeat(0);
    children.Insert(children.Count, copy);
    children[children.Count - 1].transform.position = children[0].transform.position + distance;
}

public class backgroundManager : MonoBehaviour
{

    public List<SpriteRenderer> children;
    private Vector3 distance;


    void Start()
    {
        distance = children[1].transform.position - children[0].transform.position;
    }


    void Update()
    {
        if (Camera.main.transform.position.y > children[1].transform.position.y) 
        {
            MoveListOrder();
        }
    }
}
