// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateScanResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("codeBundleId")]
        [Validation(Required=false)]
        public long? CodeBundleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3221</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("engineSnapshot")]
        [Validation(Required=false)]
        public CreateScanResponseBodyEngineSnapshot EngineSnapshot { get; set; }
        public class CreateScanResponseBodyEngineSnapshot : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scanMetrics")]
        [Validation(Required=false)]
        public CreateScanResponseBodyScanMetrics ScanMetrics { get; set; }
        public class CreateScanResponseBodyScanMetrics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("fileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("linesOfCode")]
            [Validation(Required=false)]
            public long? LinesOfCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("tokenTotal")]
            [Validation(Required=false)]
            public long? TokenTotal { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("scanProgress")]
        [Validation(Required=false)]
        public long? ScanProgress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("workerId")]
        [Validation(Required=false)]
        public string WorkerId { get; set; }

    }

}
