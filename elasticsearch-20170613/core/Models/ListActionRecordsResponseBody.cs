// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListActionRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of instance change records.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListActionRecordsResponseBodyResult> Result { get; set; }
        public class ListActionRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the operation that triggered the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RestartInstance</para>
            /// </summary>
            [NameInMap("actionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            /// <summary>
            /// <para>The parameters used for the change.</para>
            /// </summary>
            [NameInMap("actionParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> ActionParams { get; set; }

            [NameInMap("actionResultAccessList")]
            [Validation(Required=false)]
            public List<string> ActionResultAccessList { get; set; }

            /// <summary>
            /// <para>The end time of the change. The value is a UNIX timestamp in milliseconds.</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the Elasticsearch instance that was changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif24adwc0082****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance information after the change, represented as a JSON string.</para>
            /// </summary>
            [NameInMap("metaNow")]
            [Validation(Required=false)]
            public string MetaNow { get; set; }

            /// <summary>
            /// <para>The instance information before the change, represented as a JSON string.</para>
            /// </summary>
            [NameInMap("metaOld")]
            [Validation(Required=false)]
            public string MetaOld { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the account that triggered the change belongs.</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The progress of the change, represented as a percentage string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The field differences before and after the change.</para>
            /// </summary>
            [NameInMap("recordDiff")]
            [Validation(Required=false)]
            public Dictionary<string, object> RecordDiff { get; set; }

            [NameInMap("recordIds")]
            [Validation(Required=false)]
            public List<string> RecordIds { get; set; }

            /// <summary>
            /// <para>The ID of the request that triggered the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request-123</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The start time of the change. The value is a UNIX timestamp in milliseconds.</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The current state of the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("stateType")]
            [Validation(Required=false)]
            public string StateType { get; set; }

            /// <summary>
            /// <para>The list of status details for each phase of the change.</para>
            /// </summary>
            [NameInMap("statusInfo")]
            [Validation(Required=false)]
            public List<ListActionRecordsResponseBodyResultStatusInfo> StatusInfo { get; set; }
            public class ListActionRecordsResponseBodyResultStatusInfo : TeaModel {
                /// <summary>
                /// <para>The number of completed nodes in the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("completeNodeCount")]
                [Validation(Required=false)]
                public int? CompleteNodeCount { get; set; }

                /// <summary>
                /// <para>The end time of the phase. The value is a UNIX timestamp in milliseconds.</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The exception information for the phase.</para>
                /// </summary>
                [NameInMap("exception")]
                [Validation(Required=false)]
                public string Exception { get; set; }

                /// <summary>
                /// <para>The time elapsed for the phase, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("latencyMills")]
                [Validation(Required=false)]
                public long? LatencyMills { get; set; }

                /// <summary>
                /// <para>The total number of nodes involved in the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("nodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>The completion progress of the phase, represented as a percentage string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <para>The start time of the phase. The value is a UNIX timestamp in milliseconds.</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The current state of the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("stateType")]
                [Validation(Required=false)]
                public string StateType { get; set; }

                /// <summary>
                /// <para>The name of the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rolling</para>
                /// </summary>
                [NameInMap("subState")]
                [Validation(Required=false)]
                public string SubState { get; set; }

                /// <summary>
                /// <para>The list of status details for the sub-phases included in the current phase.</para>
                /// </summary>
                [NameInMap("subStatusInfo")]
                [Validation(Required=false)]
                public List<ListActionRecordsResponseBodyResultStatusInfoSubStatusInfo> SubStatusInfo { get; set; }
                public class ListActionRecordsResponseBodyResultStatusInfoSubStatusInfo : TeaModel {
                    /// <summary>
                    /// <para>The number of completed nodes in the sub-phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("completeNodeCount")]
                    [Validation(Required=false)]
                    public int? CompleteNodeCount { get; set; }

                    /// <summary>
                    /// <para>The end time of the sub-phase. The value is a UNIX timestamp in milliseconds.</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The exception information for the sub-phase.</para>
                    /// </summary>
                    [NameInMap("exception")]
                    [Validation(Required=false)]
                    public string Exception { get; set; }

                    /// <summary>
                    /// <para>The time elapsed for the sub-phase, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("latencyMills")]
                    [Validation(Required=false)]
                    public long? LatencyMills { get; set; }

                    /// <summary>
                    /// <para>The total number of nodes involved in the sub-phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    /// <summary>
                    /// <para>The completion progress of the sub-phase, represented as a percentage string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100%</para>
                    /// </summary>
                    [NameInMap("process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    /// <summary>
                    /// <para>The start time of the sub-phase. The value is a UNIX timestamp in milliseconds.</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The current state of the sub-phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("stateType")]
                    [Validation(Required=false)]
                    public string StateType { get; set; }

                    /// <summary>
                    /// <para>The name of the sub-phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>clusterStateWait</para>
                    /// </summary>
                    [NameInMap("subState")]
                    [Validation(Required=false)]
                    public string SubState { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the user that triggered the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

            /// <summary>
            /// <para>The type of the account that triggered the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
