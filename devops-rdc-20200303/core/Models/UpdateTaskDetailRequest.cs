// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class UpdateTaskDetailRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ExecutorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("DueDate")]
        [Validation(Required=false)]
        public string DueDate { get; set; }

        [NameInMap("TaskFlowStatusId")]
        [Validation(Required=false)]
        public string TaskFlowStatusId { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("SprintId")]
        [Validation(Required=false)]
        public string SprintId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("WorkTimes")]
        [Validation(Required=false)]
        public long? WorkTimes { get; set; }

        [NameInMap("CustomFieldId")]
        [Validation(Required=false)]
        public string CustomFieldId { get; set; }

        [NameInMap("CustomFieldValues")]
        [Validation(Required=false)]
        public string CustomFieldValues { get; set; }

        [NameInMap("StoryPoint")]
        [Validation(Required=false)]
        public string StoryPoint { get; set; }

        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public string TagIds { get; set; }

        [NameInMap("DelInvolvers")]
        [Validation(Required=false)]
        public string DelInvolvers { get; set; }

        [NameInMap("AddInvolvers")]
        [Validation(Required=false)]
        public string AddInvolvers { get; set; }

    }

}
