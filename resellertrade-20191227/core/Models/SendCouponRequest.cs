// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class SendCouponRequest : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public long? Bid { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SellerId")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("UserAmountModelList")]
        [Validation(Required=false)]
        public List<SendCouponRequestUserAmountModelList> UserAmountModelList { get; set; }
        public class SendCouponRequestUserAmountModelList : TeaModel {
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

    }

}
