using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ReturnPressed()
    {
        SceneManager.LoadScene("menu");
    }
    public void NextManualButtonPressed()
    {
        SceneManager.LoadScene("ManualMultiplayer");
    }
    public void Manual()
    {
        SceneManager.LoadScene("manualUnJugador");
    }
    public void ReturnMultiplayerPressed()
    {
        StartCoroutine(DisconnectAndLoad());
    }

    IEnumerator DisconnectAndLoad()
    {
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.InRoom)
            yield return null;
        SceneManager.LoadScene("menu");
    }

}
