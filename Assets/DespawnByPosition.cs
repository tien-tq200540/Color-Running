using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByPosition : Despawner
{
    [SerializeField] private Vector2 despawnPosition = new Vector2(-12f, 0f);
    protected override bool CanDespawn()
    {
        if (transform.parent.position.x <= despawnPosition.x) return true;
        return false;
    }

    protected override void DespawnObject()
    {
        EnemySpawner.Instance.Despawn(transform.parent.gameObject);
    }
}
