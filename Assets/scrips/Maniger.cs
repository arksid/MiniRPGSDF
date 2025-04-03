using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Maniger : MonoBehaviour
{
    public GameObject cube;
    public GameObject Light;
    public MeshRenderer ground;
    public Color lightcolor;



    // Start is called before the first frame update
    void Start()
    {
        //cube.SetActive(true);
        //cube.SetActive(false);

        //Instantiate(cube);//생성 또는 복사 
        //Destroy(cube); //파괴
        //Color 0 ~1
        cube.GetComponent<Rigidbody>().useGravity = false;

        
        
        
    

    }

    public void CubeOn()
    {
        cube.SetActive(true);
    }
    public void CubeOff()
    {
        cube.SetActive(false);
    }

    public void lightcgON()
    {
        Light.GetComponent<Light>().color = lightcolor;
    }
    public void groundColor()
    {
        ground.material.color = Color.red;
    }

}
