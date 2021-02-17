// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryMsgTransTrendResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMqttQueryMsgTransTrendResponseBodyData Data { get; set; }
        public class OnsMqttQueryMsgTransTrendResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public OnsMqttQueryMsgTransTrendResponseBodyDataRecords Records { get; set; }
            public class OnsMqttQueryMsgTransTrendResponseBodyDataRecords : TeaModel {
                [NameInMap("StatsDataDo")]
                [Validation(Required=false)]
                public List<OnsMqttQueryMsgTransTrendResponseBodyDataRecordsStatsDataDo> StatsDataDo { get; set; }
                public class OnsMqttQueryMsgTransTrendResponseBodyDataRecordsStatsDataDo : TeaModel {
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                }

            }
            [NameInMap("XUnit")]
            [Validation(Required=false)]
            public string XUnit { get; set; }
            [NameInMap("YUnit")]
            [Validation(Required=false)]
            public string YUnit { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

    }

}
