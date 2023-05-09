using UnityEngine;
using UnityEngine.SceneManagement;

using DG.Tweening;

public class GameManager : MonoBehaviour
{
    static private int level = 1;

    static public bool[] lvlList = new bool[7];

    public bool isFinished = false;

    private Scene scene;

    /*public SwerveMovement SwerveMovement;
    public SwerveInputSystem SwerveInputSystem;
    public PlayerMover PlayerMover;

    public RectTransform WinUI;
    public RectTransform FailUI;*/

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;
    }

    private void Update()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "level1")
        {
            if (isFinished == true)
            {
                PlayerPrefs.SetInt("level1", 1);
                PlayerPrefs.SetInt("level2", 1);
                //lvlList[2] = true;
            }
        }
        else if (scene.name == "level2")
        {
            if (isFinished == true)
            {
                PlayerPrefs.SetInt("level3", 1);
                //lvlList[3] = true;
            }
        }
        else if (scene.name == "level3")
        {
            if (isFinished == true)
            {
                PlayerPrefs.SetInt("level4", 1);
                //lvlList[4] = true;
            }
        }
        else if (scene.name == "level4")
        {
            if (isFinished == true)
            {
                PlayerPrefs.SetInt("level5", 1);
                //lvlList[5] = true;
            }
        }
        else if (scene.name == "level5")
        {
            if (isFinished == true)
            {
                PlayerPrefs.SetInt("level6", 1);
                //lvlList[6] = true;
            }
        }
        else if (scene.name == "level6")
        {
            if (isFinished == true)
            {
                //PlayerPrefs.SetBool("level1", true);
                //lvlList[6] = true;
            }
        }
    }

    /*public void ActivateWinUI()
    {
        WinUI.gameObject.SetActive(true);
        Vector3 defaultScale = WinUI.transform.localScale;

        WinUI.transform.localScale = Vector3.one * 0.0001f;
        WinUI.DOScale(defaultScale, 1f).SetEase(Ease.OutBounce);
    }

    public void ActivateFailUI()
    {
        FailUI.gameObject.SetActive(true);
        Vector3 defaultScale = FailUI.transform.localScale;

        FailUI.transform.localScale = Vector3.one * 0.0001f;
        FailUI.DOScale(defaultScale, 1f).SetEase(Ease.OutBounce);
    }*/

    public void StartGame()
    {
        if (PlayerPrefs.GetInt("level") == 0)
        {
            isFinished = false;
            PlayerPrefs.SetInt("level", 1);
            //lvlList[level] = true;
        }

        level = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene(level);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        if (scene.name == "level1")
        {
            SceneManager.LoadScene("level1");
        }
        else if (scene.name == "level2")
        {
            SceneManager.LoadScene("level2");
        }
        else if (scene.name == "level3")
        {
            SceneManager.LoadScene("level3");
        }
        else if (scene.name == "level4")
        {
            SceneManager.LoadScene("level4");
        }
        else if (scene.name == "level5")
        {
            SceneManager.LoadScene("level5");
        }
        else if (scene.name == "level6")
        {
            SceneManager.LoadScene("level6");
        }
    }

    public void NextLevel()
    {
        level = PlayerPrefs.GetInt("level");

        if(scene.name == "level1" && isFinished == true)
        {
            level = 2;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
        else if (scene.name == "level2" && isFinished == true)
        {
            if (isFinished == true)
            {
                lvlList[level] = true;
            }

            level = 3;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
        else if (scene.name == "level3" && isFinished == true)
        {
            if (isFinished == true)
            {
                lvlList[level] = true;
            }

            level = 4;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
        else if (scene.name == "level4" && isFinished == true)
        {
            if (isFinished == true)
            {
                lvlList[level] = true;
            }

            level = 5;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
        else if (scene.name == "level5" && isFinished == true)
        {
            if (isFinished == true)
            {
                lvlList[level] = true;
            }

            level = 6;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
        else if (scene.name == "level6" && isFinished == true)
        {
            if (isFinished == true)
            {
                lvlList[level] = true;
            }

            level = 1;
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene(level);
        }
    }

    public void OpenLevel1()
    {
        if (PlayerPrefs.GetInt("level1") == 1)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void OpenLevel2()
    {
        if (PlayerPrefs.GetInt("level2") == 1)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void OpenLevel3()
    {
        if (PlayerPrefs.GetInt("level3") == 1)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void OpenLevel4()
    {
        if (PlayerPrefs.GetInt("level4") == 1)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void OpenLevel5()
    {
        if (PlayerPrefs.GetInt("level5") == 1)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void OpenLevel6()
    {
        if (PlayerPrefs.GetInt("level6") == 1)
        {
            SceneManager.LoadScene(6);
        }
    }
}
