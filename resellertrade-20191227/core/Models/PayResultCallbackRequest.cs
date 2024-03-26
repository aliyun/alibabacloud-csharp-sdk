// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class PayResultCallbackRequest : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        [NameInMap("PayTime")]
        [Validation(Required=false)]
        public string PayTime { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
