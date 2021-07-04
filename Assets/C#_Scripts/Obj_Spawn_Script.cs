using UnityEngine;

public class Obj_Spawn_Script : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab; //Add a prefab in Inspector


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
