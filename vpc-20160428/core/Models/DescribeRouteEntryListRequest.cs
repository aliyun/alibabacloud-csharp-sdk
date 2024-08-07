// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListRequest : TeaModel {
        /// <summary>
        /// The destination CIDR blocks of the routes.
        /// </summary>
        [NameInMap("DestCidrBlockList")]
        [Validation(Required=false)]
        public List<string> DestCidrBlockList { get; set; }

        /// <summary>
        /// The destination CIDR block of the route. IPv4 and IPv6 CIDR blocks are supported.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The IP version. Valid values:
        /// 
        /// *   **IPv4**
        /// *   **IPv6**
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// The ID of the next hop.
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// The next hop type. Valid values:
        /// 
        /// *   **Instance**: an Elastic Compute Service (ECS) instance. This is the default value.
        /// *   **HaVip**: a high-availability virtual IP address (HAVIP).
        /// *   **VpnGateway**: a VPN gateway.
        /// *   **NatGateway**: a NAT gateway.
        /// *   **NetworkInterface**: a secondary elastic network interface (ENI).
        /// *   **RouterInterface**: a router interface.
        /// *   **IPv6Gateway**: an IPv6 gateway.
        /// *   **Attachment**: a transit router.
        /// *   **Ipv4Gateway**: an IPv4 gateway.
        /// *   **GatewayEndpoint**: a gateway endpoint.
        /// *   **CenBasic**: CEN does not support transit routers.
        /// *   **Ecr**: Express Connect Router (ECR).
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the route table.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the route that you want to query.
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// The name of the route entry.
        /// 
        /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// The route type. Valid values:
        /// 
        /// *   **Custom**: custom routes.
        /// *   **System**: system routes.
        /// *   **BGP**: BGP routes.
        /// *   **CEN**: Cloud Enterprise Network (CEN) routes.
        /// *   **ECR**: Express Connect Router (ECR) routes.
        /// </summary>
        [NameInMap("RouteEntryType")]
        [Validation(Required=false)]
        public string RouteEntryType { get; set; }

        /// <summary>
        /// The ID of the route table that you want to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// Specifies whether to host the route. If the parameter is empty, the route is not hosted.
        /// 
        /// Set the value to **TR**, which specifies that the route is hosted by a transit router.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
