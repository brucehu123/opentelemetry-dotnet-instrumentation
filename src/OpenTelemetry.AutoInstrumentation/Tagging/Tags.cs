// <copyright file="Tags.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
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
// </copyright>

using System.Diagnostics;

namespace OpenTelemetry.AutoInstrumentation.Tagging;

/// <summary>
/// Standard span tags used by integrations.
/// </summary>
public static class Tags
{
    /// <summary>
    /// The environment of the profiled service.
    /// </summary>
    public const string Env = "env";

    /// <summary>
    /// The version of the profiled service.
    /// </summary>
    public const string Version = "version";

    /// <summary>
    /// Language tag, applied to root spans that are .NET runtime (e.g., ASP.NET)
    /// </summary>
    public const string Language = "language";

    /// <summary>
    /// The name of the integration that generated the span.
    /// Use OpenTracing tag "component"
    /// </summary>
    public const string InstrumentationName = "component";

    /// <summary>
    /// The span.Resource for span encoding without applicable field.
    /// </summary>
    public const string ResourceName = "resource.name";

    /// <summary>
    /// The kind of span (e.g. client, server).
    /// </summary>
    /// <seealso cref="Activity.Kind"/>
    public const string SpanKind = "span.kind";

    /// <summary>
    /// The error message of an exception
    /// </summary>
    public const string ErrorMsg = "error.msg";

    /// <summary>
    /// The type of an exception
    /// </summary>
    public const string ErrorType = "error.type";

    /// <summary>
    /// The stack trace of an exception
    /// </summary>
    public const string ErrorStack = "error.stack";

    /// <summary>
    /// The status of a span
    /// </summary>
    public const string Status = "status";

    /// <summary>
    /// The hostname of a outgoing server connection.
    /// </summary>
    public const string OutHost = "out.host";

    /// <summary>
    /// The port of a outgoing server connection.
    /// </summary>
    public const string OutPort = "out.port";

    /// <summary>
    /// GraphQL specific tags
    /// </summary>
    public static class GraphQL
    {
        /// <summary>
        /// The operation name of the GraphQL request.
        /// </summary>
        public const string OperationName = "graphql.operation.name";

        /// <summary>
        /// The operation type of the GraphQL request.
        /// </summary>
        public const string OperationType = "graphql.operation.type";

        /// <summary>
        /// The source defining the GraphQL request.
        /// </summary>
        public const string Source = "graphql.source";
    }
}
