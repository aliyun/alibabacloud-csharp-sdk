// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListDisasterRecoveryCheckpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListDisasterRecoveryCheckpointsResponseBodyData Data { get; set; }
        public class ListDisasterRecoveryCheckpointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The paginated data.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListDisasterRecoveryCheckpointsResponseBodyDataList> List { get; set; }
            public class ListDisasterRecoveryCheckpointsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The consumer offset checkpoint ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000xx</para>
                /// </summary>
                [NameInMap("checkpointId")]
                [Validation(Required=false)]
                public long? CheckpointId { get; set; }

                /// <summary>
                /// <para>The ID of the backup mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000xx</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                /// <summary>
                /// <para>The most recent synchronization time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1740724080343</para>
                /// </summary>
                [NameInMap("lastSyncTime")]
                [Validation(Required=false)]
                public long? LastSyncTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13000000xx</para>
                /// </summary>
                [NameInMap("planId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// <para>The source consumer offset.</para>
                /// </summary>
                [NameInMap("sourceProgress")]
                [Validation(Required=false)]
                public ListDisasterRecoveryCheckpointsResponseBodyDataListSourceProgress SourceProgress { get; set; }
                public class ListDisasterRecoveryCheckpointsResponseBodyDataListSourceProgress : TeaModel {
                    /// <summary>
                    /// <para>The consumer group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_TEST</para>
                    /// </summary>
                    [NameInMap("consumerGroupId")]
                    [Validation(Required=false)]
                    public string ConsumerGroupId { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-3mp3vblzxxx</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance.</description></item>
                    /// <item><description>EXTERNAL_ROCKETMQ: external instance, open source instance, or open source cluster.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIYUN_ROCKETMQ</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The most recent fetch time. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1740724080343</para>
                    /// </summary>
                    [NameInMap("lastFetchTime")]
                    [Validation(Required=false)]
                    public long? LastFetchTime { get; set; }

                    /// <summary>
                    /// <para>The consumer offset data.</para>
                    /// </summary>
                    [NameInMap("progressData")]
                    [Validation(Required=false)]
                    public ListDisasterRecoveryCheckpointsResponseBodyDataListSourceProgressProgressData ProgressData { get; set; }
                    public class ListDisasterRecoveryCheckpointsResponseBodyDataListSourceProgressProgressData : TeaModel {
                        /// <summary>
                        /// <para>The latest consumption time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1740724080343</para>
                        /// </summary>
                        [NameInMap("consumeTimestamp")]
                        [Validation(Required=false)]
                        public long? ConsumeTimestamp { get; set; }

                    }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TOPIC_TEST</para>
                    /// </summary>
                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                /// <summary>
                /// <para>The target consumer offset.</para>
                /// </summary>
                [NameInMap("targetProgress")]
                [Validation(Required=false)]
                public ListDisasterRecoveryCheckpointsResponseBodyDataListTargetProgress TargetProgress { get; set; }
                public class ListDisasterRecoveryCheckpointsResponseBodyDataListTargetProgress : TeaModel {
                    /// <summary>
                    /// <para>The consumer group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_TEST</para>
                    /// </summary>
                    [NameInMap("consumerGroupId")]
                    [Validation(Required=false)]
                    public string ConsumerGroupId { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-nwy3i065xxx</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance.</description></item>
                    /// <item><description>EXTERNAL_ROCKETMQ: external instance, open source instance, or open source cluster.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIYUN_ROCKETMQ</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The latest fetch time. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1740724080343</para>
                    /// </summary>
                    [NameInMap("lastFetchTime")]
                    [Validation(Required=false)]
                    public long? LastFetchTime { get; set; }

                    /// <summary>
                    /// <para>The consumer offset data.</para>
                    /// </summary>
                    [NameInMap("progressData")]
                    [Validation(Required=false)]
                    public ListDisasterRecoveryCheckpointsResponseBodyDataListTargetProgressProgressData ProgressData { get; set; }
                    public class ListDisasterRecoveryCheckpointsResponseBodyDataListTargetProgressProgressData : TeaModel {
                        /// <summary>
                        /// <para>The latest consumption time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1740724080343</para>
                        /// </summary>
                        [NameInMap("consumeTimestamp")]
                        [Validation(Required=false)]
                        public long? ConsumeTimestamp { get; set; }

                    }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TOPIC_TEST</para>
                    /// </summary>
                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF9A8B10-C426-530F-A0DD-96320B39****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
