// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   **Internet**: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.
        /// *   **Intranet**: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the VPC where the ALB instance is deployed.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// The service status of the ALB instance. Valid values:
        /// 
        /// *   **Abnormal**
        /// *   **Normal**
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// The instance IDs. You can specify at most 20 ALB instance IDs.
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// The names of the instances. You can specify at most 10 names.
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// The status of the ALB instance. Valid values:
        /// 
        /// *   **Inactive**: The ALB instance is disabled. The listeners do not forward traffic.
        /// *   **Active**: The ALB instance is running.
        /// *   **Provisioning**: The ALB instance is being created.
        /// *   **Configuring**: The ALB instance is being modified.
        /// *   **CreateFailed**: The system failed to create the ALB instance. In this case, you are not charged for the ALB instance. You can only delete the ALB instance. By default, the system deletes the ALB instances that are in the CreateFailed state within the last day.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The billing method of the ALB instance. Set the value to
        /// 
        /// **PostPay**, which specifies the pay-as-you-go billing method. This is the default value.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags added to the ALB instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the ALB instance belongs. You can specify at most 10 IDs.
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// The ID of the zone where the ALB instance is deployed.
        /// 
        /// You can call the [DescribeZones](~~189196~~) operation to query zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
