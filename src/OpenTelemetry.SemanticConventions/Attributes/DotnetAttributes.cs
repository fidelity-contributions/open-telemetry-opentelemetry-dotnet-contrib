// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class DotnetAttributes
{
    /// <summary>
    /// Name of the garbage collector managed heap generation.
    /// </summary>
    public const string AttributeDotnetGcHeapGeneration = "dotnet.gc.heap.generation";

    /// <summary>
    /// Name of the garbage collector managed heap generation.
    /// </summary>
    public static class DotnetGcHeapGenerationValues
    {
        /// <summary>
        /// Generation 0.
        /// </summary>
        public const string Gen0 = "gen0";

        /// <summary>
        /// Generation 1.
        /// </summary>
        public const string Gen1 = "gen1";

        /// <summary>
        /// Generation 2.
        /// </summary>
        public const string Gen2 = "gen2";

        /// <summary>
        /// Large Object Heap.
        /// </summary>
        public const string Loh = "loh";

        /// <summary>
        /// Pinned Object Heap.
        /// </summary>
        public const string Poh = "poh";
    }
}