﻿/*
 *
 * Match.cs
 *
 * Copyright 2019 Yuichi Yoshii
 *     吉井雄一 @ 吉井産業  you.65535.kir@gmail.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using System.Collections.Generic;

public class Match {

    public string Tag { get; set; }

    public IList<string> Hit { get; }

    public int Start { get; set; }

    public string Path { get; set; }

    public string Pattern { get; set; }

    public bool Started => -1 < Start;

    public Match() {
        Hit = new List<string>();
        Start = -1;
    }

    public void Add(string arg) {
        Hit.Add(arg);
    }

    public void Init() {
        Hit.Clear();
        Start = -1;
    }

    public string OneLine() {
        string ret = @"";
        foreach (string l in Hit) {
            ret += l;
        }
        return ret;
    }
}