// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficControlTaskTraffic")]
        [Validation(Required=false)]
        public GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTraffic TrafficControlTaskTraffic { get; set; }
        public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTraffic : TeaModel {
            [NameInMap("TargetTraffics")]
            [Validation(Required=false)]
            public List<GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficTargetTraffics> TargetTraffics { get; set; }
            public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficTargetTraffics : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Data { get; set; }

                [NameInMap("TrafficContorlTargetId")]
                [Validation(Required=false)]
                public string TrafficContorlTargetId { get; set; }

            }

            [NameInMap("TaskTraffics")]
            [Validation(Required=false)]
            public Dictionary<string, object> TaskTraffics { get; set; }

        }

    }

}
