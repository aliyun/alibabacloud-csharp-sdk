// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpv6EgressOnlyRuleRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of RequestId as the client token. The value of RequestId is different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the egress-only rule.
        /// 
        /// The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the IPv6 address for which you want to create an egress-only rule.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the instance for which you want to create an egress-only rule.
        /// 
        /// Default value: **Ipv6Address**
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The ID of the IPv6 gateway.
        /// </summary>
        [NameInMap("Ipv6GatewayId")]
        [Validation(Required=false)]
        public string Ipv6GatewayId { get; set; }

        /// <summary>
        /// The name of the egress-only rule.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the IPv6 gateway is deployed.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
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

    }

}
