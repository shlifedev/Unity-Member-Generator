using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace UnityToolbarExtender
{ 
	[InitializeOnLoad]
	public class DrawToolbar
	{
		static DrawToolbar()
		{
            ToolbarExtender.LeftToolbarGUI.Add(OnLeftUI);
            ToolbarExtender.RightToolbarGUI.Add(OnRightUI);
        }


        static void DrawButton(string title, string tooltip, GUIStyle guiStyle, System.Action onClick)
        {
            if (GUILayout.Button(new GUIContent(title, tooltip), guiStyle))
            {
                onClick?.Invoke();
            }
        }

        static void OnRightUI()
        {
            GUILayout.FlexibleSpace();

            DrawButton("A", "TOOLTIP", GUIStyles.middleSize, () => {
                Debug.Log(" Your Click A Button. [RIGHT]");
            });
            DrawButton("B", "TOOLTIP", GUIStyles.largeSize, () => {
                Debug.Log(" Your Click B Button. [RIGHT]");
            });
            DrawButton("C", "TOOLTIP", GUIStyles.commandButtonStyle, () => {
                Debug.Log(" Your Click C Button. [RIGHT]");
            });
            DrawButton("D", "TOOLTIP", GUIStyles.commandButtonStyle, () => {
                Debug.Log(" Your Click DButton. [RIGHT]");
            }); 
            
        }
		static void OnLeftUI()
		{
			GUILayout.FlexibleSpace();

            DrawButton("Q", "TOOLTIP", GUIStyles.middleSize, () => {
                Debug.Log(" Your Click Q Button. [LEFT]");
            });
            DrawButton("W", "TOOLTIP", GUIStyles.largeSize, () => {
                Debug.Log(" Your Click W Button. [LEFT]");
            });
            DrawButton("E", "TOOLTIP", GUIStyles.commandButtonStyle, () => {
                Debug.Log(" Your Click E Button. [LEFT]");
            });
            DrawButton("R", "TOOLTIP", GUIStyles.commandButtonStyle, () => {
                Debug.Log(" Your Click R Button. [LEFT]");
            });

        }
	}

	 
}