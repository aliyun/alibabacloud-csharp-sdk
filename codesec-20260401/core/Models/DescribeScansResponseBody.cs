// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScansResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeScansResponseBodyItems> Items { get; set; }
        public class DescribeScansResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("codeBundleId")]
            [Validation(Required=false)]
            public long? CodeBundleId { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The current scan phase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>threat_model: threat modeling</description></item>
            /// <item><description>discovery: vulnerability discovery</description></item>
            /// <item><description>panel: vulnerability review</description></item>
            /// <item><description>adversarial: adversarial verification</description></item>
            /// <item><description>finalize: report compilation</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finalize</para>
            /// </summary>
            [NameInMap("currentPhase")]
            [Validation(Required=false)]
            public string CurrentPhase { get; set; }

            /// <summary>
            /// <para>The supported types.</para>
            /// </summary>
            [NameInMap("engineSnapshot")]
            [Validation(Required=false)]
            public DescribeScansResponseBodyItemsEngineSnapshot EngineSnapshot { get; set; }
            public class DescribeScansResponseBodyItemsEngineSnapshot : TeaModel {
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
            /// <para>The time when the scan ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>934</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The scan type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>full: full scan</description></item>
            /// <item><description>incremental: incremental scan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The ID of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-n72k9yrkq81ny7z</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The statistics information of the scan results.</para>
            /// </summary>
            [NameInMap("scanMetrics")]
            [Validation(Required=false)]
            public DescribeScansResponseBodyItemsScanMetrics ScanMetrics { get; set; }
            public class DescribeScansResponseBodyItemsScanMetrics : TeaModel {
                /// <summary>
                /// <para>The number of credits consumed by the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.25</para>
                /// </summary>
                [NameInMap("credit")]
                [Validation(Required=false)]
                public float? Credit { get; set; }

                /// <summary>
                /// <para>The number of files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>459</para>
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
                /// <para><b>[Deprecated]</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("tokenTotal")]
                [Validation(Required=false)]
                public long? TokenTotal { get; set; }

            }

            /// <summary>
            /// <para>The progress of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("scanProgress")]
            [Validation(Required=false)]
            public long? ScanProgress { get; set; }

            /// <summary>
            /// <para>The time when the task started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: The task is running.</description></item>
            /// <item><description>completed: The task is completed.</description></item>
            /// <item><description>failed: The task failed.</description></item>
            /// <item><description>canceling: The task is being canceled. </description></item>
            /// <item><description>canceled: The task is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648622222394847-ha-cn-lm64p7tby01_dsl_kb_video_1773817008236_full</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The time when the task was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("workerId")]
            [Validation(Required=false)]
            public string WorkerId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. An empty value indicates that the last page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0IjoiMjAyNi0wNy0xNlQwNzo1MzozOC4wMjFaIiwiaSI6MTAwMDQ0OH0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
