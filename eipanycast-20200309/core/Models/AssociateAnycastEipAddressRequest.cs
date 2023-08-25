// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class AssociateAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the Anycast EIP.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The association mode. Valid values:
        /// 
        /// *   **Default**: the default mode. In this mode, cloud resources to be associated are set as default origin servers.
        /// *   **Normal**: the standard mode. In this mode, cloud resources to be associated are set as standard origin servers.
        /// 
        /// > You can associate an Anycast EIP with cloud resources in multiple regions. However, you can set only one cloud resource as the default origin server. Other cloud resources are set as standard origin servers. If you do not specify or add an access point, requests are forwarded to the default origin server.
        /// 
        /// *   If this is your first time to associate an Anycast EIP with a cloud resource, set the value to **Default**.
        /// *   If not, you can also set the value to **Default**, which specifies a new default origin server. In this case, the previous origin server functions as a standard origin server.
        /// </summary>
        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        /// <summary>
        /// The ID of the cloud resource with which you want to associate the Anycast EIP.
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the cloud resource is deployed.
        /// 
        /// You can associate Anycast EIPs only with cloud resources in specific regions. You can call the [DescribeAnycastServerRegions](~~171939~~) operation to query the region IDs.
        /// </summary>
        [NameInMap("BindInstanceRegionId")]
        [Validation(Required=false)]
        public string BindInstanceRegionId { get; set; }

        /// <summary>
        /// The type of cloud resource with which you want to associate the Anycast EIP. Valid values:
        /// 
        /// *   **SlbInstance**: an internal-facing Server Load Balancer (SLB) instance that is deployed in a virtual private cloud (VPC)
        /// *   **NetworkInterface**: an elastic network interface (ENI)
        /// </summary>
        [NameInMap("BindInstanceType")]
        [Validation(Required=false)]
        public string BindInstanceType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck the request. Valid values:
        /// 
        /// *   **true**: prechecks the request. After the request passes the precheck, the Anycast EIP is not associated with the instance. The system checks the required parameters, request syntax, and limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the API request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.
        /// 
        /// If this is your first time to associate an Anycast EIP with a cloud resource, ignore this parameter. The system automatically associates all access areas.
        /// 
        /// You can call the [DescribeAnycastPopLocations](~~171938~~) operation to query information about access points in supported access areas.
        /// </summary>
        [NameInMap("PopLocations")]
        [Validation(Required=false)]
        public List<AssociateAnycastEipAddressRequestPopLocations> PopLocations { get; set; }
        public class AssociateAnycastEipAddressRequestPopLocations : TeaModel {
            /// <summary>
            /// The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.
            /// 
            /// If this is your first time to associate an Anycast EIP with a cloud resource, ignore this parameter. The system automatically associates all access areas.
            /// 
            /// You can call the [DescribeAnycastPopLocations](~~171938~~) operation to query information about access points in supported access areas.
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        /// <summary>
        /// The secondary private IP address of the ENI with which you want to associate the Anycast EIP.
        /// 
        /// This parameter is valid only when you set **BindInstanceType** to **NetworkInterface**. If you do not set this parameter, the primary private IP address of the ENI is used.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

    }

}
