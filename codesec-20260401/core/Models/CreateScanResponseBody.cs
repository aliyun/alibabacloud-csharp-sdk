// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateScanResponseBody : TeaModel {
        /// <summary>
        /// <para>The code package ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("codeBundleId")]
        [Validation(Required=false)]
        public long? CodeBundleId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The user ID of the task creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3221</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The supported types.</para>
        /// </summary>
        [NameInMap("engineSnapshot")]
        [Validation(Required=false)]
        public CreateScanResponseBodyEngineSnapshot EngineSnapshot { get; set; }
        public class CreateScanResponseBodyEngineSnapshot : TeaModel {
            /// <summary>
            /// <para>Indicates whether SAST is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <para>Indicates whether SCA is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

        }

        /// <summary>
        /// <para>The scan end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>full: full data</description></item>
        /// <item><description>incremental: incremental</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scan information.</para>
        /// </summary>
        [NameInMap("scanMetrics")]
        [Validation(Required=false)]
        public CreateScanResponseBodyScanMetrics ScanMetrics { get; set; }
        public class CreateScanResponseBodyScanMetrics : TeaModel {
            /// <summary>
            /// <para>The number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("fileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <para>The number of lines of code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("linesOfCode")]
            [Validation(Required=false)]
            public long? LinesOfCode { get; set; }

            /// <summary>
            /// <para>Deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("tokenTotal")]
            [Validation(Required=false)]
            public long? TokenTotal { get; set; }

        }

        /// <summary>
        /// <para>The task progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("scanProgress")]
        [Validation(Required=false)]
        public long? ScanProgress { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: Running.</description></item>
        /// <item><description>completed: Completed.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// <item><description>canceling: Being canceled.</description></item>
        /// <item><description>canceled: Canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("workerId")]
        [Validation(Required=false)]
        public string WorkerId { get; set; }

    }

}
