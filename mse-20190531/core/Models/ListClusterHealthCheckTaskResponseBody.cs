// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListClusterHealthCheckTaskResponseBody : TeaModel {
        /// <summary>
        /// The status code. A value of 200 is returned if the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClusterHealthCheckTaskResponseBodyData Data { get; set; }
        public class ListClusterHealthCheckTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The list of health check tasks.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListClusterHealthCheckTaskResponseBodyDataResult> Result { get; set; }
            public class ListClusterHealthCheckTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The complete version number.
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The type of the cluster.
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The serial number.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// A redundant parameter.
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the user to which the cluster belongs.
                /// </summary>
                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                /// <summary>
                /// The number of nodes in the cluster.
                /// </summary>
                [NameInMap("Replica")]
                [Validation(Required=false)]
                public string Replica { get; set; }

                /// <summary>
                /// The risk items.
                /// </summary>
                [NameInMap("RiskList")]
                [Validation(Required=false)]
                public List<ListClusterHealthCheckTaskResponseBodyDataResultRiskList> RiskList { get; set; }
                public class ListClusterHealthCheckTaskResponseBodyDataResultRiskList : TeaModel {
                    /// <summary>
                    /// The description.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// A redundant parameter.
                    /// </summary>
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    /// <summary>
                    /// Indicates whether the risk item notification feature is disabled. Valid values:
                    /// 
                    /// *   true: disabled
                    /// *   false: enabled
                    /// </summary>
                    [NameInMap("Mute")]
                    [Validation(Required=false)]
                    public bool? Mute { get; set; }

                    /// <summary>
                    /// A redundant parameter.
                    /// </summary>
                    [NameInMap("NoticeFeature")]
                    [Validation(Required=false)]
                    public bool? NoticeFeature { get; set; }

                    /// <summary>
                    /// The ID of the user to which the cluster belongs.
                    /// </summary>
                    [NameInMap("PrimaryUser")]
                    [Validation(Required=false)]
                    public string PrimaryUser { get; set; }

                    /// <summary>
                    /// The code of the risk.
                    /// </summary>
                    [NameInMap("RiskCode")]
                    [Validation(Required=false)]
                    public string RiskCode { get; set; }

                    /// <summary>
                    /// The severity of the risk. Valid values:
                    /// 
                    /// *   HIGH: high risk
                    /// *   MID: medium risk
                    /// *   LOW: low risk
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// The name of the risk.
                    /// </summary>
                    [NameInMap("RiskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    /// <summary>
                    /// The type of the risk.
                    /// </summary>
                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                    /// <summary>
                    /// The situation.
                    /// </summary>
                    [NameInMap("Situation")]
                    [Validation(Required=false)]
                    public string Situation { get; set; }

                    /// <summary>
                    /// The suggestion.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The ID of the associated parent task.
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    /// <summary>
                    /// A redundant parameter.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// A redundant parameter.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// The total score.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The specifications.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The task state.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The total number of check items.
                /// </summary>
                [NameInMap("TotalItem")]
                [Validation(Required=false)]
                public int? TotalItem { get; set; }

                /// <summary>
                /// The total number of risk items.
                /// </summary>
                [NameInMap("TotalRisk")]
                [Validation(Required=false)]
                public int? TotalRisk { get; set; }

                /// <summary>
                /// A redundant parameter.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the task was last updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the \*\*%s\*\* variable in the **ErrMessage** parameter.
        /// 
        /// > If the return value of the **ErrMessage** parameter is **The Value of Input Parameter %s is not valid** and the return value of the **DynamicMessage** parameter is **DtsJobId**, the specified **DtsJobId** parameter is invalid.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the request failed. Take note of the following rules:
        /// 
        /// *   The **ErrorCode** parameter is not returned if the request is successful.
        /// *   The **ErrorCode** parameter is returned if the request fails. For more information, see the **Error codes** section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
