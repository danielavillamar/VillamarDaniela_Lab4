﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
        // Start is called before the first frame update
        void Start()
        {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CargaNivel(string pNombreNivel)
        {
            SceneManager.LoadScene(pNombreNivel);
            Time.timeScale = 1f;
        }
        

        public void Salir()
        {
            Application.Quit();
            Debug.Log("Has salido del juego");
        }

}