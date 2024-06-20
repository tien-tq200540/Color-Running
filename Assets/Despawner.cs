using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawner : TienMonoBehaviour
{
    //Conditions for despawn
    protected abstract bool CanDespawn();

    //Execute despawn
    protected abstract void DespawnObject();

    private void Update()
    {
        if (CanDespawn()) DespawnObject();
    }
}
