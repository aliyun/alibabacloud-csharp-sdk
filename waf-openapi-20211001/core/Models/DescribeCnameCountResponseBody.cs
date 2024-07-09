// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCnameCountResponseBody : TeaModel {
        [NameInMap("CnameCount")]
        [Validation(Required=false)]
        public DescribeCnameCountResponseBodyCnameCount CnameCount { get; set; }
        public class DescribeCnameCountResponseBodyCnameCount : TeaModel {
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public long? Cname { get; set; }

            [NameInMap("HybridCloudCname")]
            [Validation(Required=false)]
            public long? HybridCloudCname { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
