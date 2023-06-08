using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX; 
using UnityEngine.UI; 

public class PlantVfxInputs : MonoBehaviour

{
    public VisualEffect effect;
    public string vfxIntVariable = "emission";
    public string vfxFloatVariable = "attraction";
    
    public Slider sliderInt; 
    public Slider sliderFloat; 
   
    string vfxParameterRandomForce = "randomForce";
    RandomVector3 randomForce = new RandomVector3(); 
    public Slider sliderRandomForceScale; 
   


    void UpdateFloatVariable()
    {   
        effect.SetFloat(vfxFloatVariable, sliderFloat.value);
    }
    
    void UpdateIntVariable()
    {   
        effect.SetInt(vfxIntVariable, (int) sliderInt.value);
    }

    void UpdateRandomForce()
    {
        randomForce.update(sliderRandomForceScale.value);
        effect.SetVector3(vfxParameterRandomForce, randomForce.vector);
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateFloatVariable();   
        UpdateIntVariable();
        UpdateRandomForce();
        if (effect.HasVector3(vfxParameterRandomForce))
        {
            Debug.Log("Yes it can access ");
        }
        else
        {
            Debug.Log("No it can't access "  );
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFloatVariable(); 
        UpdateIntVariable();
        UpdateRandomForce();
    }
}
 
public class RandomVector3
{
    public Vector3 vector = new Vector3(0.0f, 0.0f, 0.0f);
    int time = 0;
    public float randomForceScale = 1; 

    public void update(float randomForceScale)
    {
        if (time % 100 == 0) 
        {
            Vector3 tempVec = new Vector3(Random.Range(-1f,1f), Random.Range(-1f,1f), Random.Range(-1f,1f)); 
            
            vector = randomForceScale * tempVec;
        }
        time = time + 1;
    }
}
 