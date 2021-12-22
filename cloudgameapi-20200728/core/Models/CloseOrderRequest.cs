// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CloseOrderRequest : TeaModel {
        [NameInMap("AccountDomain")]
        [Validation(Required=false)]
        public string AccountDomain { get; set; }

        [NameInMap("BuyerAccountId")]
        [Validation(Required=false)]
        public string BuyerAccountId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
