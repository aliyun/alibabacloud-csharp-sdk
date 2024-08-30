// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CreateIntlFixedPriceDomainOrderResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateIntlFixedPriceDomainOrderResponseBodyModule Module { get; set; }
        public class CreateIntlFixedPriceDomainOrderResponseBodyModule : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("PayPrice")]
            [Validation(Required=false)]
            public long? PayPrice { get; set; }

            [NameInMap("PayUrl")]
            [Validation(Required=false)]
            public string PayUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
