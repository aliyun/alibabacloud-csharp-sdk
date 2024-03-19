// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderPayRequest : TeaModel {
        [NameInMap("ext_params")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtParams { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
