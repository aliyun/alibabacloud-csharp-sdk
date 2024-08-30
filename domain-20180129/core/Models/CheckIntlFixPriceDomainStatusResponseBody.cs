// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckIntlFixPriceDomainStatusResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckIntlFixPriceDomainStatusResponseBodyModule Module { get; set; }
        public class CheckIntlFixPriceDomainStatusResponseBodyModule : TeaModel {
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("DeadDate")]
            [Validation(Required=false)]
            public long? DeadDate { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Premium")]
            [Validation(Required=false)]
            public bool? Premium { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public long? RegDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
