using UnityEngine;
using TMPro;


public class TimerText : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverText;
    [SerializeField] private Player _player;
    [SerializeField] private float _maxGameTime = 30.0f;
    [SerializeField] private TMP_Text _timerDisplay;
    [SerializeField] private Timer _gameTimer;
    private float deci;
    private int integer;
    private bool buer;
    private string text;

    // STEP 8 -----------------------------------------------------------------
    // This method runs ONCE, when the GAME BEGINS. It is called by Unity.
    // Uncomment this method and fill in the method name.
    //
    private void Start ()
    {
        // Inside this method, CALL the BeginTimer method on _gameTimer.
        // Pass in _maxGameTime as the ARGUMENT.
        _gameTimer.BeginTimer(_maxGameTime);
        Debug.Log(_maxGameTime);

        Debug.Log(deci);
        Debug.Log(integer);
        Debug.Log(buer);
        Debug.Log(text);

    }
    // STEP 8 -----------------------------------------------------------------

    // ------------------------------------------------------------------------
    private void Update()
    {
        // STEP 9 -------------------------------------------------------------
        // Inside this Update method, we're going to CHECK IF OUR TIMER RAN OUT.
        // IF it's done, CALL the GameOver method.
        // 
        // If you need a hint, check how the KickWeapon class did this.
        // But remember the timer object in this class is _gameTimer.
        //
        // Write your if statement below.

        // STEP 9 -------------------------------------------------------------
        if (_gameTimer.IsFinished())
        {
           GameOver();
        }
        else
        {
            
            _timerDisplay.text = _gameTimer.GetTimeLeft().ToString();

        }
        Debug.Log(_gameTimer.GetTimeLeft());
    }
    
    // ------------------------------------------------------------------------
    private void GameOver ()
    {
        _player.SetGameOver();
        _gameOverText.SetActive(true);
    }
}