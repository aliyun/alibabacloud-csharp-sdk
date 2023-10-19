// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CssProduce : TeaModel {
        [NameInMap("bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public long? BuyerId { get; set; }

        [NameInMap("childId")]
        [Validation(Required=false)]
        public long? ChildId { get; set; }

        [NameInMap("fromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("payerId")]
        [Validation(Required=false)]
        public long? PayerId { get; set; }

        [NameInMap("purchases")]
        [Validation(Required=false)]
        public List<CssPurchase> Purchases { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("skipChannel")]
        [Validation(Required=false)]
        public bool? SkipChannel { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
