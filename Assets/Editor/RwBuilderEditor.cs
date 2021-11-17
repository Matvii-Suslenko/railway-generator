using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RailwayBuilder))]
public class RwBuilderEditor : Editor
{
    [System.Obsolete]
    public override void OnInspectorGUI()
    {
        RailwayBuilder myRwBuilder = (RailwayBuilder)target;

        EditorGUILayout.LabelField("Bezier path");
        myRwBuilder.path = (BezierPath)EditorGUILayout.ObjectField(myRwBuilder.path, typeof(BezierPath));

        EditorTools.DrawUILine(Color.grey);

        EditorGUILayout.LabelField("Sleeper mesh");
        myRwBuilder.sleeperMesh = (Mesh)EditorGUILayout.ObjectField(myRwBuilder.sleeperMesh, typeof(Mesh));

        EditorGUILayout.LabelField("Step between sleepers");
        myRwBuilder.sleeperStep = EditorGUILayout.Slider(myRwBuilder.sleeperStep, 1.1f, 10f);

        EditorTools.DrawUILine(Color.grey);

        EditorGUILayout.LabelField("Material");
        myRwBuilder.material = (Material)EditorGUILayout.ObjectField(myRwBuilder.material, typeof(Material));

        EditorTools.DrawUILine(Color.grey);

        EditorGUILayout.LabelField("Rail profile");
        myRwBuilder.railProfile = (RailProfile)EditorGUILayout.ObjectField(myRwBuilder.railProfile, typeof(RailProfile));

        EditorGUILayout.LabelField("Step between rails");
        myRwBuilder.railStep = EditorGUILayout.Slider(myRwBuilder.railStep, 0.5f, 5f);

        EditorGUILayout.LabelField("Rail vertical position");
        myRwBuilder.railVerticalPosition = EditorGUILayout.Slider(myRwBuilder.railVerticalPosition, 0f, 1f);

        EditorGUILayout.LabelField("Distance between rails");
        myRwBuilder.distanceBetweenRails = EditorGUILayout.Slider(myRwBuilder.distanceBetweenRails, 0.1f, 3f);

        if (GUILayout.Button("Generate railway mesh"))
        {
            myRwBuilder.GenerateMesh();
        }
    }
}
