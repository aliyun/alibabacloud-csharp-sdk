// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseCodes")]
        [Validation(Required=false)]
        public List<DescribeResponseCodeTrendGraphResponseBodyResponseCodes> ResponseCodes { get; set; }
        public class DescribeResponseCodeTrendGraphResponseBodyResponseCodes : TeaModel {
            [NameInMap("302Pv")]
            [Validation(Required=false)]
            public long? Code302Pv { get; set; }

            [NameInMap("405Pv")]
            [Validation(Required=false)]
            public long? Code405Pv { get; set; }

            [NameInMap("499Pv")]
            [Validation(Required=false)]
            public long? Code499Pv { get; set; }

            [NameInMap("5xxPv")]
            [Validation(Required=false)]
            public long? Code5xxPv { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

    }

}
