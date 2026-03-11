using UnityEngine;

public class puzzleSolver : MonoBehaviour
{
    [SerializeField] private puzzleScript.PuzzleItem puzzleItem;

    private playerMovement playermovement;
    private ObjectData data;
    public puzzleScript.PuzzleItem GetPuzzleItem()
    {
        return puzzleItem;
    }

    
    public void solvedIt()
    {

        Debug.Log("weird.");
    }
}
