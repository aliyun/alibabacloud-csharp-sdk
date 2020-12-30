// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetTaskListFilterRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ScenarioFieldConfigId")]
        [Validation(Required=false)]
        public string ScenarioFieldConfigId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OrderCondition")]
        [Validation(Required=false)]
        public string OrderCondition { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("ExecutorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        [NameInMap("DueDateStart")]
        [Validation(Required=false)]
        public string DueDateStart { get; set; }

        [NameInMap("DueDateEnd")]
        [Validation(Required=false)]
        public string DueDateEnd { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("InvolveMembers")]
        [Validation(Required=false)]
        public string InvolveMembers { get; set; }

        [NameInMap("IsDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("TaskFlowStatusId")]
        [Validation(Required=false)]
        public string TaskFlowStatusId { get; set; }

        [NameInMap("SprintId")]
        [Validation(Required=false)]
        public string SprintId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

    }

}
