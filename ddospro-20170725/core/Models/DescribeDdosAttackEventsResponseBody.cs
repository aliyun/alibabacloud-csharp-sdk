// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDdosAttackEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDdosAttackEventsResponseBodyData Data { get; set; }
        public class DescribeDdosAttackEventsResponseBodyData : TeaModel {
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<DescribeDdosAttackEventsResponseBodyDataEventList> EventList { get; set; }
            public class DescribeDdosAttackEventsResponseBodyDataEventList : TeaModel {
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public string AttackType { get; set; }
                public int? Result { get; set; }
                public string Duration { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
