using UnityEngine;
using System.Collections;

public enum Position{
	Middle,
	Bottom,
	Bottom02
}

public class DemoGUI : MonoBehaviour {

	public Texture HUETexture;
	public Material mat;
	public Light CurrentLight;


	private int currentNomber;
	private GameObject currentInstance;
	private GUIStyle guiStyleHeader = new GUIStyle();
	private float colorHUE;
	float dpiScale;

	// Use this for initialization
	void Start () {

		if(Screen.dpi < 1) dpiScale  = 1;
		if(Screen.dpi < 200) dpiScale = 1;
		else dpiScale = Screen.dpi / 200f;
		guiStyleHeader.fontSize = (int)(15f*dpiScale);
		guiStyleHeader.normal.textColor = new Color(1,1,1);

	}

	private void OnGUI()
	{
		GUI.DrawTexture(new Rect(12*dpiScale, 80*dpiScale, 220*dpiScale, 15*dpiScale), HUETexture, ScaleMode.StretchToFill, false, 0);
		float oldColorHUE = colorHUE;
		colorHUE = GUI.HorizontalSlider(new Rect(12*dpiScale, 105*dpiScale, 220*dpiScale, 15*dpiScale), colorHUE, 0, 255*6);
		if(Mathf.Abs(oldColorHUE - colorHUE) > 0.001) ChangeColor();
		GUI.Label(new Rect(240*dpiScale, 105*dpiScale, 30*dpiScale, 30*dpiScale), "Effect color", guiStyleHeader);	
	}

	void ChangeColor()
	{	var color = Hue (colorHUE/255f);
		if(mat==null || !mat.HasProperty("_TintColor")) return;
		var oldColor = mat.GetColor("_TintColor");
		color.a = oldColor.a;
		mat.SetColor("_TintColor", color);
		CurrentLight.color = color;
	}

	Color Hue(float H)
	{
		Color col = new Color(1, 0, 0);
		if(H>=0 && H<1) col = new Color(1, 0, H);
		if(H>=1 && H<2) col = new Color(2-H, 0, 1);
		if(H>=2 && H<3) col = new Color(0, H-2, 1);
		if(H>=3 && H<4) col = new Color(0, 1, 4-H);
		if(H>=4 && H<5) col = new Color(H-4, 1, 0);
		if(H>=5 && H<6) col = new Color(1, 6-H, 0);
		return col;
	}
}

