﻿using System;
using System.Collections.Generic;
using System.Reflection;
using FMachine;
using FMachine.Shapes;
using FMachine.Shapes.Nodes;
using FMachine.Shapes.Sockets;
using UnityEngine;
//using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace FollowMachineDll.Utility
{
    public abstract class EditorTools
    {
        public static EditorTools Instance;
        public abstract bool PropertyField(Object o, string propertyPath);
        public abstract int Popup(string label, int index, string[] displayedOptions);
        public abstract void Undo_RecordObject(Object objectToUndo, string name);
        public abstract string GetParameter(Object objectToUndo,
            string lable, Type type, string valueString);
        public abstract GUIStyle TintStyle(GUIStyle style, Color tintColor);
        public abstract void DrawBox(GUIStyle style, Rect rect, GUIContent guiContent, bool b, bool b1, bool b2, bool b3);
        public abstract string[] GetAnimationStates(Animator animator);
        public abstract ScriptableObject GetAsset(string name, Type type);
        public abstract void AddFollowMachine(FollowMachine followmachine);
        public abstract void DrawBezierEdge(Vector2 p1, Vector2 p2, Color forgroundColor, Color backColor, float thickness);
        public abstract IMouseInteractable IsMouseOverEdge(Edge edge, Vector2 mousePos);
        public abstract void DrawEdge(Edge edge);
        public abstract bool DisplayDialog(string title, string message, string ok, string cancel);
        public abstract bool LanguageField(Object objectToUndo, string lable, ref string entryName);
        public abstract void IconField(Object objectToUndo, string lable, ref string entryName);
        public abstract void Space();
        public abstract bool LanguageListField(Object objectToUndo, string lable, List<string> entryNameList);
        public abstract void DrawTexture(Rect rect, Texture2D texture, Color color, string text="");
        public abstract void DrawTexture(Rect rect, Texture2D texture, GUIStyle style, Color color, string text = "");
        public abstract void SetVerticalResizeMouseCursor(Rect rect);
        public abstract bool TextField(string lable, ref string field);
        public abstract void OpenScript(MonoBehaviour monoBehaviour);
        public abstract void FocusOnInspector();
        public abstract MethodInfo GetMethodInfo(GameObject gameObject, ref string componentName, ref string methodName);
        public abstract PropertyInfo GetDynamicParameter(GameObject gameObject, ref GameObject pGameObject,
            ref string pText, Type parameterType);
        public abstract void BoldLabel(string text);
        public abstract void FocusTo(Node node, bool zooming);
        public abstract void DrawDotedLine(Vector2 p1, Vector2 p2);
        public abstract void ShowContexMenu(Edge edge);
        public abstract void ShowContexMenu(InputSocket edge);
        public abstract void ShowContexMenu(OutputSocket socket);
    }
}
