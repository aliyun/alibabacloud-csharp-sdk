// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DiagnosisIssue : TeaModel {
        /// <summary>
        /// <para>A unique code that identifies the issue type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RepoNumOverLimit</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>An object that contains additional, unstructured key-value information about the issue.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <para>The time, in ISO 8601 format, when the issue was first detected.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("FirstOccurrence")]
        [Validation(Required=false)]
        public string FirstOccurrence { get; set; }

        /// <summary>
        /// <para>The time, in ISO 8601 format, when the issue was last detected.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:30:00+08:00</para>
        /// </summary>
        [NameInMap("LastOccurrence")]
        [Validation(Required=false)]
        public string LastOccurrence { get; set; }

        /// <summary>
        /// <para>Specifies the severity of the issue. Valid values are <c>INFO</c>, <c>WARN</c>, and <c>ERROR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The total number of times the issue has occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OccurrenceCount")]
        [Validation(Required=false)]
        public long? OccurrenceCount { get; set; }

        /// <summary>
        /// <para>The recommended action to resolve the issue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Buy repository quota</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

    }

}
