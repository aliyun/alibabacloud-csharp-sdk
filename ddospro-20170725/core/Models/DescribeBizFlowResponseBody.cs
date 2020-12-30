// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeBizFlowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBizFlowResponseBodyData Data { get; set; }
        public class DescribeBizFlowResponseBodyData : TeaModel {
            [NameInMap("InKbps")]
            [Validation(Required=false)]
            public List<string> InKbps { get; set; }
            [NameInMap("OutKbps")]
            [Validation(Required=false)]
            public List<string> OutKbps { get; set; }
            [NameInMap("TimeScope")]
            [Validation(Required=false)]
            public DescribeBizFlowResponseBodyDataTimeScope TimeScope { get; set; }
            public class DescribeBizFlowResponseBodyDataTimeScope : TeaModel {
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

            }
        };

    }

}
