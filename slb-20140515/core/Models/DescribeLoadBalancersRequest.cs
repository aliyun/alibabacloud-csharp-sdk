// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersRequest : TeaModel {
        /// <summary>
        /// The IP address that the CLB instance uses to provide services.
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
        /// The metering method of Internet data transfer. Valid values:
        /// 
        /// *   **paybybandwidth:** pay-by-bandwidth.
        /// *   **paybytraffic:** pay-by-data-transfer.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// You can specify up to 10 IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the CLB instance.
        /// 
        /// The name must be 1 to 80 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// 
        /// You can specify up to 10 names. Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The status of the CLB instance. Valid values:
        /// 
        /// *   **inactive:** The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.
        /// *   **active:** The CLB instance runs as expected. By default, newly created CLB instances are in the **active** state.
        /// *   **locked:** The CLB instance is locked. After a CLB instance expires, it is locked for seven days. A locked CLB instance cannot forward traffic and you cannot perform operations on the locked CLB instance. However, other settings such as the IP address are retained.
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
        /// The network type of the internal-facing CLB instance. Valid values:
        /// 
        /// *   **vpc:** VPC.
        /// *   **classic:** classic network.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: **1** to **100**.
        /// 
        /// >  If you specify the **PageSize** parameter, you must also specify the **PageNumber** parameter.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The billing method of the CLB instance. Valid values:
        /// 
        /// *   Set the value to **PayOnDemand**.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the backend server that is added to the CLB instance.
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// The private IP address of the backend server that is added to the CLB instance.
        /// 
        /// You can specify multiple IP addresses. Separate multiple IP addresses with commas (,).
        /// </summary>
        [NameInMap("ServerIntranetAddress")]
        [Validation(Required=false)]
        public string ServerIntranetAddress { get; set; }

        /// <summary>
        /// The ID of the secondary zone to which the CLB instance belongs.
        /// 
        /// CLB instances on Alibaba Finance Cloud do not support cross-zone deployment.
        /// </summary>
        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancersRequestTag> Tag { get; set; }
        public class DescribeLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key must be 1 to 64 characters in length and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be at most 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The tags that are added to the CLB instance. The tags must be key-value pairs that are contained in a JSON dictionary.
        /// 
        /// You can specify up to 10 tags in each call.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the CLB instance belongs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the CLB instance belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
