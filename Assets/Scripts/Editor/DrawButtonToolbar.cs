using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace UnityToolbarExtender
{
	 

	[InitializeOnLoad]
	public class DrawButtonToolbar
	{
		static DrawButtonToolbar()
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
                Debug.Log("gg");
            });
            DrawButton("B", "TOOLTIP", GUIStyles.largeSize, () => {
                Debug.Log("gg");
            });
            DrawButton("C", "TOOLTIP", GUIStyles.commandButtonStyle, () => {
                Debug.Log("gg");
            });
            DrawButton("D", "TOOLTIP", GUIStyles.GetCustomStyle(), () => {
                Debug.Log("gg");
            }); 
            
        }
		static void OnLeftUI()
		{
			GUILayout.FlexibleSpace();

			if(GUILayout.Button(new GUIContent("1", "Start Scene 1"), GUIStyles.commandButtonStyle))
			{
                Debug.Log("gg");
            } 
            if (GUILayout.Button(new GUIContent("2", "Start Scene 2"), GUIStyles.commandButtonStyle))
            {
                Debug.Log("gg");
            }
            if (GUILayout.Button(new GUIContent("Update", "Start Scene 2"), GUIStyles.commandButtonStyle))
            {
                Debug.Log("gg");
            }

        }
	}

	 
}