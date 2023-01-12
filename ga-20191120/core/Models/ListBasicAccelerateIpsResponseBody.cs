// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAccelerateIpsResponseBody : TeaModel {
        /// <summary>
        /// The accelerated IP addresses of the basic GA instance.
        /// </summary>
        [NameInMap("AccelerateIps")]
        [Validation(Required=false)]
        public List<ListBasicAccelerateIpsResponseBodyAccelerateIps> AccelerateIps { get; set; }
        public class ListBasicAccelerateIpsResponseBodyAccelerateIps : TeaModel {
            /// <summary>
            /// The accelerated IP address of the basic GA instance.
            /// </summary>
            [NameInMap("AccelerateIpAddress")]
            [Validation(Required=false)]
            public string AccelerateIpAddress { get; set; }

            /// <summary>
            /// The ID of the accelerated IP address of the basic GA instance.
            /// </summary>
            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            /// <summary>
            /// The ID of the basic GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The ID of the acceleration region.
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            /// <summary>
            /// The status of the accelerated IP address. Valid values:
            /// 
            /// *   **active**: The accelerated IP address is available.
            /// *   **binding**: The accelerated IP address is being associated.
            /// *   **bound**: The accelerated IP address is associated.
            /// *   **unbinding**: The accelerated IP address is being disassociated.
            /// *   **deleting**: The accelerated IP address is being deleted.
            /// 
            /// >  This parameter is unavailable when the accelerated IP address is being created.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** was not returned, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
