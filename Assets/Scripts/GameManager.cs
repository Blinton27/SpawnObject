using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Using Raycast ChatGPT
    /*
    // Prefab of the cube that will be spawned
    [SerializeField] GameObject cubePrefab;

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the mouse cursor on screen in the direction of the camera
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            // Create a RaycastHit variable to store information about what was hit by the ray
            RaycastHit hit;

            // Perform the raycast and if it hits something on the terrain
            if (Physics.Raycast(camRay, out hit))
            {
                // Get the point where the cube should be spawned
                Vector3 spawnPoint = hit.point;

                // Spawn the cube at the point
                Instantiate(cubePrefab, spawnPoint, Quaternion.identity);
            }
        }
    } 
    */
    #endregion 


    #region Using Camera.ScreenToWorldPoint ChatGPT 
    /*
    [SerializeField]private GameObject prefabToSpawn; // Drag the prefab here in the Inspector
    [SerializeField]private Camera camera; // Drag the camera here in the Inspector

    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Create a new vector3 for the position of the mouse
            Vector3 mousePos = Input.mousePosition;

            // Use ScreenToWorldPoint to convert the mouse position from screen space to world space
            Vector3 spawnPos = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 50f));
            

            // Instantiate the prefab at the position of the mouse
            Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
        }
    }
    */
    #endregion 

    #region My attempt
    // [SerializeField] private GameObject _cubeToSpawn;
    // [SerializeField] private GameObject _shpereToSpawn;
    // [SerializeField] private GameObject _cylinderToSpawn;
    // [SerializeField] private GameObject _capsuleToSpawn;

    [SerializeField] private GameObject[] _chooseObject;
    private int _actualItems;
    private int _maxItemSpawnable = 10;
    
    private void Update() 
    {
        if(Input.GetMouseButtonDown(0) && _actualItems <= _maxItemSpawnable -1)
        {
            Vector3 wordPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Random.Range(5.0f,50.0f)));
            // Instantiate(_cubeToSpawn, wordPos, Quaternion.identity);
            // Instantiate(_shpereToSpawn, wordPos, Quaternion.identity);
            // Instantiate(_cylinderToSpawn, wordPos, Quaternion.identity);
            // Instantiate(_capsuleToSpawn, wordPos, Quaternion.identity);
            Instantiate(_chooseObject[Random.Range(0,_chooseObject.Length)],wordPos, Quaternion.identity);
             _actualItems ++;
            
           
        }       
    }
    #endregion
}