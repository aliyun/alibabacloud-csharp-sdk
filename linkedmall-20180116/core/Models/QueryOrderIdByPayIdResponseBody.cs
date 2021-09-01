// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderIdByPayIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LmOrderIds")]
        [Validation(Required=false)]
        public QueryOrderIdByPayIdResponseBodyLmOrderIds LmOrderIds { get; set; }
        public class QueryOrderIdByPayIdResponseBodyLmOrderIds : TeaModel {
            [NameInMap("LmOrderIds")]
            [Validation(Required=false)]
            public List<QueryOrderIdByPayIdResponseBodyLmOrderIdsLmOrderIds> LmOrderIds { get; set; }
            public class QueryOrderIdByPayIdResponseBodyLmOrderIdsLmOrderIds : TeaModel {
                public long? LmOrderId { get; set; }
            }
        };

    }

}
