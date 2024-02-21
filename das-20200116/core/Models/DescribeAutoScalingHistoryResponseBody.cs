// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingHistoryResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The history of auto scaling.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutoScalingHistoryResponseBodyData Data { get; set; }
        public class DescribeAutoScalingHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// The history of automatic bandwidth scaling of ApsaraDB for Redis instances. This feature is not supported.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Bandwidth { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The history of resource scale-out of ApsaraDB for Redis instances. This feature is not supported.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Resource { get; set; }

            /// <summary>
            /// The history of automatic shard scale-out of ApsaraDB for Redis instances. This feature is not supported.
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Shard { get; set; }

            /// <summary>
            /// The history of automatic performance scaling.
            /// </summary>
            [NameInMap("SpecHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoScalingHistoryResponseBodyDataSpecHistory> SpecHistory { get; set; }
            public class DescribeAutoScalingHistoryResponseBodyDataSpecHistory : TeaModel {
                /// <summary>
                /// The error code returned by the scaling task. Valid values:
                /// 
                /// *   **Insufficient_Balance**: The account has insufficient balance or an unpaid order.
                /// *   **REACH_SPEC_UPPERBOUND**: The instance type reaches the upper limit.
                /// *   **Control_Error_Timeout_Msg**: The management task timed out.
                /// *   **Invoke_Rds_Api_Error_Msg**: Failed to call the ApsaraDB RDS API.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The original number of CPU cores of the instance.
                /// </summary>
                [NameInMap("OriginCore")]
                [Validation(Required=false)]
                public int? OriginCore { get; set; }

                /// <summary>
                /// The original instance type.
                /// </summary>
                [NameInMap("OriginInstanceClass")]
                [Validation(Required=false)]
                public string OriginInstanceClass { get; set; }

                /// <summary>
                /// The original memory size of the instance. Unit: GB.
                /// </summary>
                [NameInMap("OriginMemory")]
                [Validation(Required=false)]
                public double? OriginMemory { get; set; }

                /// <summary>
                /// The type of the automatic performance scaling task. Valid values:
                /// 
                /// *   **SCALE_UP**: automatic instance type scale-up task.
                /// *   **SCALE_DOWN**: automatic instance type scale-down task.
                /// </summary>
                [NameInMap("ScaleType")]
                [Validation(Required=false)]
                public string ScaleType { get; set; }

                /// <summary>
                /// The destination number of CPU cores of the instance.
                /// </summary>
                [NameInMap("TargetCore")]
                [Validation(Required=false)]
                public int? TargetCore { get; set; }

                /// <summary>
                /// The destination instance type.
                /// </summary>
                [NameInMap("TargetInstanceClass")]
                [Validation(Required=false)]
                public string TargetInstanceClass { get; set; }

                /// <summary>
                /// The destination memory size of the instance. Unit: GB.
                /// </summary>
                [NameInMap("TargetMemory")]
                [Validation(Required=false)]
                public double? TargetMemory { get; set; }

                /// <summary>
                /// The status of the task. Valid values:
                /// 
                /// *   **true**: The task was successful.
                /// *   **false**: The task failed.
                /// </summary>
                [NameInMap("TaskExcuteStatus")]
                [Validation(Required=false)]
                public bool? TaskExcuteStatus { get; set; }

                /// <summary>
                /// The time when the task was run. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("TaskTime")]
                [Validation(Required=false)]
                public long? TaskTime { get; set; }

            }

            /// <summary>
            /// The history of storage expansion. This feature is not supported.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Storage { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// > If the request was successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
