using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    [SerializeField] private GameObject winMessage; 
    [SerializeField] private Text winText;

    private PlayerState firstState;
    private PlayerState secondState;

    // Start is called before the first frame update
    void Start()
    {
        firstState = playerOne.GetComponent<PlayerState>();
        secondState = playerTwo.GetComponent<PlayerState>();
    }

    // Update is called once per frame
    void Update()
    {
        int player = whoIsKoed();
        if(player == 0){
            winText.text = "Player 2 won!";
            winMessage.gameObject.SetActive(true);
        }else if(player == 1){
            winText.text = "Player 1 won!";
            winMessage.gameObject.SetActive(true);
        }
    }

    public void restart(){
        Application.LoadLevel(Application.loadedLevel);
    }

    private int whoIsKoed(){
        if(firstState.isKoed) return 0; // first player is koed
        else if(secondState.isKoed) return 1; // second player is koed

        return -1;
    }
}
