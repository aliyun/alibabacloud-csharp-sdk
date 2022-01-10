// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CheckReceivingDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HasPromotion")]
        [Validation(Required=false)]
        public bool? HasPromotion { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        [NameInMap("TradeOrderId")]
        [Validation(Required=false)]
        public string TradeOrderId { get; set; }

        [NameInMap("UnionAmount")]
        [Validation(Required=false)]
        public string UnionAmount { get; set; }

    }

}
