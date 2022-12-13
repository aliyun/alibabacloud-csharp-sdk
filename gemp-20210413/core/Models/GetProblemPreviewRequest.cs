// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemPreviewRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("effectServiceIds")]
        [Validation(Required=false)]
        public List<long?> EffectServiceIds { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
