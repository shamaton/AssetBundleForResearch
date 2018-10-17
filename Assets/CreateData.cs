using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateData : ScriptableObject {
  public string Message = "this_is_test_data";

  [MenuItem("Assets/CreateData")]
  static void CreateObject() {
    CreateData data = CreateInstance<CreateData>();
    string path = AssetDatabase.GenerateUniqueAssetPath("Assets/Resources/Data_"+ Application.unityVersion + ".asset");
    AssetDatabase.CreateAsset(data, path);
    AssetDatabase.Refresh();
  }
}