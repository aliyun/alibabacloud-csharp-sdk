// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScanResponseBody : TeaModel {
        /// <summary>
        /// <para>The function code package ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("codeBundleId")]
        [Validation(Required=false)]
        public long? CodeBundleId { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
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
        /// <para>The scan phase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>threat_model: threat modeling.</description></item>
        /// <item><description>discovery: vulnerability discovery.</description></item>
        /// <item><description>panel: vulnerability review.</description></item>
        /// <item><description>adversarial: adversarial verification.</description></item>
        /// <item><description>finalize: report compilation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>discovery</para>
        /// </summary>
        [NameInMap("currentPhase")]
        [Validation(Required=false)]
        public string CurrentPhase { get; set; }

        /// <summary>
        /// <para>The supported engine types.</para>
        /// </summary>
        [NameInMap("engineSnapshot")]
        [Validation(Required=false)]
        public DescribeScanResponseBodyEngineSnapshot EngineSnapshot { get; set; }
        public class DescribeScanResponseBodyEngineSnapshot : TeaModel {
            /// <summary>
            /// <para>Indicates whether Static Application Security Testing (SAST) is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <para>Indicates whether Software Composition Analysis (SCA) is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

        }

        /// <summary>
        /// <para>The time when the scan finished.</para>
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
        /// <para>The scan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>full: full</description></item>
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
        /// <para>1111</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scan results.</para>
        /// </summary>
        [NameInMap("scanMetrics")]
        [Validation(Required=false)]
        public DescribeScanResponseBodyScanMetrics ScanMetrics { get; set; }
        public class DescribeScanResponseBodyScanMetrics : TeaModel {
            /// <summary>
            /// <para>The number of credits consumed by the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("credit")]
            [Validation(Required=false)]
            public float? Credit { get; set; }

            /// <summary>
            /// <para>The number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73894</para>
            /// </summary>
            [NameInMap("fileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <para>The number of lines of code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("linesOfCode")]
            [Validation(Required=false)]
            public long? LinesOfCode { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is no longer used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para><b>[Deprecated]</b> This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("securityCredits")]
        [Validation(Required=false)]
        public float? SecurityCredits { get; set; }

        /// <summary>
        /// <para>The time when the task started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: Running.</description></item>
        /// <item><description>completed: Completed.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// <item><description>canceling: Being canceled.</description></item>
        /// <item><description>canceled: Canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
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
        /// <para>The time when the task was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("workerId")]
        [Validation(Required=false)]
        public string WorkerId { get; set; }

    }

}
