// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateOutboundTaskRequest : TeaModel {
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RetryTime")]
        [Validation(Required=false)]
        public int? RetryTime { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        [NameInMap("SkillGroup")]
        [Validation(Required=false)]
        public long? SkillGroup { get; set; }

        [NameInMap("Ani")]
        [Validation(Required=false)]
        public string Ani { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public int? Model { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        [NameInMap("ExtAttrs")]
        [Validation(Required=false)]
        public string ExtAttrs { get; set; }

        [NameInMap("CallInfos")]
        [Validation(Required=false)]
        public string CallInfos { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
