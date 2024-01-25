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
        /// *   **Default**: the default mode. In this mode, the endpoint to be associated serves as the default origin server.
        /// *   **Normal**: the standard mode. In this mode, the endpoint to be associated serves as a standard origin server.
        /// 
        /// > You can associate endpoints in multiple regions with an Anycast EIP. However, only one endpoint can serve as the default origin server. Others serve as standard origin servers. If you do not specify or add an access point, requests are forwarded to the default origin server.\
        /// 
        /// 
        /// *   If this is your first time to associate an Anycast EIP with an endpoint, set the value to **Default**.
        /// *   If not, you can also set the value to **Default**, which specifies a new default origin server. In this case, the previous origin server functions as a standard origin server.
        /// </summary>
        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        /// <summary>
        /// The ID of the endpoint with which you want to associate the Anycast EIP.
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the endpoint is deployed.
        /// 
        /// You can associate Anycast EIPs only with endpoints in specific regions. You can call the [DescribeAnycastServerRegions](~~171939~~) operation to query the region IDs.
        /// </summary>
        [NameInMap("BindInstanceRegionId")]
        [Validation(Required=false)]
        public string BindInstanceRegionId { get; set; }

        /// <summary>
        /// The type of endpoint with which you want to associate the Anycast EIP. Valid values:
        /// 
        /// *   **SlbInstance**: internal-facing Server Load Balancer (SLB) instance that is deployed in a virtual private cloud (VPC)
        /// *   **NetworkInterface**: elastic network interface (ENI)
        /// </summary>
        [NameInMap("BindInstanceType")]
        [Validation(Required=false)]
        public string BindInstanceType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The information about the access points in associated access areas when you associate an Anycast EIP with an endpoint.
        /// 
        /// If this is your first time to associate an Anycast EIP with an endpoint, ignore this parameter. The system automatically associates all access areas.
        /// 
        /// You can call the [DescribeAnycastPopLocations](~~171938~~) operation to query information about access points in supported access areas.
        /// </summary>
        [NameInMap("PopLocations")]
        [Validation(Required=false)]
        public List<AssociateAnycastEipAddressRequestPopLocations> PopLocations { get; set; }
        public class AssociateAnycastEipAddressRequestPopLocations : TeaModel {
            /// <summary>
            /// The information about the access points in associated access areas when you associate an Anycast EIP with an endpoint.
            /// 
            /// If this is your first time to associate an Anycast EIP with an endpoint, ignore this parameter. The system automatically associates all access areas.
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
