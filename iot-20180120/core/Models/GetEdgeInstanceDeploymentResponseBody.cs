// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceDeploymentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceDeploymentResponseBodyData Data { get; set; }
        public class GetEdgeInstanceDeploymentResponseBodyData : TeaModel {
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<GetEdgeInstanceDeploymentResponseBodyDataTaskList> TaskList { get; set; }
            public class GetEdgeInstanceDeploymentResponseBodyDataTaskList : TeaModel {
                public long? GmtCreateTimestamp { get; set; }
                public int? Status { get; set; }
                public List<GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList> ResourceSnapshotList { get; set; }
                public class GetEdgeInstanceDeploymentResponseBodyDataTaskListResourceSnapshotList : TeaModel {
                    public long? GmtCreateTimestamp { get; set; }
                    public int? Status { get; set; }
                    public int? Stage { get; set; }
                    public long? GmtModifiedTimestamp { get; set; }
                    public string Log { get; set; }
                    public string GmtModified { get; set; }
                    public int? OperateType { get; set; }
                    public string ResourceType { get; set; }
                    public string SnapshotId { get; set; }
                    public string GmtCompleted { get; set; }
                    public string GmtCreate { get; set; }
                    public long? GmtCompletedTimestamp { get; set; }
                    public string ResourceId { get; set; }
                    public string ResourceName { get; set; }
                }
                public int? Stage { get; set; }
                public string GatewayId { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public string GmtCompleted { get; set; }
                public string GmtCreate { get; set; }
                public long? GmtCompletedTimestamp { get; set; }
                public string GmtModified { get; set; }
                public string TaskId { get; set; }
            }
            [NameInMap("GmtCompleted")]
            [Validation(Required=false)]
            public string GmtCompleted { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtCompletedTimestamp")]
            [Validation(Required=false)]
            public long? GmtCompletedTimestamp { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
