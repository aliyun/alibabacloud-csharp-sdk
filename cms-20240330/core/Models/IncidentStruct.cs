// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentStruct : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<IncidentEscalationStruct> Escalations { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("incidentPlan")]
        [Validation(Required=false)]
        public IncidentPlanStruct IncidentPlan { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public IncidentResourceDetail Resource { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
