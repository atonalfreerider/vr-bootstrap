using System.Linq;
using TMPro;
using UnityEngine;

/// <summary>
/// This is a wrapper for a <see cref="TextMeshPro"/> TextMeshPro that is attached to the prefab that is
/// instantiated every time a new TextBox is created.
/// </summary>
public class TextBox : MonoBehaviour
{
    static TextBox TextBoxPrefab;
        
    // Components - Attached in Unity Editor
    public TextMeshPro TextField;
     
    public TextAlignmentOptions Alignment
    {
        get => TextField.alignment;
        set
        {
            TextField.alignment = value;

            TextField.rectTransform.pivot = value switch
            {
                TextAlignmentOptions.Right => new Vector2(1, 0.5f),
                TextAlignmentOptions.Center => new Vector2(0.5f, 0.5f),
                TextAlignmentOptions.TopLeft => new Vector2(0, 1),
                TextAlignmentOptions.Top => new Vector2(0.5f, 1),
                TextAlignmentOptions.Left => new Vector2(0, 0.5f),
                _ => new Vector2(0, 0.5f) // default left
            };
        }
    }

    public string Text
    {
        set => TextField.SetText(value);
    }

    #region Font Setters

    public float Size
    {
        set => TextField.fontSize = value;
    }

    public Color Color
    {
        set => TextField.color = value;
    }

    #endregion

    public void SetFixedWithWrap(float width)
    {
        TextField.autoSizeTextContainer = false;
        TextField.textWrappingMode = TextWrappingModes.Normal;
        TextField.rectTransform.sizeDelta = new Vector2(width, 0f);
    }

    public static TextBox Create(
        string text,
        TextAlignmentOptions align = TextAlignmentOptions.Left)
    {
        if (TextBoxPrefab == null)
        {
            TextBoxPrefab = Resources.Load<TextBox>("TextBox");
        }

        TextBox textBox = Instantiate(TextBoxPrefab);
        textBox.name = $"TextBox: {text.Split('\n').First()}";

        textBox.Alignment = align;
        textBox.Text = text;

        return textBox;
    }
}