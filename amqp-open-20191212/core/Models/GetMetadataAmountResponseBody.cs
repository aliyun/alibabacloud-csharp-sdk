// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class GetMetadataAmountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetadataAmountResponseBodyData Data { get; set; }
        public class GetMetadataAmountResponseBodyData : TeaModel {
            [NameInMap("MaxVirtualHosts")]
            [Validation(Required=false)]
            public int? MaxVirtualHosts { get; set; }
            [NameInMap("CurrentVirtualHosts")]
            [Validation(Required=false)]
            public int? CurrentVirtualHosts { get; set; }
            [NameInMap("MaxQueues")]
            [Validation(Required=false)]
            public int? MaxQueues { get; set; }
            [NameInMap("CurrentExchanges")]
            [Validation(Required=false)]
            public int? CurrentExchanges { get; set; }
            [NameInMap("MaxExchanges")]
            [Validation(Required=false)]
            public int? MaxExchanges { get; set; }
            [NameInMap("CurrentQueues")]
            [Validation(Required=false)]
            public int? CurrentQueues { get; set; }
        };

    }

}
