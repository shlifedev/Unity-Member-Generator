using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace UnityToolbarExtender.Examples
{
	static class GUIStyles
	{
        public static readonly GUIStyle commandButtonStyle;
        public static readonly GUIStyle middleSize;
        public static readonly GUIStyle largeSize;


        static GUIStyles()
		{
            commandButtonStyle = new GUIStyle("Command")
            {
                fixedWidth = 50,
				fontSize = 11,
				alignment = TextAnchor.MiddleCenter,
				imagePosition = ImagePosition.ImageAbove,
				fontStyle = FontStyle.Normal
			};
            middleSize = new GUIStyle("Command")
            {
                fixedWidth = 70,
                fontSize = 11,
                alignment = TextAnchor.MiddleCenter,
                imagePosition = ImagePosition.ImageAbove,
                fontStyle = FontStyle.Normal
            };
            largeSize = new GUIStyle("Command")
            {
                fixedWidth = 100,
                fontSize = 11,
                alignment = TextAnchor.MiddleCenter,
                imagePosition = ImagePosition.ImageAbove,
                fontStyle = FontStyle.Normal
            };
        }
	}

	[InitializeOnLoad]
	public class DrawButtonToolbar
	{
		static DrawButtonToolbar()
		{
            ToolbarExtender.LeftToolbarGUI.Add(OnLeftUI);
            ToolbarExtender.RightToolbarGUI.Add(OnRightUI);
        }

        static void OnRightUI()
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(new GUIContent("Update", "Start Scene 2"), GUIStyles.largeSize))
            {
                Debug.Log("gg");
            }
            if (GUILayout.Button(new GUIContent("Update", "Start Scene 2"), GUIStyles.middleSize))
            {
                Debug.Log("gg");
            }
            if (GUILayout.Button(new GUIContent("Update", "Start Scene 2"), GUIStyles.largeSize))
            {
                Debug.Log("gg");
            }
            
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