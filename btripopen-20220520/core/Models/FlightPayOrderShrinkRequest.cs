// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightPayOrderShrinkRequest : TeaModel {
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        [NameInMap("personal_pay_price")]
        [Validation(Required=false)]
        public long? PersonalPayPrice { get; set; }

        [NameInMap("total_pay_price")]
        [Validation(Required=false)]
        public long? TotalPayPrice { get; set; }

    }

}
