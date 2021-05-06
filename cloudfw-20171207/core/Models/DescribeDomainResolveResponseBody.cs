// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDomainResolveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResolveResult")]
        [Validation(Required=false)]
        public DescribeDomainResolveResponseBodyResolveResult ResolveResult { get; set; }
        public class DescribeDomainResolveResponseBodyResolveResult : TeaModel {
            [NameInMap("IpAddrs")]
            [Validation(Required=false)]
            public string IpAddrs { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

    }

}
