// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LifecycleRule : TeaModel {
        [NameInMap("ArchiveDays")]
        [Validation(Required=false)]
        public int? ArchiveDays { get; set; }

        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("ColdArchiveDays")]
        [Validation(Required=false)]
        public int? ColdArchiveDays { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("IaDays")]
        [Validation(Required=false)]
        public int? IaDays { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("ScheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        [NameInMap("Workflow")]
        [Validation(Required=false)]
        public Workflow Workflow { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        [NameInMap("WorkflowInstance")]
        [Validation(Required=false)]
        public WorkflowInstance WorkflowInstance { get; set; }

    }

}
