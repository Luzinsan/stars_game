using System;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public GameObject obj;
    private Save sv = new Save();
    private string path;

    private void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            Debug.Log("Добро пожаловать. Ваш текущий рекорд: " + sv.score);
        }
        else obj.SetActive(true);
    }

    public void GetScore(string score)
    {
        
        sv.score = int.Parse(score);
        Debug.Log("Сохранение считано!");

        
    }

    private void OnApplicationQuit()
    {
        
        File.WriteAllText(path,JsonUtility.ToJson(sv));
        
    }
}


[Serializable] public class Save
{
    public int score;
}