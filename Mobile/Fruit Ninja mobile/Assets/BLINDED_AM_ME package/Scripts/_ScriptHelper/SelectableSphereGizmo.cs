﻿
//    MIT License
//    
//    Copyright (c) 2017 Dustin Whirle
//    
//    My Youtube stuff: https://www.youtube.com/playlist?list=PL-sp8pM7xzbVls1NovXqwgfBQiwhTA_Ya
//    
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//    
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//    
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace BLINDED_AM_ME._ScriptHelper{

	public class SelectableSphereGizmo : MonoBehaviour {

		#if UNITY_EDITOR

		public float radius = 0.25f;
		public Color notSelectedColor = Color.green;
		public Color selectedColor = Color.cyan;

		private void OnDrawGizmos(){
			Drawing(false);
		}

		private void OnDrawGizmosSelected(){
			Drawing(true);
		}

		private void Drawing(bool isSelected){

			if(isSelected)
				Gizmos.color = selectedColor;
			else
				Gizmos.color = notSelectedColor;

			Gizmos.DrawSphere(transform.position,radius);
		}

		#endif
	}
}