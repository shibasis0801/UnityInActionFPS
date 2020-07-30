using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab);
            
            var x = Random.Range(-20, 20);
            var z = Random.Range(-20, -20);
            var position = new Vector3(x, 1, z);

            var angle = Random.Range(0, 360);
            var rotation = new Vector3(0, angle, 0);

            transform.localEulerAngles = rotation; 
            transform.position = position;
        }        
    }
}
