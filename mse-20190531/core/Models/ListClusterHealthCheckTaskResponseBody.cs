// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListClusterHealthCheckTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClusterHealthCheckTaskResponseBodyData Data { get; set; }
        public class ListClusterHealthCheckTaskResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListClusterHealthCheckTaskResponseBodyDataResult> Result { get; set; }
            public class ListClusterHealthCheckTaskResponseBodyDataResult : TeaModel {
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// ID。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                [NameInMap("Replica")]
                [Validation(Required=false)]
                public string Replica { get; set; }

                [NameInMap("RiskList")]
                [Validation(Required=false)]
                public List<ListClusterHealthCheckTaskResponseBodyDataResultRiskList> RiskList { get; set; }
                public class ListClusterHealthCheckTaskResponseBodyDataResultRiskList : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// ID。
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    [NameInMap("Mute")]
                    [Validation(Required=false)]
                    public bool? Mute { get; set; }

                    [NameInMap("NoticeFeature")]
                    [Validation(Required=false)]
                    public bool? NoticeFeature { get; set; }

                    [NameInMap("PrimaryUser")]
                    [Validation(Required=false)]
                    public string PrimaryUser { get; set; }

                    [NameInMap("RiskCode")]
                    [Validation(Required=false)]
                    public string RiskCode { get; set; }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("RiskName")]
                    [Validation(Required=false)]
                    public string RiskName { get; set; }

                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                    [NameInMap("Situation")]
                    [Validation(Required=false)]
                    public string Situation { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalItem")]
                [Validation(Required=false)]
                public int? TotalItem { get; set; }

                [NameInMap("TotalRisk")]
                [Validation(Required=false)]
                public int? TotalRisk { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
