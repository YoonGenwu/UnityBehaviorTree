﻿using System;
using System.Collections.Generic;

public class Repeater : LeafDecorator
{
	private int _count, _target;

	public Repeater() : this (-1)
	{
	}

	public Repeater(int target)
	{
		_target = target;
		_count = 0;
	}

	public override Result Process(Dictionary<String, Object> datastore)
	{
		if(_target == -1 || _count < _target)
		{
			Result result = _leaf.Process(datastore);
			if(result != Result.RUNNING) _count++;
		}

		if(_count == _target) return Result.SUCCESS;
		else return Result.RUNNING;
	}
}
