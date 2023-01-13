// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceDeploymentResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetEdgeInstanceDeploymentResponseData Data { get; set; }
        public class GetEdgeInstanceDeploymentResponseData : TeaModel {
            [NameInMap("DeploymentId")]
            [Validation(Required=true)]
            public string DeploymentId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("GmtCompleted")]
            [Validation(Required=true)]
            public string GmtCompleted { get; set; }

            [NameInMap("GmtCompletedTimestamp")]
            [Validation(Required=true)]
            public long? GmtCompletedTimestamp { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=true)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=true)]
            public long? GmtModifiedTimestamp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }

            [NameInMap("TaskList")]
            [Validation(Required=true)]
            public List<GetEdgeInstanceDeploymentResponseDataTaskList> TaskList { get; set; }
            public class GetEdgeInstanceDeploymentResponseDataTaskList : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=true)]
                public string GatewayId { get; set; }

                [NameInMap("GmtCompleted")]
                [Validation(Required=true)]
                public string GmtCompleted { get; set; }

                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=true)]
                public long? GmtCompletedTimestamp { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=true)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=true)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=true)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("Stage")]
                [Validation(Required=true)]
                public int? Stage { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=true)]
                public string TaskId { get; set; }

                [NameInMap("ResourceSnapshotList")]
                [Validation(Required=true)]
                public List<GetEdgeInstanceDeploymentResponseDataTaskListResourceSnapshotList> ResourceSnapshotList { get; set; }
                public class GetEdgeInstanceDeploymentResponseDataTaskListResourceSnapshotList : TeaModel {
                    [NameInMap("GmtCompleted")]
                    [Validation(Required=true)]
                    public string GmtCompleted { get; set; }

                    [NameInMap("GmtCompletedTimestamp")]
                    [Validation(Required=true)]
                    public long? GmtCompletedTimestamp { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtCreateTimestamp")]
                    [Validation(Required=true)]
                    public long? GmtCreateTimestamp { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtModifiedTimestamp")]
                    [Validation(Required=true)]
                    public long? GmtModifiedTimestamp { get; set; }

                    [NameInMap("Log")]
                    [Validation(Required=true)]
                    public string Log { get; set; }

                    [NameInMap("OperateType")]
                    [Validation(Required=true)]
                    public int? OperateType { get; set; }

                    [NameInMap("ResourceId")]
                    [Validation(Required=true)]
                    public string ResourceId { get; set; }

                    [NameInMap("ResourceName")]
                    [Validation(Required=true)]
                    public string ResourceName { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=true)]
                    public string ResourceType { get; set; }

                    [NameInMap("SnapshotId")]
                    [Validation(Required=true)]
                    public string SnapshotId { get; set; }

                    [NameInMap("Stage")]
                    [Validation(Required=true)]
                    public int? Stage { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public int? Status { get; set; }

                }

            }

        }

    }

}
