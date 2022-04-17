using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMachineUI : MonoBehaviour
{
    public GameObject CelesteUI;
    public GameObject VictorUI;
    public GameObject CelestePortal;
    public Animator animator;
    public GameObject player;
    public bool PortalActivated;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        PortalActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rightclick()
    {
        CelesteUI.SetActive(false);
        VictorUI.SetActive(true);
    }

    public void activateCeleste()
    {
        PortalActivated = true;
        Time.timeScale = 1f;
        CelestePortal.SetActive(true);
        // animator.Play("overworldcam");
        player.SetActive(true);
        CelesteUI.SetActive(false);
        Cursor.visible = false;
          Cursor.lockState = CursorLockMode.None;
        
        

    }


}