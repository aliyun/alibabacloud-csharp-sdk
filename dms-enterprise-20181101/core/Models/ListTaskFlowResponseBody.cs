// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskFlowList")]
        [Validation(Required=false)]
        public ListTaskFlowResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowResponseBodyTaskFlowList : TeaModel {
            [NameInMap("DAGInstance")]
            [Validation(Required=false)]
            public List<ListTaskFlowResponseBodyTaskFlowListDAGInstance> DAGInstance { get; set; }
            public class ListTaskFlowResponseBodyTaskFlowListDAGInstance : TeaModel {
                public string CreatorId { get; set; }
                public string CreatorNickName { get; set; }
                public string DagOwnerNickName { get; set; }
                public long? DeployId { get; set; }
                public long? Id { get; set; }
                public int? LatestInstanceStatus { get; set; }
                public string LatestInstanceTime { get; set; }
                public int? Status { get; set; }
            }
        };

    }

}
