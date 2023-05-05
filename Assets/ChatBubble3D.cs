using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble3D : MonoBehaviour
{
    public static void Create(Transform parent, Vector3 localPosition, string text) {
        Transform chatBubbleTransform = Instantiate(parent);
        chatBubbleTransform.localPosition = localPosition;
        chatBubbleTransform.GetComponent<ChatBubble3D>();

        Destroy(chatBubbleTransform.gameObject, 6f);
    }
}
