using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityToolbarExtender
{
    static class GUIStyles
    {
        public static readonly GUIStyle commandButtonStyle;
        public static readonly GUIStyle middleSize;
        public static readonly GUIStyle largeSize;
        public static GUIStyle GetCustomStyle(float width = 50, int fontSize = 11, FontStyle fontStyle = FontStyle.Normal)
        {
            GUIStyle style = new GUIStyle("Command")
            {
                fixedWidth = width,
                fontSize = 11,
                alignment = TextAnchor.MiddleCenter,
                imagePosition = ImagePosition.ImageAbove,
                fontStyle = fontStyle,
                fixedHeight = 50
            };

            return style;
        }

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
}
