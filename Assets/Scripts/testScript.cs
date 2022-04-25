using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public GameObject cube;
    private List<GameObject> cubeList;

    private int numberOfCube;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCube = 1;
        cubeList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfCube < 3)
        {
            int random = Random.Range(1, 3);
            int x = 0;
            if (random.Equals(1))
            {
                x = -1;
            }
            else
            {
                x = 1;
            }
            Vector3 cubeVector = new Vector3(x,6,0);
            GameObject instantiateCube = Instantiate(cube,cubeVector, Quaternion.identity);
            cubeList.Add(instantiateCube);
            numberOfCube++;
        }
        
        foreach (GameObject aCube in cubeList)
        {
            Debug.Log("check a cube" + aCube.GetHashCode());
            if (aCube.gameObject.transform.position.y <= -6)
            {
                Destroy(aCube.gameObject);
                cubeList.Remove(aCube);
                numberOfCube--;
            }
        }
    }
}
