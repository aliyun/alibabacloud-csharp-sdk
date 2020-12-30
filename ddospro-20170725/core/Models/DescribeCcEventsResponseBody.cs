// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeCcEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeCcEventsResponseBodyEventList> EventList { get; set; }
        public class DescribeCcEventsResponseBodyEventList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("AttackFinished")]
            [Validation(Required=false)]
            public bool? AttackFinished { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public int? MaxQps { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("BlockedCount")]
            [Validation(Required=false)]
            public int? BlockedCount { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
