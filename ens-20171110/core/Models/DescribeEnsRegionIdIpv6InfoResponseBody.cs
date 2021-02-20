// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdIpv6InfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportIpv6Info")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info SupportIpv6Info { get; set; }
        public class DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info : TeaModel {
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }
            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }
        };

    }

}
