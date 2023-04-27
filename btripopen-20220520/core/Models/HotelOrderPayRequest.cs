// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPayRequest : TeaModel {
        [NameInMap("btrip_order_id")]
        [Validation(Required=false)]
        public long? BtripOrderId { get; set; }

        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("company_pay_fee")]
        [Validation(Required=false)]
        public long? CompanyPayFee { get; set; }

        [NameInMap("person_pay_fee")]
        [Validation(Required=false)]
        public long? PersonPayFee { get; set; }

        [NameInMap("third_pay_account")]
        [Validation(Required=false)]
        public string ThirdPayAccount { get; set; }

        [NameInMap("third_trade_no")]
        [Validation(Required=false)]
        public string ThirdTradeNo { get; set; }

        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
