// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The address pools.
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool : TeaModel {
                /// <summary>
                /// The ID of the address pool.
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// The name of the address pool.
                /// </summary>
                [NameInMap("AddrPoolName")]
                [Validation(Required=false)]
                public string AddrPoolName { get; set; }

            }

        }

        /// <summary>
        /// The Domain Name System (DNS) request sources.
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// The code of the parent line. No value is returned if no parent line exists.
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// The group number of the DNS request source.
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// The group name of the DNS request source.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The code of the DNS request source.
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// The name of the DNS request source.
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

                /// <summary>
                /// The state of the line. Valid values:
                /// 
                /// *   **FORBIDDEN**: The line is unavailable.
                /// *   **OPTIONAL**: The line is available.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the global line is recommended.
        /// </summary>
        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

    }

}
