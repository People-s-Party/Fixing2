using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("GameScene1");

    }

    public void ExitGame()
    {
        Application.Quit();

    }

   /* IEnumerator LoadSC()
    {
        #region  处于scene01

        GameObject go0 = Instantiate(prefab);
        go0.name = SceneManager.GetActiveScene().name + "_cube";
        //go.transform.SetParent(this.transform);

        yield return SceneManager.LoadSceneAsync("GameScene2", LoadSceneMode.Additive);
        Debug.Log("[log1] >> " + SceneManager.GetActiveScene().name); //scene01

        Scene _scene02 = SceneManager.GetSceneByName("GameScene2");
        yield return new WaitUntil(() => _scene02.isLoaded);
        Debug.Log(SceneManager.sceneCount + " / " + _scene02.isLoaded);

        SceneManager.MoveGameObjectToScene(go0, _scene02); //go必须在scene1的root下

        #endregion

        #region  处于scene02

        // 处于scene02
        SceneManager.SetActiveScene(_scene02);
        Debug.Log("[log2] >> " + SceneManager.GetActiveScene().name);

        GameObject go1 = Instantiate(prefab); //会创建到当前Active的场景
        go1.name = SceneManager.GetActiveScene().name + "_cube";

        #endregion
    }*/
}
