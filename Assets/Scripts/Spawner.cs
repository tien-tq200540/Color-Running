using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : TienMonoBehaviour
{
    [SerializeField] protected List<GameObject> enemyPrefabs = new List<GameObject>();
    [SerializeField] protected List<GameObject> poolObjects = new List<GameObject>();

    protected Transform holder;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        LoadHolder();
        LoadPrefabs();
    }

    //Load holder to keep enemies in a GameObject parent in the scene
    protected virtual void LoadHolder()
    {
        //For override
    }

    //Load prefabs into list
    protected virtual void LoadPrefabs()
    {
        //For override
    }

    protected virtual GameObject GetObjectFromPool(GameObject poolObject)
    {
        foreach (GameObject child in poolObjects)
        {
            if (child.name == poolObject.name)
            {
                poolObjects.Remove(child);
                child.SetActive(true);
                return child;
            }
        }
        return null;
    }

    protected virtual void Spawn(GameObject enemyPrefab, Vector2 position)
    {
        GameObject newEnemy = GetObjectFromPool(enemyPrefab);
        if (newEnemy != null) newEnemy.transform.position = position;
        else
        {
            newEnemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            newEnemy.name = enemyPrefab.name;
            newEnemy.transform.parent = this.holder;
        }
    }

    public virtual void Despawn(GameObject prefabObject)
    {
        poolObjects.Add(prefabObject);
        prefabObject.SetActive(false);
    }
}
