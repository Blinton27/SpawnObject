using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoolManager : MonoBehaviour
{
    // #region If _maxItemSpawnable > 10, change the transform.position of the first prefab when you click and so on for my prefabs in my List usin there Index & object pooling
    [SerializeField] private GameObject[] _objectThatWillBeRegenerate;
    private int _actualItems;
    private int _maxItemSpawnable = 10;


    
    private void Update() 
    {
        if(Input.GetMouseButtonDown(0) && _actualItems <= _maxItemSpawnable -1)
        {
            Vector3 wordPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Random.Range(5.0f,50.0f)));
            Instantiate(_objectThatWillBeRegenerate[Random.Range(0,_objectThatWillBeRegenerate.Length)],wordPos, Quaternion.identity);
             _actualItems ++;
        }
        else if (Input.GetMouseButtonDown(0) && _actualItems > _maxItemSpawnable -1)
        {
            Vector3 wordPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Random.Range(5.0f,50.0f)));
        }
    }

    
}
