using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public Material m;
    public float animationTime = 3f;
    public int baseMapId;

    void Awake()
    {
        baseMapId = Shader.PropertyToID("_BaseMap");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m.SetTextureOffset(baseMapId, m.GetTextureOffset(baseMapId) + new Vector2(0, Time.deltaTime));
    }
}
