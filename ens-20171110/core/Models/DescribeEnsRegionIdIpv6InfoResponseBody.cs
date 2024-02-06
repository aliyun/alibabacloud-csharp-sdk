// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdIpv6InfoResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// IPv6 support information.
        /// </summary>
        [NameInMap("SupportIpv6Info")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info SupportIpv6Info { get; set; }
        public class DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// Specifies whether IPv6 is supported. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }

        }

    }

}
