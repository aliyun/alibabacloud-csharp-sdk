// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnStagingIpResponseBody : TeaModel {
        [NameInMap("IPV4s")]
        [Validation(Required=false)]
        public DescribeDcdnStagingIpResponseBodyIPV4s IPV4s { get; set; }
        public class DescribeDcdnStagingIpResponseBodyIPV4s : TeaModel {
            [NameInMap("IPV4")]
            [Validation(Required=false)]
            public List<string> IPV4 { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
