// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerAccumulateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerAccumulateResponseBodyData Data { get; set; }
        public class OnsConsumerAccumulateResponseBodyData : TeaModel {
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public List<OnsConsumerAccumulateResponseBodyDataDetailInTopicList> DetailInTopicList { get; set; }
            public class OnsConsumerAccumulateResponseBodyDataDetailInTopicList : TeaModel {
                public long? DelayTime { get; set; }
                public long? TotalDiff { get; set; }
                public long? LastTimestamp { get; set; }
                public string Topic { get; set; }
            }
        };

    }

}
