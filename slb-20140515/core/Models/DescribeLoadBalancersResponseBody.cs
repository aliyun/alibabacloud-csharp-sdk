// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// An array of CLB instances.
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public DescribeLoadBalancersResponseBodyLoadBalancers LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer> LoadBalancer { get; set; }
            public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer : TeaModel {
                /// <summary>
                /// The endpoint of the CLB instance.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The IP version that is used by the CLB instance. Valid values: **ipv4** and **ipv6**.
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                /// <summary>
                /// The network type of the CLB instance. Valid values:
                /// 
                /// *   **internet:** After an Internet-facing CLB instance is created, the system assigns a public IP address to the CLB instance. Then, the CLB instance can forward requests over the Internet.
                /// *   **intranet:** After an internal-facing CLB instance is created, the system assigns a private IP address to the CLB instance. Then, the CLB instance can forward requests only over internal networks.
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:
                /// 
                /// *   **-1:** For a pay-by-data-transfer Internet-facing CLB instance, this value is set to -1. This indicates that the bandwidth is unlimited.
                /// *   **1 to 5120:** For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth for each listener. The sum of the maximum bandwidth of all listeners cannot exceed the maximum bandwidth of the CLB instance.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The time when the CLB instance was created. The time follows the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The timestamp when the instance was created.
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// Indicates whether deletion protection is enabled for the CLB instance. Valid values:
                /// 
                /// *   **on:** Deletion protection is enabled.
                /// *   **off:** Deletion protection is disabled.
                /// </summary>
                [NameInMap("DeleteProtection")]
                [Validation(Required=false)]
                public string DeleteProtection { get; set; }

                /// <summary>
                /// The metering method of the CLB instance. Valid values:
                /// 
                /// *   **PayBySpec:** pay-by-specification.
                /// *   **PayByCLCU:** pay-by-LCU.
                /// 
                /// >  This parameter takes effect only for accounts registered on the China site (aliyun.com) and when the **PayType** parameter is set to **PayOnDemand**.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The metering method of the Internet-facing CLB instance. Valid values:
                /// 
                /// *   **3:** pay-by-bandwidth (**paybybandwidth**).
                /// *   **4:** pay-by-data-transfer (**paybytraffic**).
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The metering method of Internet data transfer. Valid values:
                /// 
                /// *   **paybybandwidth:** pay-by-bandwidth.
                /// *   **paybytraffic:** pay-by-data-transfer.
                /// </summary>
                [NameInMap("InternetChargeTypeAlias")]
                [Validation(Required=false)]
                public string InternetChargeTypeAlias { get; set; }

                /// <summary>
                /// The ID of the CLB instance.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The name of the CLB instance.
                /// </summary>
                [NameInMap("LoadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// The specification of the CLB instance.
                /// </summary>
                [NameInMap("LoadBalancerSpec")]
                [Validation(Required=false)]
                public string LoadBalancerSpec { get; set; }

                /// <summary>
                /// The status of the CLB instance. Valid values:
                /// 
                /// *   **inactive:** The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.
                /// *   **active:** The CLB instance runs as expected. By default, newly created CLB instances are in the **active** state.
                /// *   **locked:** The CLB instance is locked.
                /// </summary>
                [NameInMap("LoadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                /// <summary>
                /// The ID of the primary zone to which the CLB instance belongs.
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// The reason why the configuration read-only mode was enabled. The reason must be 1 to 80 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The reason must start with a letter.
                /// 
                /// > This parameter takes effect only when you set the `ModificationProtectionStatus` parameter to **ConsoleProtection**.
                /// </summary>
                [NameInMap("ModificationProtectionReason")]
                [Validation(Required=false)]
                public string ModificationProtectionReason { get; set; }

                /// <summary>
                /// Indicates whether the configuration read-only mode is enabled for the CLB instance. Valid values:
                /// 
                /// *   **NonProtection:** The configuration read-only mode is disabled. In this case, you cannot specify the ModificationProtectionReason parameter. If you specify the `ModificationProtectionReason` parameter, the value is cleared.
                /// *   **ConsoleProtection:** The configuration read-only mode is enabled.
                /// 
                /// >  If you set this parameter to **ConsoleProtection**, you cannot modify the configurations of the CLB instance in the CLB console. However, you can call API operations to modify the configurations of the CLB instance.
                /// </summary>
                [NameInMap("ModificationProtectionStatus")]
                [Validation(Required=false)]
                public string ModificationProtectionStatus { get; set; }

                /// <summary>
                /// The network type of the internal-facing CLB instance. Valid values:
                /// 
                /// *   **vpc:** VPC.
                /// *   **classic:** classic network.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The billing method of the CLB instance.
                /// 
                /// *   **PayOnDemand** is returned, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The ID of the region where the CLB instance was deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The region where the CLB instance was deployed.
                /// </summary>
                [NameInMap("RegionIdAlias")]
                [Validation(Required=false)]
                public string RegionIdAlias { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the secondary zone to which the CLB instance belongs.
                /// </summary>
                [NameInMap("SlaveZoneId")]
                [Validation(Required=false)]
                public string SlaveZoneId { get; set; }

                /// <summary>
                /// The tags of the CLB instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTags Tags { get; set; }
                public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTagsTag> Tag { get; set; }
                    public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the vSwitch to which the internal-facing CLB instance belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC in which the internal-facing CLB instance was deployed.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of instances returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
