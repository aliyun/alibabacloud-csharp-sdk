// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rollout")]
        [Validation(Required=false)]
        public DescribeServiceRolloutResponseBodyRollout Rollout { get; set; }
        public class DescribeServiceRolloutResponseBodyRollout : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStatus Status { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>service-abc123-v1</para>
                /// </summary>
                [NameInMap("CurrentRevision")]
                [Validation(Required=false)]
                public string CurrentRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026/05/08 16:10:56</para>
                /// </summary>
                [NameInMap("NextBatchStartTime")]
                [Validation(Required=false)]
                public string NextBatchStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalReplicas")]
                [Validation(Required=false)]
                public int? TotalReplicas { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>service-abc123-v2</para>
                /// </summary>
                [NameInMap("UpdateRevision")]
                [Validation(Required=false)]
                public string UpdateRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("UpdatedReplicas")]
                [Validation(Required=false)]
                public int? UpdatedReplicas { get; set; }

            }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStrategy Strategy { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStrategy : TeaModel {
                [NameInMap("Batch")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyBatch Batch { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyBatch : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BatchSize")]
                    [Validation(Required=false)]
                    public string BatchSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5m</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                }

                [NameInMap("Partition")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyPartition Partition { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyPartition : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50%</para>
                    /// </summary>
                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                }

            }

        }

    }

}
