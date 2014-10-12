﻿using UnityEditor;
using UnityEngine;
using System;

public class Behavior
{
	private String _group;
	public String group { get { return _group; } }

	private String _name;
	public String name { get { return _name; } }

	/// <summary>
	/// Initializes a new instance of the <see cref="Behavior"/> class.
	/// </summary>
	/// <param name="scriptPath">Path of the script inside of the Assets/Scripts/Behaviors folder.</param>
	public Behavior(String scriptPath)
	{
		int lastSlash = scriptPath.LastIndexOf("/");

		if(lastSlash >= 0)
		{
			_group = scriptPath.Substring(0, lastSlash);
			_name = scriptPath.Substring(lastSlash + 1);
		}
		else
		{
			_group = "";
			_name = scriptPath;
		}

		Debug.Log("Path: " + scriptPath);
		Debug.Log("Group: " + _group);
		Debug.Log("Name: " + _name);
	}
}
