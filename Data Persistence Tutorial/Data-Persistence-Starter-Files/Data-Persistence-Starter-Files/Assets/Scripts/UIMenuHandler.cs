using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class UIMenuHandler : MonoBehaviour
{
    
    //public static string playerName;
    public TMP_InputField playerNameInput;
    public TextMeshProUGUI highScoreText;
    
    void Awake()
    {
        highScoreText.text = $"Best Score : {DataPersistence.Instance.highScoreName} - {DataPersistence.Instance.highScore}";
        if(DataPersistence.Instance.playerName != "")
        {
             playerNameInput.text = DataPersistence.Instance.playerName;
        }
                        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        if(playerNameInput.text.ToString() == "")
        {
            DataPersistence.Instance.playerName = "Dickhead";
        }
        else
        {
            DataPersistence.Instance.playerName = playerNameInput.text.ToString();
        }
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit(); // original code to quit Unity player
        #endif
    }
}
