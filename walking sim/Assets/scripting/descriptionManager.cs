using TMPro;
using UnityEngine;

public class descriptionManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject descriptionPanel;
    public TextMeshProUGUI objectName;
    public TextMeshProUGUI objectDescription;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnEnable()
    {
        playerMovement.OnObjectDescripton += DescribeObject;
    }

    public void OnDisable()
    {
        playerMovement.OnObjectDescripton -= DescribeObject;
    }

    void DescribeObject(ObjectData data)
    {
        if (data == null)
        {
            Debug.Log("NPC DATA NULL");
        }

        if (descriptionPanel != null) descriptionPanel.SetActive(true);
        if (objectName != null) objectName.text = data.objectName;
        if (objectDescription != null) objectDescription.text = data.objectDescription;

        Debug.Log($"Dialogue start with {data.objectName}: {data.objectDescription}");
    }
}
