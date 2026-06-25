// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. This ID is unique to each request and is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the service rollout, including the rollout strategy (<c>Strategy</c>) and execution status (<c>Status</c>).</para>
        /// </summary>
        [NameInMap("Rollout")]
        [Validation(Required=false)]
        public DescribeServiceRolloutResponseBodyRollout Rollout { get; set; }
        public class DescribeServiceRolloutResponseBodyRollout : TeaModel {
            /// <summary>
            /// <para>The current progress and phase of the rollout.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStatus Status { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStatus : TeaModel {
                /// <summary>
                /// <para>The identifier for the currently running revision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-abc123-v1</para>
                /// </summary>
                [NameInMap("CurrentRevision")]
                [Validation(Required=false)]
                public string CurrentRevision { get; set; }

                /// <summary>
                /// <para>The scheduled start time for the next batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026/05/08 16:10:56</para>
                /// </summary>
                [NameInMap("NextBatchStartTime")]
                [Validation(Required=false)]
                public string NextBatchStartTime { get; set; }

                /// <summary>
                /// <para>The current release phase. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Pending</c>: The rollout is waiting to start.</para>
                /// </description></item>
                /// <item><description><para><c>Running</c>: The rollout is in progress.</para>
                /// </description></item>
                /// <item><description><para><c>Paused</c>: The rollout is paused.</para>
                /// </description></item>
                /// <item><description><para><c>Completed</c>: The rollout is complete.</para>
                /// </description></item>
                /// <item><description><para><c>Failed</c>: The rollout has failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The total number of desired replicas for the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalReplicas")]
                [Validation(Required=false)]
                public int? TotalReplicas { get; set; }

                /// <summary>
                /// <para>The identifier for the target revision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-abc123-v2</para>
                /// </summary>
                [NameInMap("UpdateRevision")]
                [Validation(Required=false)]
                public string UpdateRevision { get; set; }

                /// <summary>
                /// <para>The number of replicas updated to the new revision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("UpdatedReplicas")]
                [Validation(Required=false)]
                public int? UpdatedReplicas { get; set; }

            }

            /// <summary>
            /// <para>The rollout strategy configuration. This object contains the parameters for a canary release or batch release.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeServiceRolloutResponseBodyRolloutStrategy Strategy { get; set; }
            public class DescribeServiceRolloutResponseBodyRolloutStrategy : TeaModel {
                /// <summary>
                /// <para>The configuration for a batch release. This object is returned only when the batch release strategy is used.</para>
                /// </summary>
                [NameInMap("Batch")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyBatch Batch { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyBatch : TeaModel {
                    /// <summary>
                    /// <para>The number or percentage of replicas to update in each batch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BatchSize")]
                    [Validation(Required=false)]
                    public string BatchSize { get; set; }

                    /// <summary>
                    /// <para>The time to wait between batches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5m</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                }

                /// <summary>
                /// <para>The configuration for a canary release. This object is returned only when the canary release strategy is used.</para>
                /// </summary>
                [NameInMap("Partition")]
                [Validation(Required=false)]
                public DescribeServiceRolloutResponseBodyRolloutStrategyPartition Partition { get; set; }
                public class DescribeServiceRolloutResponseBodyRolloutStrategyPartition : TeaModel {
                    /// <summary>
                    /// <para>Specifies the number or percentage of old replicas to keep. For example, a value of <c>50%</c> indicates that 50% of the old replicas are retained.</para>
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
