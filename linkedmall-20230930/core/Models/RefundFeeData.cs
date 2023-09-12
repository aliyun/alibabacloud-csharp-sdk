// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundFeeData : TeaModel {
        [NameInMap("maxRefundFee")]
        [Validation(Required=false)]
        public long? MaxRefundFee { get; set; }

        [NameInMap("minRefundFee")]
        [Validation(Required=false)]
        public long? MinRefundFee { get; set; }

    }

}
