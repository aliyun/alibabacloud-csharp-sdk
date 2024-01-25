// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UnassociateAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the Anycast EIP.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The ID of the endpoint from which you want to disassociate the Anycast EIP.
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// The region where the endpoint is deployed.
        /// </summary>
        [NameInMap("BindInstanceRegionId")]
        [Validation(Required=false)]
        public string BindInstanceRegionId { get; set; }

        /// <summary>
        /// The type of endpoint from which you want to disassociate the Anycast EIP. Valid values:
        /// 
        /// *   **SlbInstance**: an internal-facing Server Load Balancer (SLB) instance that is deployed in a virtual private cloud (VPC)
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
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// The secondary private IP address of the ENI from which you want to disassociate the Anycast EIP.
        /// 
        /// This parameter is valid only when you set **BindInstanceType** to **NetworkInterface**. If you do not specify this parameter, the primary private IP address of the ENI is used.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

    }

}
