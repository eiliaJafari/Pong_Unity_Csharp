using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text PlayerScoreText;
    public Text ComputerScoreText;

    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
            _playerScore++;
            
            this.PlayerScoreText.text = _playerScore.ToString();
            this.ball.ResetPosition();
            this.ball.AddStartingForce();
    }

    public void ComputerScores()
    {
        _computerScore++;
        
        this.ComputerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    
    
    
}
