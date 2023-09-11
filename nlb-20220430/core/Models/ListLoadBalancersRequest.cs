// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// The protocol version. Valid values:
        /// 
        /// *   **ipv4**: IPv4
        /// *   **DualStack**: dual stack
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// The type of IPv4 address used by the NLB instance. Valid values:
        /// 
        /// *   **Internet**: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
        /// *   **Intranet**: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The domain name of the NLB instance.
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// The type of IPv6 address used by the NLB instance. Valid values:
        /// 
        /// *   **Internet**: a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
        /// *   **Intranet**: a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// The business status of the NLB instance. Valid values:
        /// 
        /// *   **Abnormal**: The NLB instance is not working as expected.
        /// *   **Normal**: The NLB instance is working as expected.
        /// </summary>
        [NameInMap("LoadBalancerBusinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBusinessStatus { get; set; }

        /// <summary>
        /// The ID of the NLB instance. You can query up to 20 NLB instances at a time.
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// The name of the NLB instance. You can specify up to 20 names at a time.
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// The status of the NLB instance. Valid values:
        /// 
        /// *   **Inactive**: The NLB instance is disabled. Listeners of NLB instances in the Inactive state do not forward traffic.
        /// *   **Active**: The NLB instance is running.
        /// *   **Provisioning**: The NLB instance is being created.
        /// *   **Configuring**: The NLB instance is being modified.
        /// *   **Deleting**: The NLB instance is being deleted.
        /// *   **Deleted**: The NLB instance is deleted.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The type of the Server Load Balancer (SLB) instance. Set the value to **network**, which specifies NLB.
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If this is your first query and no subsequent queries are to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region where the NLB instance is deployed.
        /// 
        /// You can call the [DescribeRegions](~~443657~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags of the NLB instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) where the NLB instance is deployed. You can specify up to 10 VPC IDs at a time.
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// The name of the zone. You can call the [DescribeZones](~~443890~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
