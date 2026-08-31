// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScansResponseBody : TeaModel {
        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeScansResponseBodyItems> Items { get; set; }
        public class DescribeScansResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The code bundle ID.</para>
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
            /// <para>The user ID of the task creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The scan phase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>threat_model: Threat modeling.</description></item>
            /// <item><description>discovery: Vulnerability discovery.</description></item>
            /// <item><description>panel: Vulnerability review.</description></item>
            /// <item><description>adversarial: Adversarial verification.</description></item>
            /// <item><description>finalize: Report generation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finalize</para>
            /// </summary>
            [NameInMap("currentPhase")]
            [Validation(Required=false)]
            public string CurrentPhase { get; set; }

            /// <summary>
            /// <para>The supported scan types.</para>
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
            /// <para>The time when the scan finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
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
            /// <item><description>full: Full scan.</description></item>
            /// <item><description>incremental: Incremental scan.</description></item>
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
            /// <para>p-n72k9yrkq81ny7z</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The scan result statistics information.</para>
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
                /// <para>Deprecated.</para>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: Running.</description></item>
            /// <item><description>completed: Completed.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// <item><description>canceling: Being canceled. </description></item>
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
            /// <para>1648622222394847-ha-cn-lm64p7tby01_dsl_kb_video_1773817008236_full</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
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

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. An empty value indicates the last page.</para>
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
