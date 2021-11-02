// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSuspiciousStatisticsResponseBody : TeaModel {
        [NameInMap("RemindCount")]
        [Validation(Required=false)]
        public int? RemindCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SeriousCount")]
        [Validation(Required=false)]
        public int? SeriousCount { get; set; }

        [NameInMap("SuspiciousCount")]
        [Validation(Required=false)]
        public int? SuspiciousCount { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
