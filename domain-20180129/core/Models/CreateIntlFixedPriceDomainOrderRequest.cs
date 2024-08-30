// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CreateIntlFixedPriceDomainOrderRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("ExpectedPrice")]
        [Validation(Required=false)]
        public long? ExpectedPrice { get; set; }

    }

}
