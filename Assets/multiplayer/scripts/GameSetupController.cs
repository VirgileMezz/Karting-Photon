using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
public class GameSetupController : MonoBehaviour
{
    public static GameSetupController gs;
    public Transform[] spawnPoints;

    private void OnEnable()
    {
        if(GameSetupController.gs == null)
        {
            GameSetupController.gs = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }


    private void CreatePlayer()
    {
        Debug.Log("Creating player");
        //PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PhotonPlayer"), Vector3.zero, Quaternion.identity);
        //PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Kart_Player"), Vector3.zero, Quaternion.identity);
        //int spawnIndex = Random.Range(0, GameSetupController.gs.spawnPoints.Length);
        
        Debug.Log(PhotonNetwork.PlayerList.Length);
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Kart_Player"), spawnPoints[PhotonNetwork.PlayerList.Length-1].position, spawnPoints[PhotonNetwork.PlayerList.Length-1].rotation, 0);
        
    }

    // Update is called once per frame

}
