﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace JLG.UnityEditor.cSharp.attributes {
#if UNITY_EDITOR
	[CustomPropertyDrawer(typeof(ShowNoEditInInspector))]
	public class ShowNoEditInInspectorDrawer : PropertyDrawer {

		//public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		//	switch (property.propertyType) {
		//		case SerializedPropertyType.AnimationCurve:
		//			break;
		//		case SerializedPropertyType.ArraySize:
		//			break;
		//		case SerializedPropertyType.Boolean:
		//			EditorGUI.LabelField(position, label, new GUIContent(property.boolValue.ToString()));
		//			break;
		//		case SerializedPropertyType.Bounds:
		//			break;
		//		case SerializedPropertyType.Character:
		//			break;
		//		case SerializedPropertyType.Color:
		//			break;
		//		case SerializedPropertyType.Enum:
		//			EditorGUI.LabelField(position, label, new GUIContent(property.enumDisplayNames[property.enumValueIndex]));
		//			break;
		//		case SerializedPropertyType.Float:
		//			EditorGUI.LabelField(position, label, new GUIContent(property.floatValue.ToString()));
		//			break;
		//		case SerializedPropertyType.Generic:
		//			break;
		//		case SerializedPropertyType.Gradient:
		//			break;
		//		case SerializedPropertyType.Integer:
		//			EditorGUI.LabelField(position, label, new GUIContent(property.intValue.ToString()));
		//			break;
		//		case SerializedPropertyType.LayerMask:
		//			break;
		//		case SerializedPropertyType.ObjectReference:
		//			break;
		//		case SerializedPropertyType.Quaternion:
		//			break;
		//		case SerializedPropertyType.Rect:
		//			break;
		//		case SerializedPropertyType.String:
		//			EditorGUI.LabelField(position, label, new GUIContent(property.stringValue));
		//			break;
		//		case SerializedPropertyType.Vector2:
		//			break;
		//		case SerializedPropertyType.Vector3:
		//			break;
		//		case SerializedPropertyType.Vector4:
		//			break;
		//	}
		//}

		public override float GetPropertyHeight(SerializedProperty property,
										GUIContent label) {
			return EditorGUI.GetPropertyHeight(property, label, true);
			//return EditorGUI.GetPropertyHeight(SerializedPropertyType.)
		}

		public override void OnGUI(Rect position,
								   SerializedProperty property,
								   GUIContent label) {

			GUI.enabled = false;
			EditorGUI.PropertyField(position, property, label, true);
			GUI.enabled = true;
		}

	}
#endif
}