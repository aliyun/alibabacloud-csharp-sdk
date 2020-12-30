// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class CreateDevopsProjectTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public CreateDevopsProjectTaskResponseBodyObject Object { get; set; }
        public class CreateDevopsProjectTaskResponseBodyObject : TeaModel {
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("ScenarioFieldConfigId")]
            [Validation(Required=false)]
            public string ScenarioFieldConfigId { get; set; }
            [NameInMap("AncestorIds")]
            [Validation(Required=false)]
            public string AncestorIds { get; set; }
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }
            [NameInMap("TasklistId")]
            [Validation(Required=false)]
            public string TasklistId { get; set; }
            [NameInMap("TaskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public int? UniqueId { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Rating")]
            [Validation(Required=false)]
            public int? Rating { get; set; }
            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("StoryPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }
            [NameInMap("Visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }
            [NameInMap("IsDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }
            [NameInMap("SprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }
            [NameInMap("DueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
