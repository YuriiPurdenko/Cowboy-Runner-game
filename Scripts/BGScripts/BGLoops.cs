using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLoops : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 0.1f; 
    private Vector2 offset = Vector2.zero;
    Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex",offset);
    }
}
