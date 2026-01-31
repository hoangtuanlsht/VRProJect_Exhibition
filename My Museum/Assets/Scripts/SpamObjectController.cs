using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpamObjectController : MonoBehaviour
{
    public GameObject objectPrefab;   // prefab gốc
    public GameObject spawnedObject; // instance trong scene
    public InspectObject inspectObject;
    public ItemCanvasController itemCanvasController;

    public void Spawn(GameObject objectPrefab)
    {
        itemCanvasController = objectPrefab.GetComponent<ItemCanvasController>();
        this.objectPrefab = objectPrefab;
        spawnedObject = Instantiate(
            objectPrefab,
            new Vector3(-1f, 3.5f, -250.5f),
            Quaternion.identity
        );
        spawnedObject.transform.localScale = new Vector3(
            1f * itemCanvasController.scale.x,
            1f * itemCanvasController.scale.y,
            1f * itemCanvasController.scale.z
        ); ;
        spawnedObject.transform.eulerAngles = new Vector3(
            0f + itemCanvasController.rotation.x,
            0f + itemCanvasController.rotation.y,
            0f + itemCanvasController.rotation.z
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
