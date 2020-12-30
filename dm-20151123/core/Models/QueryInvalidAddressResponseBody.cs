// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryInvalidAddressResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryInvalidAddressResponseBodyData Data { get; set; }
        public class QueryInvalidAddressResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<QueryInvalidAddressResponseBodyDataMailDetail> MailDetail { get; set; }
            public class QueryInvalidAddressResponseBodyDataMailDetail : TeaModel {
                public string LastUpdateTime { get; set; }
                public string ToAddress { get; set; }
                public long? UtcLastUpdateTime { get; set; }
            }
        };

        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public int? NextStart { get; set; }

    }

}
