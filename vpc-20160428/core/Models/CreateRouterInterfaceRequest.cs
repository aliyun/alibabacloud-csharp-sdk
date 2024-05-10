// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouterInterfaceRequest : TeaModel {
        /// <summary>
        /// The ID of the access point to which the VBR belongs.
        /// 
        /// You can call the [DescribeAccessPoints](https://help.aliyun.com/document_detail/36062.html) operation to obtain the IDs of access points.
        /// 
        /// >  This parameter is required if the VBR is connected to an Express Connect circuit.
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **false** (default): The automatic payment is disabled. If you select this option, you must go to the Order Center to complete the payment after an order is generated.
        /// *   **true**: The automatic payment is enabled. Payments are automatically complete after an order is generated.
        /// 
        /// >  This parameter is required if **InstanceChargeType** is set to **PrePaid**.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the router interface.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the VBR that is created in the Fast Link mode is uplinked to the router interface. The Fast Link mode helps automatically connect router interfaces that are created for the VBR and its peer VPC. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only if **RouterType** is set to **VBR** and **OppositeRouterType** is set to **VRouter**.
        /// 
        /// *   If **FastLinkMode** is set to **true**, **Role** must be set to **InitiatingSide**. In this case, **AccessPointId**, **OppositeRouterType**, **OpppsiteRouterId**, and **OppositeInterfaceOwnerId** are required.
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public bool? FastLinkMode { get; set; }

        /// <summary>
        /// The source IP address that is used to perform health checks. The source IP address must be an idle IP address of the local virtual private cloud (VPC).
        /// 
        /// >  You can set this parameter when an Express Connect circuit is used.
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// The destination IP address that is used to perform health checks.
        /// 
        /// >  This parameter is required if you specify **HealthCheckSourceIp**
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// The billing method of the router interface. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the router interface.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the access point to which the peer belongs.
        /// 
        /// >  This parameter is required if the peer router interface is associated with a VBR. The specified value cannot be changed after the router interface is created.
        /// </summary>
        [NameInMap("OppositeAccessPointId")]
        [Validation(Required=false)]
        public string OppositeAccessPointId { get; set; }

        /// <summary>
        /// The ID of the peer router interface.
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the peer router interface belongs.
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the acceptor is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        /// <summary>
        /// The ID of the peer router.
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// The type of router that is associated with the peer router interface. Valid values:
        /// 
        /// *   **VRouter**
        /// *   **VBR**
        /// </summary>
        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription duration. Valid values:
        /// 
        /// *   Valid values when PricingCycle is set to Month: **1 to 9**.
        /// *   Valid values when PricingCycle is set to Year: **1 to 3**.
        /// 
        /// >  This parameter is required if **InstanceChargeType** is set to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The billing cycle of the subscription. Valid values:
        /// 
        /// *   **Month** (default)
        /// *   **Year**
        /// 
        /// >  This parameter is required if **InstanceChargeType** is set to **PrePaid**.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region to which the router interface belongs.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to obtain the region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// For more information about resource group, see [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The role of the router interface. Valid values:
        /// 
        /// *   **InitiatingSide**: requester
        /// *   **AcceptingSide**: acceptor
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The ID of the router that is associated with the router interface.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// The type of router that is associated with the router interface. Valid values:
        /// 
        /// *   **VRouter**
        /// *   **VBR**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// The specification of the router interface and the corresponding bandwidth. Valid values:
        /// 
        /// *   **Mini.2**: 2 Mbit/s
        /// *   **Mini.5**: 5 Mbit/s
        /// *   **Small.1**: 10 Mbit/s
        /// *   **Small.2**: 20 Mbit/s
        /// *   **Small.5**: 50 Mbit/s
        /// *   **Middle.1**: 100 Mbit/s
        /// *   **Middle.2**: 200 Mbit/s
        /// *   **Middle.5**: 500 Mbit/s
        /// *   **Large.1**: 1,000 Mbit/s
        /// *   **Large.2**: 2,000 Mbit/s
        /// *   **Large.5**: 5,000 Mbit/s
        /// *   **Xlarge.1**: 10,000 Mbit/s
        /// 
        /// >  If **Role** is set to **AcceptingSide**, set **Spec** to **Negative**. This indicates that you do not need to specify the specification when you create an acceptor router interface.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The tag to add to the resource.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateRouterInterfaceRequestTags> Tags { get; set; }
        public class CreateRouterInterfaceRequestTags : TeaModel {
            /// <summary>
            /// The tag key to add to the resource. You must enter at least one tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// A tag key can be at most 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
