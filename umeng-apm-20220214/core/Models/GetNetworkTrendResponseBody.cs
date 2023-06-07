// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetNetworkTrendResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNetworkTrendResponseBodyData> Data { get; set; }
        public class GetNetworkTrendResponseBodyData : TeaModel {
            [NameInMap("avgCost")]
            [Validation(Required=false)]
            public double? AvgCost { get; set; }

            [NameInMap("avgResponseTime")]
            [Validation(Required=false)]
            public double? AvgResponseTime { get; set; }

            [NameInMap("avgTransformBytes")]
            [Validation(Required=false)]
            public double? AvgTransformBytes { get; set; }

            [NameInMap("requestPerMinute")]
            [Validation(Required=false)]
            public double? RequestPerMinute { get; set; }

            [NameInMap("timePoint")]
            [Validation(Required=false)]
            public string TimePoint { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
