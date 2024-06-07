// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskTrafficRequest : TeaModel {
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Traffics")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskTrafficRequestTraffics> Traffics { get; set; }
        public class UpdateTrafficControlTaskTrafficRequestTraffics : TeaModel {
            [NameInMap("ItemOrExperimentId")]
            [Validation(Required=false)]
            public string ItemOrExperimentId { get; set; }

            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTargetTraffic { get; set; }

            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTaskTraffic { get; set; }

        }

        [NameInMap("new-param-3")]
        [Validation(Required=false)]
        public string NewParam3 { get; set; }

    }

}
