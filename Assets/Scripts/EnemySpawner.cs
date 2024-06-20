using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    static private EnemySpawner instance;
    public static EnemySpawner Instance { get => instance; }

    private int enemyIndex = 0;
    [SerializeField] private Vector2 spawnPos = new Vector2(12f, 0f);

    [Header("Time")]
    [SerializeField] private float timeSpawn = 2f;
    [SerializeField] private float curTime = 0f;

    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }

    protected override void LoadHolder()
    {
        base.LoadHolder();
        if (this.holder != null) return;
        this.holder = GameObject.Find("EnemyHolder").transform;
        Debug.Log(transform.name + ": Load Enemy Holder", gameObject);
    }

    //Load Enemy prefabs
    protected override void LoadPrefabs()
    {
        base.LoadPrefabs();
        if (this.enemyPrefabs.Count > 0) return;
        string folderPath = "Prefabs/Enemies";
        GameObject[] listPrefabs = Resources.LoadAll<GameObject>(folderPath);
        foreach (GameObject child in listPrefabs) enemyPrefabs.Add(child);
        Debug.Log(transform.name + ": Load Enemy Prefabs", gameObject);
    }

    private void Update()
    {
        curTime += Time.deltaTime;
        if (curTime >= timeSpawn)
        {
            enemyIndex = Random.Range(0, enemyPrefabs.Count);
            Spawn(enemyPrefabs[enemyIndex], spawnPos);
            curTime = 0;
        }
    }
}
