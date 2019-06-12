using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental;
using UnityEditor;
using System.IO;

public class EnterSceneUI : MonoBehaviour
{
    public void OnEnterBtn()
    {
        StartCoroutine("InitializeLevelAsync");
    }

    IEnumerator InitializeLevelAsync()
    {
        //string[] files = Directory.GetFiles("/Users/lipengyue/AssetBundleBag/");
        //if (!File.Exists("/Users/lipengyue/AssetBundleBag/occlusioncullingtest"))
        //yield break;

        //foreach (var f in files)
        //{
        //    Debug.Log(f);
        //}

        //yield break;
        Debug.Log("start load");
        AssetBundleCreateRequest createRequest = AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes("/Users/lipengyue/AssetBundleBag/occlusioncullingtest"));
        yield return createRequest;

        Debug.Log(" load finish");
        //var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "occlusioncullingtest"));
        //if (myLoadedAssetBundle == null)
        //{
        //    Debug.Log("Failed to load AssetBundle!");
        //    yield break;
        //}

        AsyncOperation op = SceneManager.LoadSceneAsync("OcclusionCullingTest");

        yield return 0;
    }
}
