using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorLineAttribute : PropertyAttribute
{
    public float lineHeight;
    public float lineWidth;
    public Color lineColor = Color.red;
	
	public ColorLineAttribute(float lineHeight, float lineWidth, float red, float green, float blue)
    {
        this.lineHeight = lineHeight;
        this.lineWidth = lineWidth;

        this.lineColor = new Color(red, green, blue);
    }

}
[CustomPropertyDrawer(typeof(ColorLineAttribute))]
public class ColorLineDrawer : DecoratorDrawer
{
    ColorLineAttribute colorLine
    {
        get { return ((ColorLineAttribute)attribute); }
    }
    public override float GetHeight()
    {
        return 10f;
    }
    public override void OnGUI(Rect position)
    {
        GUIStyle centerStyle = GUI.skin.GetStyle("Label");
        centerStyle.alignment = TextAnchor.MiddleCenter;

        float lineX = (position.x + (position.width / 2)) - colorLine.lineWidth / 2;
        float lineY = position.y;
        float lineWidth = colorLine.lineWidth;
        float lineHeight = colorLine.lineHeight;

        //Store the current color in the previous color variable, set GUI.color equal to whatever color is provided by the constructor, draw the line using the specified coordinates by 
        //tinting the whiteTexture with the lineColor, and store the color as the previous color.
        
        Color prevColor = GUI.color;
        GUI.color = colorLine.lineColor;
        EditorGUI.DrawPreviewTexture(new Rect(lineX, lineY, lineWidth, lineHeight), Texture2D.whiteTexture);
        GUI.color = prevColor;
    }
}
