// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool : TeaModel {
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                [NameInMap("AddrPoolName")]
                [Validation(Required=false)]
                public string AddrPoolName { get; set; }

            }

        }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine : TeaModel {
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
