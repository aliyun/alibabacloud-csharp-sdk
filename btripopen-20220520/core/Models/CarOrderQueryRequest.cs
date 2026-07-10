// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryRequest : TeaModel {
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("sub_order_id")]
        [Validation(Required=false)]
        public long? SubOrderId { get; set; }

    }

}
