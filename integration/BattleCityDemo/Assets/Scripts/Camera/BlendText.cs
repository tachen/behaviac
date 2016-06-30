/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class BlendText : MonoBehaviour
{
    public string[] helptext;
    //public Coordinator coordinator;

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        for (int i = 0; i < helptext.Length; i++)
            GUILayout.Label(helptext[i], style);

//        GUILayout.Label("Sitting: " + coordinator.sWeight.Value, style);
//        GUILayout.Label("Gesture: " + coordinator.aWeight.Value, style);
//        GUILayout.Label("HeadLook: " + coordinator.hWeight.Value, style);
//        GUILayout.Label("Reaching: " + coordinator.rWeight.Value, style);
//        GUILayout.Label("Ragdoll: " + coordinator.dWeight.Value, style);
    }
}