// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetRealtimeStatsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeStatsResponseBodyData Data { get; set; }
        public class GetRealtimeStatsResponseBodyData : TeaModel {
            [NameInMap("TodayPvCount")]
            [Validation(Required=false)]
            public Dictionary<string, string> TodayPvCount { get; set; }

            [NameInMap("TodayUvCount")]
            [Validation(Required=false)]
            public Dictionary<string, string> TodayUvCount { get; set; }

            [NameInMap("TotalPvCount")]
            [Validation(Required=false)]
            public Dictionary<string, string> TotalPvCount { get; set; }

            [NameInMap("TotalUvCount")]
            [Validation(Required=false)]
            public Dictionary<string, string> TotalUvCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
