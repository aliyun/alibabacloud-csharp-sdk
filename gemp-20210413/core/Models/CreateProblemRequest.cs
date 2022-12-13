// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemRequest : TeaModel {
        [NameInMap("affectServiceIds")]
        [Validation(Required=false)]
        public List<long?> AffectServiceIds { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("discoverTime")]
        [Validation(Required=false)]
        public string DiscoverTime { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        [NameInMap("mainHandlerId")]
        [Validation(Required=false)]
        public long? MainHandlerId { get; set; }

        [NameInMap("preliminaryReason")]
        [Validation(Required=false)]
        public string PreliminaryReason { get; set; }

        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        [NameInMap("problemName")]
        [Validation(Required=false)]
        public string ProblemName { get; set; }

        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        [NameInMap("problemStatus")]
        [Validation(Required=false)]
        public string ProblemStatus { get; set; }

        [NameInMap("progressSummary")]
        [Validation(Required=false)]
        public string ProgressSummary { get; set; }

        [NameInMap("progressSummaryRichTextId")]
        [Validation(Required=false)]
        public long? ProgressSummaryRichTextId { get; set; }

        [NameInMap("recoveryTime")]
        [Validation(Required=false)]
        public string RecoveryTime { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
