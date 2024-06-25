// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateLoadBalancerZonesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
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
        /// *   **false**: sends the request. If the request passes the check, an HTTP 2xx status code is returned and the operation is performed. This is the default value.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The NLB instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/443657.html) operation to obtain the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The mappings between zones and vSwitches. You can specify at most 10 zones.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerZonesRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerZonesRequestZoneMappings : TeaModel {
            /// <summary>
            /// The ID of the elastic IP address (EIP) or Anycast EIP.
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// The type of the EIP. Valid values:
            /// 
            /// *   **Common**
            /// *   **Anycast**
            /// 
            /// > Anycast EIPs are supported only by NLB instances in the China (Hong Kong) region. This parameter is required when **AddressType** is set to **Internet**.
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// The private IP addresses.
            /// </summary>
            [NameInMap("PrivateIPv4Address")]
            [Validation(Required=false)]
            public string PrivateIPv4Address { get; set; }

            /// <summary>
            /// The ID of the vSwitch in the zone. By default, each zone uses one vSwitch and one subnet.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The zone ID. You can call the [DescribeZones](https://help.aliyun.com/document_detail/443890.html) operation to query the most recent zone list.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
