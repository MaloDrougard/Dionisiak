using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX; 
using UnityEngine.UI; 

public class VfxInputs : MonoBehaviour

{
    public VisualEffect effect;
    public string vfxIntVariable = "emission";
    public string vfxFloatVariable = "attraction";
    
    public Slider sliderInt; 
    public Slider sliderFloat; 



    void UpdateFloatVariable()
    {   
        effect.SetFloat(vfxFloatVariable, sliderFloat.value);
    }
    
    void UpdateIntVariable()
    {   
        effect.SetInt(vfxIntVariable, (int) sliderInt.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateFloatVariable();   
        UpdateIntVariable();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFloatVariable(); 
        UpdateIntVariable();
    }
}
