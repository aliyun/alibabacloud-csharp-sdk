// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DescribeDomainNamesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDomainNamesResponseBodyResult Result { get; set; }
        public class DescribeDomainNamesResponseBodyResult : TeaModel {
            [NameInMap("DomainNames")]
            [Validation(Required=false)]
            public List<string> DomainNames { get; set; }
        };

    }

}
