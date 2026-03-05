using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI displayName;
    public TextMeshProUGUI placeholderOpeningLine;

    public Transform choicesContainer; // choice button spawn parent
    public Button choiceButtonPrefab;//prefabs yayyyy

    private NPCData currentNode;
    private int lineIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnEnable()
    {
        playerMovement.OnDialogueReqested += StartDialogue;
    }

    public void OnDisable()
    {
        playerMovement.OnDialogueReqested -= StartDialogue;
    }

    void StartDialogue(NPCData nPCData)
    {
        if(nPCData == null)
        {
            Debug.Log("NPC DATA NULL");
        }

        if(dialoguePanel != null) dialoguePanel.SetActive(true);
        if (displayName != null) displayName.text = nPCData.displayName;
        if(placeholderOpeningLine != null) placeholderOpeningLine.text = nPCData.placeHolderOpeningLine;

        Debug.Log($"Dialogue start with {nPCData.displayName}: {nPCData.placeHolderOpeningLine}");
    }
}
