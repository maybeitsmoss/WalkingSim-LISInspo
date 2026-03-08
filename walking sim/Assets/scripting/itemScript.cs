using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu(menuName = "Scriptable items")]
public class itemScript : ScriptableObject
{

    public Sprite image;
   
    public Vector2Int range = new Vector2Int(5, 4);
    public Type type;
    



}

    

public enum Type
{


    PuzzleItem,
    SpiritBox,
    GeneralInteractable
}
