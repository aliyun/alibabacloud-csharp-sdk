// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeStagingIpResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IPV4s")]
        [Validation(Required=false)]
        public DescribeStagingIpResponseBodyIPV4s IPV4s { get; set; }
        public class DescribeStagingIpResponseBodyIPV4s : TeaModel {
            [NameInMap("IPV4")]
            [Validation(Required=false)]
            public List<string> IPV4 { get; set; }
        };

    }

}
