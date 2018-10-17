using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateData : ScriptableObject {
  public string Message = "this_is_test_data";

  [MenuItem("Shamaton/CreateData")]
  static void CreateObject() {
    CreateData data = CreateInstance<CreateData>();
    string path = AssetDatabase.GenerateUniqueAssetPath("Assets/Resources/Data_"+ Application.unityVersion + ".asset");
    AssetDatabase.CreateAsset(data, path);
    AssetDatabase.Refresh();
  }

}

public class CreateBundler {
  [MenuItem("Shamaton/CreateBundle")]
  static void CreateBundle() {
    Debug.Log("create bundle");
    BuildPipeline.BuildAssetBundles(
      "Assets/AssetBundles",
      BuildAssetBundleOptions.ChunkBasedCompression,
      BuildTarget.Android
    );
  }
}