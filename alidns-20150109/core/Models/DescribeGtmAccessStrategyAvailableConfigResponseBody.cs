// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The returned list of address pools.
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
        /// The returned lines of access regions.
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
                /// The code of the parent line for the access region. If no parent line exists, leave this parameter blank.
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// The code of the access region group.
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// The name of the access region group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The code for the line of the access region.
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// The name for the line of the access region.
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

                /// <summary>
                /// The current status of the line. Valid values:
                /// 
                /// - **FORBIDDEN**: Unavailable
                /// - **OPTIONAL**: Availabe
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

    }

}
