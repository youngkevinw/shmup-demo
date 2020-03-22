using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFunction : MonoBehaviour
{
    // public GameObject Enemy;
    public float time;
    public GameObject GameTitle;
    public GameObject GameOverTitle;
    public GameObject PlayButton;
    public bool IsPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("MenuScreen");
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // if(time>0.5f)
        // {
        //     Vector3 pos = new Vector3(Random.Range(-2.5f,2.5f),4.5f,0);
        //     Instantiate(Enemy,pos,transform.rotation);
        //     time=0f;
        // }

    }
    // public void GameStart()
    // {
    //     IsPlaying = true;
    //     GameTitle.SetActive (false);
    //     PlayButton.SetActive(false);
    // }
    // public void GameOver()
    // {
    //     IsPlaying = false;
    //     GameOverTitle.SetActive(true);
    // }
}
