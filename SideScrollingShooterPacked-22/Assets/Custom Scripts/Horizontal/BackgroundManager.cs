using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BackgroundManager : MonoBehaviour
{
    public List<SpriteRenderer> children;
    private Vector3 distance;

    void MoveListorder()
    {
        SpriteRenderer copy = children[0];
        children.RemoveAt(0);
        children.Insert(children.Count, copy);
        children[children.Count - 1].transform.position = children[0].transform.position + distance;

    }
    // Start is called before the first frame update
    void Start()
    {

        distance = children[1].transform.position - children[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.transform.position.x > children[1].transform.position.x)
        {
            MoveListOrder();
        }
    }
}

