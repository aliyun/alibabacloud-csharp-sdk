// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetIpv4GatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The name of the IPv4 gateway.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The ID of the route table associated with the IPv4 gateway.
        /// </summary>
        [NameInMap("Ipv4GatewayDescription")]
        [Validation(Required=false)]
        public string Ipv4GatewayDescription { get; set; }

        /// <summary>
        /// The description of the IPv4 gateway.
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the IPv4 gateway belongs.
        /// </summary>
        [NameInMap("Ipv4GatewayName")]
        [Validation(Required=false)]
        public string Ipv4GatewayName { get; set; }

        /// <summary>
        /// The time when the IPv4 gateway was created.
        /// </summary>
        [NameInMap("Ipv4GatewayRouteTableId")]
        [Validation(Required=false)]
        public string Ipv4GatewayRouteTableId { get; set; }

        /// <summary>
        /// Indicates whether the IPv4 gateway is activated. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag key.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tag value.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetIpv4GatewayAttributeResponseBodyTags> Tags { get; set; }
        public class GetIpv4GatewayAttributeResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the IPv4 gateway.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
