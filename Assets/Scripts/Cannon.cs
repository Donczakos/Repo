using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    static List<Cannon> cannons = new List<Cannon>();
    static List<Enemy> GlobalEnemies = new List<Enemy>();

    public static void AddEnemy(Enemy e)
    {
        foreach(Cannon c in cannons)
        {
            c.enemies.Add(e);
        }
        GlobalEnemies.Add(e);
    }

    public static void RemoveEnemy(Enemy e)
    {
        foreach (Cannon c in cannons)
        {
            c.enemies.Remove(e);
        }
        GlobalEnemies.Remove(e);
    }


    public static List<Cannon> All
    {
        get
        {
            return cannons;
        }
    }


    List<Enemy> enemies = new List<Enemy>();
    


    void Start()
    {
        enemies = GlobalEnemies;
        cannons.Add(this);
    }


    void OnDestroy()
    {
        cannons.Remove(this);
    }


    void Update()
    {
        
    }

    


}
