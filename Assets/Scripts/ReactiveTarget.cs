using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public void ReactToHit()
    {
        var wanderingAI = GetComponent<WanderingAI>();
        if (wanderingAI != null)
        {
            wanderingAI.setAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        transform.Rotate(60, 0, 0);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
