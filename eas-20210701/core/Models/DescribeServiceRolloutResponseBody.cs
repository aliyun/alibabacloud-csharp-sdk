// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. A unique identifier returned with each request, used for troubleshooting and tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rollout strategy information. Contains the strategy configuration (Strategy) and execution status (Status).</para>
        /// </summary>
        [NameInMap("Rollout")]
        [Validation(Required=false)]
        public DescribeServiceRolloutResponseBodyRollout Rollout { get; set; }
        public class DescribeServiceRolloutResponseBodyRollout : TeaModel {
            /// <summary>
            /// <para>The rollout execution status. Contains the current rollout progress and phase information.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStatus Status { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStatus : TeaModel {
                /// <summary>
                /// <para>The current revision. The identifier of the version that is currently running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-abc123-v1</para>
                /// </summary>
                [NameInMap("CurrentRevision")]
                [Validation(Required=false)]
                public string CurrentRevision { get; set; }

                /// <summary>
                /// <para>The time when the next batch starts updating, in the format of YYYY/MM/DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026/05/08 16:10:56</para>
                /// </summary>
                [NameInMap("NextBatchStartTime")]
                [Validation(Required=false)]
                public string NextBatchStartTime { get; set; }

                /// <summary>
                /// <para>The rollout phase. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: Waiting to start the rollout.</description></item>
                /// <item><description>Running: The rollout is in progress.</description></item>
                /// <item><description>Paused: The rollout is paused.</description></item>
                /// <item><description>Completed: The rollout is completed.</description></item>
                /// <item><description>Failed: The rollout failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The total number of replicas for the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalReplicas")]
                [Validation(Required=false)]
                public int? TotalReplicas { get; set; }

                /// <summary>
                /// <para>The update revision. The identifier of the target version to which the service is being updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-abc123-v2</para>
                /// </summary>
                [NameInMap("UpdateRevision")]
                [Validation(Required=false)]
                public string UpdateRevision { get; set; }

                /// <summary>
                /// <para>The number of replicas that have been updated to the new version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("UpdatedReplicas")]
                [Validation(Required=false)]
                public int? UpdatedReplicas { get; set; }

            }

            /// <summary>
            /// <para>The rollout strategy configuration. Contains the specific configuration parameters for partition-based or batch-based rollout.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStrategy Strategy { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStrategy : TeaModel {
                /// <summary>
                /// <para>The batch rollout configuration. This field is returned only if a batch-based rollout strategy is used.</para>
                /// </summary>
                [NameInMap("Batch")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyBatch Batch { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyBatch : TeaModel {
                    /// <summary>
                    /// <para>The batch size. The number or percentage of replicas to update in each batch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BatchSize")]
                    [Validation(Required=false)]
                    public string BatchSize { get; set; }

                    /// <summary>
                    /// <para>The batch interval. The wait time between two consecutive rollout batches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5m</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                }

                /// <summary>
                /// <para>The partition rollout configuration. This field is returned only if a partition-based rollout strategy is used.</para>
                /// </summary>
                [NameInMap("Partition")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyPartition Partition { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyPartition : TeaModel {
                    /// <summary>
                    /// <para>The partition value. Specifies the number or percentage of old replicas to retain. For example, \&quot;50%\&quot; indicates that 50% of the old replicas are retained.</para>
                    /// 
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
