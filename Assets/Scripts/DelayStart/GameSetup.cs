using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    void Start(){
        CreatePlayer();
    }

    private void CreatePlayer(){
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Creating Player");
            player1 = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "P1Bullet"), new Vector3(41,16,0), Quaternion.identity, 0);
            
        }
        else {
            Debug.Log("Creating Player");
            player2 = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "P2Bullet"), new Vector3(41,-13,0), Quaternion.identity, 0);
            
        }
        
    }
}
