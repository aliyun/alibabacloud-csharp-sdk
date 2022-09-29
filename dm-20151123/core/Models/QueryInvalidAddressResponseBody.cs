// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryInvalidAddressResponseBody : TeaModel {
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryInvalidAddressResponseBodyData Data { get; set; }
        public class QueryInvalidAddressResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<QueryInvalidAddressResponseBodyDataMailDetail> MailDetail { get; set; }
            public class QueryInvalidAddressResponseBodyDataMailDetail : TeaModel {
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                [NameInMap("ToAddress")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                [NameInMap("UtcLastUpdateTime")]
                [Validation(Required=false)]
                public long? UtcLastUpdateTime { get; set; }

            }

        }

    }

}
