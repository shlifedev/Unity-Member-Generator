﻿using UnityEditor; 
using UnityEngine;

namespace UnityToolbarExtender
{
	[InitializeOnLoad]
	public static class DrawToggleToolbar
	{
		static bool m_enabled;

		static bool Enabled
		{
			get { return m_enabled; }
			set
			{
				m_enabled = value;
				EditorPrefs.SetBool("SceneViewFocuser", value);
			}
		}

		static DrawToggleToolbar()
		{
			m_enabled = EditorPrefs.GetBool("SceneViewFocuser", false);
			EditorApplication.playModeStateChanged += OnPlayModeChanged;
			EditorApplication.pauseStateChanged += OnPauseChanged; 
            ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI); 
        }

        static void OnPauseChanged(PauseState obj)
		{
			if (Enabled && obj == PauseState.Unpaused)
			{
				// Not sure why, but this must be delayed
				EditorApplication.delayCall += EditorWindow.FocusWindowIfItsOpen<SceneView>;
			}
		}

		static void OnPlayModeChanged(PlayModeStateChange obj)
		{
			if (Enabled && obj == PlayModeStateChange.EnteredPlayMode)
			{
				EditorWindow.FocusWindowIfItsOpen<SceneView>();
                if (obj == PlayModeStateChange.EnteredPlayMode)
                {
                    ToolbarExtender.LeftToolbarGUI.Remove(OnToolbarGUI);
                }
                if (obj == PlayModeStateChange.EnteredEditMode)
                {
                    ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
                }
            }
		}

        static void OnToolbarGUI()
        {
            var tex = EditorGUIUtility.IconContent(@"UnityEditor.SceneView").image; 
            GUI.changed = false;

            GUILayout.Toggle(m_enabled, new GUIContent(null, tex, "Focus SceneView when entering play mode"), "Command");
            if (GUI.changed)
            {
                Enabled = !Enabled;
            }
        }


    }
}