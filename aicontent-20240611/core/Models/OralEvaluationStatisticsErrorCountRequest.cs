// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsErrorCountRequest : TeaModel {
        [NameInMap("applicationAccessId")]
        [Validation(Required=false)]
        public string ApplicationAccessId { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public List<string> ErrorCode { get; set; }

        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
