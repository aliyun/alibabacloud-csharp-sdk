// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools> AddrPools { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPoolId")]
            [Validation(Required=false)]
            public string AddrPoolId { get; set; }

            [NameInMap("AddrPoolName")]
            [Validation(Required=false)]
            public string AddrPoolName { get; set; }

        }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyLines> Lines { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("FatherCode")]
            [Validation(Required=false)]
            public string FatherCode { get; set; }

            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("LineName")]
            [Validation(Required=false)]
            public string LineName { get; set; }

            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

        }

    }

}
