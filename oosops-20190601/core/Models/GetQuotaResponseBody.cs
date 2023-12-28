// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class GetQuotaResponseBody : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyQuota Quota { get; set; }
        public class GetQuotaResponseBodyQuota : TeaModel {
            [NameInMap("ConcurrentExecution")]
            [Validation(Required=false)]
            public int? ConcurrentExecution { get; set; }

            [NameInMap("DailyTasks")]
            [Validation(Required=false)]
            public int? DailyTasks { get; set; }

            [NameInMap("TotalTemplate")]
            [Validation(Required=false)]
            public int? TotalTemplate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
