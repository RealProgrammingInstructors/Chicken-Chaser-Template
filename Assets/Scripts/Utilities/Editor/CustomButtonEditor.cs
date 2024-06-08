﻿using UI;
using UnityEditor;
using UnityEditor.UI;

namespace Editor
{
    //Generated by CHATGPT, this is a very special script that allows Unity to change how the editor renders.
    //This script does NOT exist in builds because it's in the EDITOR folder. if it was not in the editor folder, it would cause errors.
    [CustomEditor(typeof(CustomButton))]
    public class CustomButtonEditor : ButtonEditor
    {
        SerializedProperty onReleasedProperty;

        protected override void OnEnable()
        {
            base.OnEnable();
            onReleasedProperty = serializedObject.FindProperty("m_OnReleased");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();

            EditorGUILayout.PropertyField(onReleasedProperty);

            serializedObject.ApplyModifiedProperties();
        }
    }
}