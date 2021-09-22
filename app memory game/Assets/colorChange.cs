using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Color[] ColorBank;
    public bool mesh;
    public bool sprite;



    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0,ColorBank.length);
    
    //if (mesh)
   // {
       //  MeshRenderer m = GetComponent<MeshRenderer>();
       // m.material.color = ColorBank[num];
   // }
    if(sprite)
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        s.color = ColorBank[Num];
    } 

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
