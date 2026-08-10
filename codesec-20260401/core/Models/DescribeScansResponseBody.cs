// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScansResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeScansResponseBodyItems> Items { get; set; }
        public class DescribeScansResponseBodyItems : TeaModel {
            [NameInMap("codeBundleId")]
            [Validation(Required=false)]
            public long? CodeBundleId { get; set; }

            /// <summary>
            /// <para>扫描任务创建时间（RFC3339）</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("engineSnapshot")]
            [Validation(Required=false)]
            public DescribeScansResponseBodyItemsEngineSnapshot EngineSnapshot { get; set; }
            public class DescribeScansResponseBodyItemsEngineSnapshot : TeaModel {
                [NameInMap("sast")]
                [Validation(Required=false)]
                public bool? Sast { get; set; }

                [NameInMap("sca")]
                [Validation(Required=false)]
                public bool? Sca { get; set; }

            }

            /// <summary>
            /// <para>扫描结束时间（RFC3339）</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("scanMetrics")]
            [Validation(Required=false)]
            public DescribeScansResponseBodyItemsScanMetrics ScanMetrics { get; set; }
            public class DescribeScansResponseBodyItemsScanMetrics : TeaModel {
                [NameInMap("credit")]
                [Validation(Required=false)]
                public float? Credit { get; set; }

                [NameInMap("fileCount")]
                [Validation(Required=false)]
                public long? FileCount { get; set; }

                [NameInMap("linesOfCode")]
                [Validation(Required=false)]
                public long? LinesOfCode { get; set; }

                [NameInMap("tokenTotal")]
                [Validation(Required=false)]
                public long? TokenTotal { get; set; }

            }

            [NameInMap("scanProgress")]
            [Validation(Required=false)]
            public long? ScanProgress { get; set; }

            /// <summary>
            /// <para>扫描开始时间（RFC3339）</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>扫描任务更新时间（RFC3339）</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("workerId")]
            [Validation(Required=false)]
            public string WorkerId { get; set; }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
