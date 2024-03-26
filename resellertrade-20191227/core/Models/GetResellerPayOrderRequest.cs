// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class GetResellerPayOrderRequest : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
