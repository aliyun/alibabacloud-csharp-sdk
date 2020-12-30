// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListDevopsProjectTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<ListDevopsProjectTasksResponseBodyObject> Object { get; set; }
        public class ListDevopsProjectTasksResponseBodyObject : TeaModel {
            [NameInMap("TaskgroupId")]
            [Validation(Required=false)]
            public string TaskgroupId { get; set; }

            [NameInMap("TasklistId")]
            [Validation(Required=false)]
            public string TasklistId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
