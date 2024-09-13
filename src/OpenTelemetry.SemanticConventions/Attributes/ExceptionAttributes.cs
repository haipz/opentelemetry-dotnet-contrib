// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class ExceptionAttributes
{
    /// <summary>
    /// SHOULD be set to true if the exception event is recorded at a point where it is known that the exception is escaping the scope of the span
    /// </summary>
    /// <remarks>
    /// An exception is considered to have escaped (or left) the scope of a span,
    /// if that span is ended while the exception is still logically "in flight".
    /// This may be actually "in flight" in some languages (e.g. if the exception
    /// is passed to a Context manager's <c>__exit__</c> method in Python) but will
    /// usually be caught at the point of recording the exception in most languages.
    /// <p>
    /// It is usually not possible to determine at the point where an exception is thrown
    /// whether it will escape the scope of a span.
    /// However, it is trivial to know that an exception
    /// will escape, if one checks for an active exception just before ending the span,
    /// as done in the <a href="https://opentelemetry.io/docs/specs/semconv/exceptions/exceptions-spans/#recording-an-exception">example for recording span exceptions</a>.
    /// <p>
    /// It follows that an exception may still escape the scope of the span
    /// even if the <c>exception.escaped</c> attribute was not set or set to false,
    /// since the event might have been recorded at a time where it was not
    /// clear whether the exception will escape
    /// </remarks>
    public const string AttributeExceptionEscaped = "exception.escaped";

    /// <summary>
    /// The exception message
    /// </summary>
    public const string AttributeExceptionMessage = "exception.message";

    /// <summary>
    /// A stacktrace as a string in the natural representation for the language runtime. The representation is to be determined and documented by each language SIG
    /// </summary>
    public const string AttributeExceptionStacktrace = "exception.stacktrace";

    /// <summary>
    /// The type of the exception (its fully-qualified class name, if applicable). The dynamic type of the exception should be preferred over the static type in languages that support it
    /// </summary>
    public const string AttributeExceptionType = "exception.type";
}
