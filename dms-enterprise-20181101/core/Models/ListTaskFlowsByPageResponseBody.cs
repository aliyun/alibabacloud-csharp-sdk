// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowsByPageResponseBody : TeaModel {
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
        public ListTaskFlowsByPageResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowsByPageResponseBodyTaskFlowList : TeaModel {
            [NameInMap("TaskFlow")]
            [Validation(Required=false)]
            public List<ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow> TaskFlow { get; set; }
            public class ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow : TeaModel {
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
