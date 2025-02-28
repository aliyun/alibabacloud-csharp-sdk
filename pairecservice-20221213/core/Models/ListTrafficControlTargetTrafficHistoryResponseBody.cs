// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTargetTrafficHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("TrafficControlTaskTrafficHistories")]
        [Validation(Required=false)]
        public List<ListTrafficControlTargetTrafficHistoryResponseBodyTrafficControlTaskTrafficHistories> TrafficControlTaskTrafficHistories { get; set; }
        public class ListTrafficControlTargetTrafficHistoryResponseBodyTrafficControlTaskTrafficHistories : TeaModel {
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetTraffic { get; set; }

            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTaskTraffic { get; set; }

        }

    }

}
