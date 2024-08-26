using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;

    public bool IsPlaceable { get { return isPlaceable; } }
    void OnMouseDown()
    {
        if(isPlaceable)
        {
            bool isPlaced =  towerPrefab.CreateTower(towerPrefab,transform.position);
            //Instantiate(towerPrefabs, transform.position, Quaternion.identity);
            isPlaceable= !isPlaced;
        }    
    }
}
