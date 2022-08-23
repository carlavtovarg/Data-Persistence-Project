using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler Instance;
    public string namePlayer;
    public string score;
    public string nameEntered;

    private void Awake()
    {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitApp() {

    }
    [System.Serializable]
    class SaveData {
        public string namePlayer;
        public string score;
    }




    public void SaveName() {
        SaveData data = new SaveData();
        data.namePlayer = namePlayer;
        data.score = score;
         string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void ReadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            namePlayer = data.namePlayer;
            score = data.score;
        }
        
    }

}
