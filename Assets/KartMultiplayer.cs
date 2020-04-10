using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class KartMultiplayer : MonoBehaviourPunCallbacks
{
    private PhotonView pv;
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject cinemachineGo;
    //, IPunObservable
    /*public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        *//*if (stream.IsWriting)
        {
            stream.SendNext(transform.position);
        }
        else
        {

        }*//*
        throw new System.NotImplementedException();
    }*/

    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        if (!pv.IsMine)
        {
            cam.enabled = false;
            cinemachineGo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
