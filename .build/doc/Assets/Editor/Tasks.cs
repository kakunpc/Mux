﻿// Copyright 2019 pixiv Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEditor;

public static class Tasks
{
    private static void Build(string destination, params string[] levels)
    {
        BuildPipeline.BuildPlayer(levels, destination, BuildTarget.WebGL, BuildOptions.StrictMode);
    }

    public static void BuildGallery()
    {
        Build("obj/gallery", "Assets/Mux.Playground/Gallery/Gallery.unity");
    }

    public static void BuildPlayground()
    {
        Build("obj/playground", "Assets/Mux.Playground/Playground/Playground.unity");
    }
}
