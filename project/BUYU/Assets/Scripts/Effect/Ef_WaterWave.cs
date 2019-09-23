using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_WaterWave : MonoBehaviour
{
    public Texture[] Textures;
    private int _index = 0;
    private Material _material;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        InvokeRepeating("ChangeTexture", 0, 0.1f);
    }

    private void ChangeTexture()
    {
        _material.mainTexture = Textures[_index];
        _index = (_index + 1) % Textures.Length;
    }
}
