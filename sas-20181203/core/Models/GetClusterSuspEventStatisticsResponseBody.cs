// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterSuspEventStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuspStatistics")]
        [Validation(Required=false)]
        public GetClusterSuspEventStatisticsResponseBodySuspStatistics SuspStatistics { get; set; }
        public class GetClusterSuspEventStatisticsResponseBodySuspStatistics : TeaModel {
            [NameInMap("Remind")]
            [Validation(Required=false)]
            public int? Remind { get; set; }

            [NameInMap("Serious")]
            [Validation(Required=false)]
            public int? Serious { get; set; }

            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

    }

}
