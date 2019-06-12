using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AutoAddParticle : MonoBehaviour
{

    [MenuItem("Tools/AddParticleToWalls")]
    public static void AddParticles()
    {
        MeshFilter[] mashfilters = FindObjectsOfType<MeshFilter>();
        Debug.Log("Find Mesh count: " + mashfilters.Length);

        for (int i = 0; i < mashfilters.Length; i++) 
        {
            if(string.Compare(mashfilters[i].name, "wall_stone_end", System.StringComparison.Ordinal) == 0)
            {
                ParticleSystem ps = mashfilters[i].gameObject.GetComponent<ParticleSystem>();

                if (ps != null)
                    DestroyImmediate(ps);
            }

        }

    }

}
