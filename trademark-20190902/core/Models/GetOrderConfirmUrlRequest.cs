// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class GetOrderConfirmUrlRequest : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetOrderConfirmUrlRequestItems> Items { get; set; }
        public class GetOrderConfirmUrlRequestItems : TeaModel {
            [NameInMap("ItemCode")]
            [Validation(Required=false)]
            public string ItemCode { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

        }

        [NameInMap("OutTraceCode")]
        [Validation(Required=false)]
        public string OutTraceCode { get; set; }

        [NameInMap("OutTraceType")]
        [Validation(Required=false)]
        public string OutTraceType { get; set; }

    }

}
