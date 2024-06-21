// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointZonesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next requests are performed.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListVpcEndpointZonesResponseBodyZones> Zones { get; set; }
        public class ListVpcEndpointZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// The ID of the endpoint ENI.
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// The IP address of the endpoint ENI.
            /// </summary>
            [NameInMap("EniIp")]
            [Validation(Required=false)]
            public string EniIp { get; set; }

            /// <summary>
            /// The region ID of the endpoint.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the vSwitch in the zone. The system automatically creates an endpoint elastic network interface (ENI) in the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The domain name of the zone.
            /// 
            /// After the endpoint in the zone is connected to the endpoint service, you can access the service resources of the endpoint service by using the domain name of the zone.
            /// </summary>
            [NameInMap("ZoneDomain")]
            [Validation(Required=false)]
            public string ZoneDomain { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// Indicates whether the endpoint service supports IPv6. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("ZoneIpv6Address")]
            [Validation(Required=false)]
            public string ZoneIpv6Address { get; set; }

            /// <summary>
            /// The state of the zone. Valid values:
            /// 
            /// *   **Creating**: The zone is being created.
            /// *   **Wait**: The zone is to be connected.
            /// *   **Connected**: The zone is connected.
            /// *   **Deleting**: The zone is being deleted.
            /// *   **Disconnecting**: The zone is being disconnected.
            /// *   **Disconnected**: The zone is disconnected.
            /// *   **Connecting**: The zone is being connected.
            /// </summary>
            [NameInMap("ZoneStatus")]
            [Validation(Required=false)]
            public string ZoneStatus { get; set; }

        }

    }

}
