using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBody : MonoBehaviour
{
    /*[SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;*/
    [SerializeField] private GameObject cranio;
    [SerializeField] private GameObject tronco;
    [SerializeField] private GameObject bracos;
    [SerializeField] private GameObject pernas;
    void Start()
    {
        /*cube.SetActive(true);
        sphere.SetActive(true);*/
        cranio.SetActive(true);
        tronco.SetActive(true);
        bracos.SetActive(true);
        pernas.SetActive(true);
    }

    public void BtnShowCranio(){
        if (cranio != null){
            // Alterna o estado ativo/inativo do GameObject 'cranio'
            cranio.SetActive(!cranio.activeSelf);
        }
    }
    public void BtnShowTronco(){
        if (tronco != null){
            // Alterna o estado ativo/inativo do GameObject 'cranio'
            tronco.SetActive(!tronco.activeSelf);
        }
    }
    public void BtnShowBracos(){
        if (bracos != null){
            // Alterna o estado ativo/inativo do GameObject 'cranio'
            bracos.SetActive(!bracos.activeSelf);
        }
    }
    public void BtnShowPernas(){
        if (pernas != null){
            // Alterna o estado ativo/inativo do GameObject 'cranio'
            pernas.SetActive(!pernas.activeSelf);
        }
    }

    /*public void BtnShowBody(){
        cube.SetActive(true);
        sphere.SetActive(true);
    }

    public void BtnHideBody(){
        cube.SetActive(false);
        sphere.SetActive(false);
    }

    public void BtnShowCube(){
        cube.SetActive(true);
        sphere.SetActive(false);
    }

    public void BtnShowSphere(){
        sphere.SetActive(true);
        cube.SetActive(false);
    }*/
}
