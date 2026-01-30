using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamObjectController : MonoBehaviour
{
    public GameObject objectPrefab;   // prefab gốc
    public GameObject spawnedObject; // instance trong scene
    public InspectObject inspectObject;

    public void Spawn(GameObject objectPrefab)
    {
        this.objectPrefab = objectPrefab;
        spawnedObject = Instantiate(
            objectPrefab,
            new Vector3(-1f, 3.5f, -250.5f),
            Quaternion.identity
        );
        if (inspectObject != null)
        {
            inspectObject.UpdateModel(spawnedObject.transform);
        }
        else
        {
            Debug.LogError("InspectObject CHƯA được gán trong Inspector!");
        }
    }

    private void OnDestroy()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
    }
}
