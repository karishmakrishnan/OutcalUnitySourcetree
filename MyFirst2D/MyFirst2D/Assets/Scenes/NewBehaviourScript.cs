using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake(){
        Debug.Log("Myfirst scipt Awake!!!!!!!!!!!!!!!");
    }
    void Start()
    {
        Debug.Log("Myfirst scipt Start!!!!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
      if(  Input.GetMouseButtonDown(0)){
          Debug.Log("My mouse left click");
      }
      if(  Input.GetMouseButtonDown(1)){
          Debug.Log("My mouse right click");
      }
     if(Input.GetKeyDown(KeyCode.F)){
         Debug.Log("Key is pressed!!!!!!!!!!!!");
     }
     if(Input.GetKey(KeyCode.F)){
         Debug.Log("Input is F");
     }
     if(Input.GetKeyUp(KeyCode.F)){
         Debug.Log("Key is released!!!!!!!!!!!");
     }
    } 
    private void LateUpdate(){

    }
    void onDestroy(){
        Debug.Log("Myfirst scipt Destoy!!!!!!!!!!!!!!!");
    }
}
