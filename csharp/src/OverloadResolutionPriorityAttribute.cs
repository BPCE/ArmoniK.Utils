// This file is part of the ArmoniK project
// 
// Copyright (C) ANEO, 2022-2026. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License")
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

#if !NET9_0_OR_GREATER

using System.ComponentModel;

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

/// <summary>
///   Specifies the priority of a member in overload resolution (C# 13 and later).
///   Only recognized by the compiler: it is declared here as it is missing before .NET 9.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property,
                Inherited = false)]
internal sealed class OverloadResolutionPriorityAttribute : Attribute
{
  /// <summary>
  ///   Initializes a new instance of the attribute
  /// </summary>
  /// <param name="priority">Priority of the member: higher numbers are prioritized</param>
  public OverloadResolutionPriorityAttribute(int priority)
    => Priority = priority;

  /// <summary>
  ///   Priority of the member: higher numbers are prioritized
  /// </summary>
  public int Priority { get; }
}

#endif
