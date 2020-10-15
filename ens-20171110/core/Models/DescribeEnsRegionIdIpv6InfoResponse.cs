// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdIpv6InfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SupportIpv6Info")]
        [Validation(Required=true)]
        public DescribeEnsRegionIdIpv6InfoResponseSupportIpv6Info SupportIpv6Info { get; set; }
        public class DescribeEnsRegionIdIpv6InfoResponseSupportIpv6Info : TeaModel {
            [NameInMap("SupportIpv6")]
            [Validation(Required=true)]
            public bool? SupportIpv6 { get; set; }
            [NameInMap("EnsRegionId")]
            [Validation(Required=true)]
            public string EnsRegionId { get; set; }
        };

    }

}
