// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceDeploymentResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetEdgeInstanceDeploymentResponseData Data { get; set; }
        public class GetEdgeInstanceDeploymentResponseData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }
            [NameInMap("GmtCompleted")]
            [Validation(Required=true)]
            public string GmtCompleted { get; set; }
            [NameInMap("DeploymentId")]
            [Validation(Required=true)]
            public string DeploymentId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=true)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=true)]
            public long? GmtModifiedTimestamp { get; set; }
            [NameInMap("GmtCompletedTimestamp")]
            [Validation(Required=true)]
            public long? GmtCompletedTimestamp { get; set; }
            [NameInMap("TaskList")]
            [Validation(Required=true)]
            public List<GetEdgeInstanceDeploymentResponseDataTaskList> TaskList { get; set; }
            public class GetEdgeInstanceDeploymentResponseDataTaskList : TeaModel {
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string GmtCompleted { get; set; }
                public string GatewayId { get; set; }
                public string TaskId { get; set; }
                public int? Stage { get; set; }
                public int? Status { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public long? GmtCompletedTimestamp { get; set; }
                public List<GetEdgeInstanceDeploymentResponseDataTaskListResourceSnapshotList> ResourceSnapshotList { get; set; }
                public class GetEdgeInstanceDeploymentResponseDataTaskListResourceSnapshotList : TeaModel {
                    public string GmtCreate { get; set; }
                    public string GmtModified { get; set; }
                    public string GmtCompleted { get; set; }
                    public string SnapshotId { get; set; }
                    public string ResourceType { get; set; }
                    public string ResourceId { get; set; }
                    public string ResourceName { get; set; }
                    public int? OperateType { get; set; }
                    public int? Stage { get; set; }
                    public int? Status { get; set; }
                    public string Log { get; set; }
                    public long? GmtCreateTimestamp { get; set; }
                    public long? GmtModifiedTimestamp { get; set; }
                    public long? GmtCompletedTimestamp { get; set; }
                }
            }
        };

    }

}
