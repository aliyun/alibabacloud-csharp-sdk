// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class SendCouponResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContextMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextMap { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SendCouponResponseBodyData> Data { get; set; }
        public class SendCouponResponseBodyData : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("YouhuiId")]
            [Validation(Required=false)]
            public long? YouhuiId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
