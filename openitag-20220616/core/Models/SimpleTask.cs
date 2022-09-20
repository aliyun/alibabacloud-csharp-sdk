// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleTask : TeaModel {
        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        [NameInMap("ArchivedInfos")]
        [Validation(Required=false)]
        public string ArchivedInfos { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("LabelStyle")]
        [Validation(Required=false)]
        public string LabelStyle { get; set; }

        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        [NameInMap("RefTaskId")]
        [Validation(Required=false)]
        public string RefTaskId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public List<string> WorkflowNodes { get; set; }

    }

}
