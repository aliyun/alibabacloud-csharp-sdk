// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemRequest : TeaModel {
        [NameInMap("feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("mainHandlerId")]
        [Validation(Required=false)]
        public long? MainHandlerId { get; set; }

        [NameInMap("preliminaryReason")]
        [Validation(Required=false)]
        public string PreliminaryReason { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("problemName")]
        [Validation(Required=false)]
        public string ProblemName { get; set; }

        [NameInMap("progressSummary")]
        [Validation(Required=false)]
        public string ProgressSummary { get; set; }

        [NameInMap("progressSummaryRichTextId")]
        [Validation(Required=false)]
        public long? ProgressSummaryRichTextId { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
