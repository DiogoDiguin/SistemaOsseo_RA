using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBody : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    void Start()
    {
        cube.SetActive(true);
        sphere.SetActive(true);
    }

    public void BtnShowBody(){
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
    }
}
