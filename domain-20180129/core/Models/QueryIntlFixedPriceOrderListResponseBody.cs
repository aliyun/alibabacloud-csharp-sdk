// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryIntlFixedPriceOrderListResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryIntlFixedPriceOrderListResponseBodyModule Module { get; set; }
        public class QueryIntlFixedPriceOrderListResponseBodyModule : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public long? OrderType { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
