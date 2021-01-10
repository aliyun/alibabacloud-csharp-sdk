// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqConsumerTimespanResponseBody : TeaModel {
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
        public QueryMqSofamqConsumerTimespanResponseBodyData Data { get; set; }
        public class QueryMqSofamqConsumerTimespanResponseBodyData : TeaModel {
            [NameInMap("ConsumeTimestamp")]
            [Validation(Required=false)]
            public long? ConsumeTimestamp { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MaxTimestamp")]
            [Validation(Required=false)]
            public long? MaxTimestamp { get; set; }
            [NameInMap("MinTimestamp")]
            [Validation(Required=false)]
            public long? MinTimestamp { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
        };

    }

}
