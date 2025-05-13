// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanStruct : TeaModel {
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        [NameInMap("closeExpire")]
        [Validation(Required=false)]
        public long? CloseExpire { get; set; }

        [NameInMap("corporation")]
        [Validation(Required=false)]
        public List<IncidentPlanCorporationStruct> Corporation { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> GroupBy { get; set; }

        [NameInMap("incidentPlanId")]
        [Validation(Required=false)]
        public string IncidentPlanId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resourceFiled")]
        [Validation(Required=false)]
        public List<IncidentPlanFieldPath> ResourceFiled { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
