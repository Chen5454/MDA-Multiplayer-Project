using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;

    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;
   


    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(minX,maxX),0.5f,Random.Range(minZ,maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
    }

   
    
}
