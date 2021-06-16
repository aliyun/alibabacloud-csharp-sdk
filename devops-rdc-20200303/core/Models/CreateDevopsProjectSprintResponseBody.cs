// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class CreateDevopsProjectSprintResponseBody : TeaModel {
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public CreateDevopsProjectSprintResponseBodyObject Object { get; set; }
        public class CreateDevopsProjectSprintResponseBodyObject : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("DueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("PlanToDo")]
            [Validation(Required=false)]
            public CreateDevopsProjectSprintResponseBodyObjectPlanToDo PlanToDo { get; set; }
            public class CreateDevopsProjectSprintResponseBodyObjectPlanToDo : TeaModel {
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public int? Tasks { get; set; }

                [NameInMap("WorkTimes")]
                [Validation(Required=false)]
                public int? WorkTimes { get; set; }

                [NameInMap("StoryPoints")]
                [Validation(Required=false)]
                public int? StoryPoints { get; set; }

            }
        };

    }

}
