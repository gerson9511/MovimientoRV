using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
     public GameObject player;
    public string namescene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PointerClick()
    {

       // player.transform.position = new  Vector3(transform.position.x,transform.position.y+1.5f,transform.position.z);
       SceneManager.LoadScene(namescene);
    }

}
