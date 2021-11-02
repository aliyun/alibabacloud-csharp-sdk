// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerStatisticsResponseBodyData Data { get; set; }
        public class DescribeContainerStatisticsResponseBodyData : TeaModel {
            [NameInMap("RemindAlarmCount")]
            [Validation(Required=false)]
            public int? RemindAlarmCount { get; set; }
            [NameInMap("SeriousAlarmCount")]
            [Validation(Required=false)]
            public int? SeriousAlarmCount { get; set; }
            [NameInMap("SuspiciousAlarmCount")]
            [Validation(Required=false)]
            public int? SuspiciousAlarmCount { get; set; }
            [NameInMap("TotalAlarmCount")]
            [Validation(Required=false)]
            public int? TotalAlarmCount { get; set; }
            [NameInMap("TotalNode")]
            [Validation(Required=false)]
            public int? TotalNode { get; set; }
            [NameInMap("hasRiskNode")]
            [Validation(Required=false)]
            public int? HasRiskNode { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
