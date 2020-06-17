﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools
{
    public struct Config
    {
        [JsonProperty("tasks")] public BindTask[] Tasks { get; set; }
    }

    public struct BindTask
    {
        // TODO the dishwasher
        [JsonProperty("sources")] public string[] Sources { get; set; }
        [JsonProperty("destination")] public string OutputFolder { get; set; }
        [JsonProperty("mode")] public ConverterMode Mode { get; set; }
        [JsonProperty("cacheKey")] public string CacheKey { get; set; }
        [JsonProperty("controlDescriptors")] public string[] Controls { get; set; } 
        [JsonProperty("clang")] public ClangTaskOptions ClangOpts { get; set; }
        [JsonProperty("namespace")] public string Namespace { get; set; }
        [JsonProperty("extensionsNamespace")] public string ExtensionsNamespace { get; set; }
        [JsonProperty("outputMode")] public OutputMode OutputMode { get; set; }
        [JsonProperty("legacyNameContainer")] public NameContainer NameContainer { get; set; }
        [JsonProperty("typeMaps")] public List<Dictionary<string, string>> TypeMaps { get; set; }
    }

    public struct ClangTaskOptions
    {
        [JsonProperty("args")]
        public string[] ClangArgs { get; set; }
        [JsonProperty("projects")]
        public Dictionary<string, string> ProjectMappings { get; set; }
    }

    public struct BakeryOptions
    {
    }

    public enum ConverterMode
    {
        ConvertConstruct,
        ConvertConstructBake,
        ClangBake,
        Clang
    }

    public enum OutputMode
    {
        Default = 1, // fnptrs, for now just use super invoke
        Legacy = 1 // super invoke
    }
}