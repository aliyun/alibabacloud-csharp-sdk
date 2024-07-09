// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// The information about the queried zones.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeResolverAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeResolverAvailableZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("AzId")]
            [Validation(Required=false)]
            public string AzId { get; set; }

            /// <summary>
            /// The state of resources in the zone. Valid values:
            /// 
            /// *   NORMAL: The resources are in the normal state.
            /// *   SOLD_OUT: The resources are sold out.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
