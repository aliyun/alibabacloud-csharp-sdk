// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqConsumerAccumulateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMqSofamqConsumerAccumulateResponseBodyData Data { get; set; }
        public class QueryMqSofamqConsumerAccumulateResponseBodyData : TeaModel {
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public string ConsumeTps { get; set; }
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public List<QueryMqSofamqConsumerAccumulateResponseBodyDataDetailInTopicList> DetailInTopicList { get; set; }
            public class QueryMqSofamqConsumerAccumulateResponseBodyDataDetailInTopicList : TeaModel {
                public long? DelayTime { get; set; }
                public long? LastTimestamp { get; set; }
                public string Topic { get; set; }
                public long? TotalDiff { get; set; }
            }
        };

    }

}
