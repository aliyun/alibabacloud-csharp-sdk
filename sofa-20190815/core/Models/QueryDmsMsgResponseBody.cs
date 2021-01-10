// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryDmsMsgResponseBody : TeaModel {
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
        public QueryDmsMsgResponseBodyData Data { get; set; }
        public class QueryDmsMsgResponseBodyData : TeaModel {
            [NameInMap("DeliveryCount")]
            [Validation(Required=false)]
            public long? DeliveryCount { get; set; }
            [NameInMap("Eventcode")]
            [Validation(Required=false)]
            public string Eventcode { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtLastDelivery")]
            [Validation(Required=false)]
            public string GmtLastDelivery { get; set; }
            [NameInMap("GmtNextDelivery")]
            [Validation(Required=false)]
            public string GmtNextDelivery { get; set; }
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }
            [NameInMap("PublisherGroup")]
            [Validation(Required=false)]
            public string PublisherGroup { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SubscriberGroupDelivery")]
            [Validation(Required=false)]
            public string SubscriberGroupDelivery { get; set; }
            [NameInMap("SubscriberGroupUndelivery")]
            [Validation(Required=false)]
            public string SubscriberGroupUndelivery { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("Transaction")]
            [Validation(Required=false)]
            public bool? Transaction { get; set; }
        };

    }

}
