using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Cannon target;
    public float speed;

    // Start is called before the first frame update
    private void Start()
    {
        FindClosestCannon();
    }

    private void OnDestroy()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if(target == null) FindClosestCannon();
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
    }


    void FindClosestCannon()
    {
        List<Cannon> cannons = Cannon.All;

        foreach (Cannon c in cannons)
        {
            if (target == null)
                target = c;
            if (Vector3.Distance(this.transform.position, target.transform.position) > Vector3.Distance(this.transform.position, c.transform.position))
                target = c;
        }
    }

}
