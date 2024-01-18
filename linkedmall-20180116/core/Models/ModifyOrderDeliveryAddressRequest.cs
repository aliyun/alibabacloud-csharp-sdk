// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ModifyOrderDeliveryAddressRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DeliveryAddress")]
        [Validation(Required=false)]
        public string DeliveryAddress { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

        [NameInMap("LmOrderId")]
        [Validation(Required=false)]
        public long? LmOrderId { get; set; }

    }

}
