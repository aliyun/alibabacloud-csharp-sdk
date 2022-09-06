// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceDeploymentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceDeploymentResponseBodyData Data { get; set; }
        public class GetEdgeInstanceDeploymentResponseBodyData : TeaModel {
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCompleted")]
            [Validation(Required=false)]
            public string GmtCompleted { get; set; }

            [NameInMap("GmtCompletedTimestamp")]
            [Validation(Required=false)]
            public long? GmtCompletedTimestamp { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<GetEdgeInstanceDeploymentResponseBodyDataTaskList> TaskList { get; set; }
            public class GetEdgeInstanceDeploymentResponseBodyDataTaskList : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("GmtCompleted")]
                [Validation(Required=false)]
                public string GmtCompleted { get; set; }

                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=false)]
                public long? GmtCompletedTimestamp { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("ResourceSnapshotList")]
                [Validation(Required=false)]
                public List<GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList> ResourceSnapshotList { get; set; }
                public class GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList : TeaModel {
                    [NameInMap("GmtCompleted")]
                    [Validation(Required=false)]
                    public string GmtCompleted { get; set; }

                    [NameInMap("GmtCompletedTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtCompletedTimestamp { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtCreateTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtCreateTimestamp { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtModifiedTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtModifiedTimestamp { get; set; }

                    [NameInMap("Log")]
                    [Validation(Required=false)]
                    public string Log { get; set; }

                    [NameInMap("OperateType")]
                    [Validation(Required=false)]
                    public int? OperateType { get; set; }

                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    [NameInMap("ResourceName")]
                    [Validation(Required=false)]
                    public string ResourceName { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("SnapshotId")]
                    [Validation(Required=false)]
                    public string SnapshotId { get; set; }

                    [NameInMap("Stage")]
                    [Validation(Required=false)]
                    public int? Stage { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                [NameInMap("Stage")]
                [Validation(Required=false)]
                public int? Stage { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
