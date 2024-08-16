// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterRequest : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. The value of **RequestId** of each API request is different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Check items include permissions and the status of the specified cloud resources. Valid values:
        /// 
        /// *   **false** (default): sends the request. If the request passes the check, an Enterprise Edition transit router is created.
        /// *   **true**: checks the request but does not create the Enterprise Edition transit router. If you use this value, the system checks whether the required parameters are set, and whether the request syntax is valid. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Enterprise Edition transit router is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
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
        /// Specifies whether to enable the multicast feature for the Enterprise Edition transit router. Valid values:
        /// 
        /// *   **false** (default): no
        /// *   **true**: yes
        /// 
        /// The multicast feature is supported only in specific regions. You can call [ListTransitRouterAvailableResource](https://help.aliyun.com/document_detail/261356.html) to query the regions that support multicast.
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterRequestTag> Tag { get; set; }
        public class CreateTransitRouterRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// The tag keys cannot be an empty string. The tag key can be up to 64 characters in length. It cannot start with `aliyun` or `acs:` and cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most 20 tag keys in each call.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be an empty string or up to 128 characters in length. It cannot start with `aliyun` or `acs:` and cannot contain `http://` or `https://`.
            /// 
            /// Each key-value must be unique. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The CIDR blocks to be added to the transit router.
        /// </summary>
        [NameInMap("TransitRouterCidrList")]
        [Validation(Required=false)]
        public List<CreateTransitRouterRequestTransitRouterCidrList> TransitRouterCidrList { get; set; }
        public class CreateTransitRouterRequestTransitRouterCidrList : TeaModel {
            /// <summary>
            /// The CIDR block of the transit router.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// The description of the transit router CIDR block.
            /// 
            /// The description must be 1 to 256 characters in length.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the transit router CIDR block.
            /// 
            /// The name must be 1 to 128 characters in length.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Specifies whether to allow the system to automatically add a route that points to the CIDR block to the route table of the transit router.
            /// 
            /// *   **true** (default)
            /// 
            ///     If you set the value to true, after you create a VPN attachment on a private VPN gateway and enable route learning for the VPN attachment, the system automatically adds the following route to the route table of the transit router that is in route learning relationship with the VPN attachment:
            /// 
            ///     A blackhole route whose destination CIDR block is the transit router CIDR block, which refers to the CIDR block from which gateway IP addresses are allocated to the IPsec-VPN connection.
            /// 
            ///     The blackhole route is advertised only to the route tables of virtual border routers (VBRs) connected to the transit router.
            /// 
            /// *   **false**
            /// </summary>
            [NameInMap("PublishCidrRoute")]
            [Validation(Required=false)]
            public bool? PublishCidrRoute { get; set; }

        }

        /// <summary>
        /// The description of the Enterprise Edition transit router instance.
        /// 
        /// The description must be 1 to 256 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.
        /// </summary>
        [NameInMap("TransitRouterDescription")]
        [Validation(Required=false)]
        public string TransitRouterDescription { get; set; }

        /// <summary>
        /// The name of the Enterprise Edition transit router.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.
        /// </summary>
        [NameInMap("TransitRouterName")]
        [Validation(Required=false)]
        public string TransitRouterName { get; set; }

    }

}
