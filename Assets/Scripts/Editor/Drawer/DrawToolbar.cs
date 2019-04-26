using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace UnityToolbarExtender
{

    public class TimeScaleSlider
    { 
        public string value = "1";
        public void Draw()
        {
            if (string.IsNullOrEmpty(value)) { value = "1"; }

            float outerValue = 1;

            GUILayout.BeginHorizontal();
            GUILayout.Label("TimeScale:");
            GUILayout.FlexibleSpace();
            value = GUILayout.TextField(value); 
            GUILayout.EndHorizontal();
            if (float.TryParse(value, out outerValue) == false)
            {
                value = null;
            }

            if(outerValue != -1)
            Time.timeScale = outerValue;
        }
    }
    [InitializeOnLoad]
    public class DrawToolbar
    {
        private static TimeScaleSlider timeScaleSlider = new TimeScaleSlider();
        static DrawToolbar()
		{
            Debug.Log("A");
            EditorApplication.playModeStateChanged += OnPlayModeChanged;
            ToolbarExtender.LeftToolbarGUI.Add(OnLeftUI);
          //  ToolbarExtender.LeftToolbarGUI.Add(timeScaleSlider.Draw);
            ToolbarExtender.RightToolbarGUI.Add(OnRightUI); 
        }


        static void OnPlayModeChanged(PlayModeStateChange obj)
        {
                EditorWindow.FocusWindowIfItsOpen<SceneView>();
                if (obj == PlayModeStateChange.EnteredPlayMode)
                {
                    ToolbarExtender.LeftToolbarGUI.Remove(OnLeftUI);
                    ToolbarExtender.RightToolbarGUI.Remove(OnRightUI);
                //    ToolbarExtender.LeftToolbarGUI.Remove(timeScaleSlider.Draw);
                }
                if (obj == PlayModeStateChange.EnteredEditMode)
                {
                    ToolbarExtender.RightToolbarGUI.Add(OnRightUI);
                    ToolbarExtender.LeftToolbarGUI.Add(OnLeftUI);
                  //  ToolbarExtender.LeftToolbarGUI.Add(timeScaleSlider.Draw);
                }
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