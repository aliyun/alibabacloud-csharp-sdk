// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class ListProjectTaskFlowStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<ListProjectTaskFlowStatusResponseBodyObject> Object { get; set; }
        public class ListProjectTaskFlowStatusResponseBodyObject : TeaModel {
            [NameInMap("TaskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("RejectStatusIds")]
            [Validation(Required=false)]
            public string RejectStatusIds { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
