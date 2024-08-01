// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestFilter> Filter { get; set; }
        public class DescribeInstancesRequestFilter : TeaModel {
            /// <summary>
            /// The key of filter 1 used to query resources. Set the value to `CreationStartTime`. You can specify a time by setting both `Filter.1.Key` and `Filter.1.Value` to query resources that were created after the specified time.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of filter 1 used to query resources. Set the value to a time. If you specify this parameter, you must also specify `Filter.1.Key`. Specify the time in the ISO 8601 standard in the `yyyy-MM-ddTHH:mmZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The additional attributes. Valid values of N: 1 to 20. Valid values:
        /// 
        /// *   META_OPTIONS: instance metadata
        /// *   DDH_CLUSTER: dedicated host cluster
        /// *   NETWORK_PRIMARY_ENI_IP: secondary IP address associated with the primary ENI
        /// *   CPU_OPTIONS_TOPOLOGY_TYPE: CPU topology type of the instance
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("DeviceAvailable")]
        [Validation(Required=false)]
        public bool? DeviceAvailable { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including invalid AccessKey pairs, unauthorized RAM users, and missing parameter values. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The elastic IP addresses (EIPs) of instances. This parameter is valid when InstanceNetworkType is set to vpc. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public string EipAddresses { get; set; }

        /// <summary>
        /// The ID of the high-performance computing (HPC) cluster to which the instance belongs.
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// Specifies whether the access channel is enabled for instance metadata. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// 
        /// Default value: enabled.
        /// 
        /// >  For information about instance metadata, see [Access instance metadata](https://help.aliyun.com/document_detail/49122.html).
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Specifies whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:
        /// 
        /// *   optional: The security hardening mode (IMDSv2) is not forcefully used.
        /// *   required: The security hardening mode (IMDSv2) is forcefully used. After you set this parameter to required, you cannot access instance metadata in normal mode.
        /// 
        /// Default value: optional.
        /// 
        /// >  For information about modes of accessing instance metadata, see [Access instance metadata](https://help.aliyun.com/document_detail/150575.html).
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The internal IP addresses of instances located in the classic network. This parameter is valid when InstanceNetworkType is set to classic. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).
        /// </summary>
        [NameInMap("InnerIpAddresses")]
        [Validation(Required=false)]
        public string InnerIpAddresses { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of the instance. The value can be a JSON array that consists of up to 100 instance IDs. Separate the IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The name of the instance. Fuzzy search with asterisk (\\*) wildcard characters is supported.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   classic
        /// *   vpc
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The instance type of the instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The instance family of the instance.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// The billing method for network usage. Valid values:
        /// 
        /// *   PayByBandwidth
        /// *   PayByTraffic
        /// 
        /// >  When the **pay-by-traffic** billing method is used for network usage, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios in which demands exceed resource supplies, the maximum bandwidths may not be reached. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// Specifies whether the instance is an I/O optimized instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public bool? IoOptimized { get; set; }

        /// <summary>
        /// The IPv6 addresses assigned to elastic network interfaces (ENIs).
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// The name of the SSH key pair bound to the instance.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The reason why the instance is locked. Valid values:
        /// 
        /// *   financial: The instance is locked due to overdue payments.
        /// *   security: The instance is locked due to security reasons.
        /// *   recycling: The preemptible instance is locked and pending release.
        /// *   dedicatedhostfinancial: The instance is locked due to overdue payments for the dedicated host.
        /// *   refunded: The instance is locked because a refund is made for the instance.
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value:
        /// 
        /// *   If you do not specify this parameter or if you set this parameter to a value that is smaller than 10, the default value is 10.
        /// *   If you set this parameter to a value that is greater than 100, the default value is 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("NeedSaleCycle")]
        [Validation(Required=false)]
        public bool? NeedSaleCycle { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of `NextToken`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The private IP addresses of instances located in a VPC. This parameter is valid when InstanceNetworkType is set to vpc. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).
        /// </summary>
        [NameInMap("PrivateIpAddresses")]
        [Validation(Required=false)]
        public string PrivateIpAddresses { get; set; }

        /// <summary>
        /// The public IP addresses of instances. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// The remote direct memory access (RDMA) IP addresses of the instance in the HPC cluster.
        /// </summary>
        [NameInMap("RdmaIpAddresses")]
        [Validation(Required=false)]
        public string RdmaIpAddresses { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.
        /// 
        /// >  Resources in the default resource group are displayed in the response regardless of how this parameter is set.
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
        /// The ID of the security group to which the instance belongs.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The status of the instance. Valid values:
        /// 
        /// *   Pending: The instance is being created.
        /// *   Running: The instance is running.
        /// *   Starting: The instance is being started.
        /// *   Stopping: The instance is being stopped.
        /// *   Stopped: The instance is stopped.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the instance. Valid values of N: 1 to 20.
            /// 
            /// If you specify a single tag to query resources, up to 1,000 resources to which the tag is added are returned. If you specify multiple tags to query resources, up to 1,000 resources to which all specified tags are added are returned. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the instance. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
