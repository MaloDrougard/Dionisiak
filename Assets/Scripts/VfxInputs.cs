using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX; 
using UnityEngine.UI; 

public class VfxInputs : MonoBehaviour

{
    public VisualEffect effect;
    public Slider slider; 

    void UpdateVelocity()
    {   
        Vector3 vecA = new Vector3(-1,-1,0);
        Vector3 vecB = new Vector3(1,1,0);
        effect.SetVector3("velocityRangeA", slider.value * vecA);
        effect.SetVector3("velocityRangeB", slider.value * vecB);
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateVelocity();   
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVelocity(); 
    }
}
