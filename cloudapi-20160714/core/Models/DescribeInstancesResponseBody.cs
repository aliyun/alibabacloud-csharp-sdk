// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("InstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstanceAttribute> InstanceAttribute { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstanceAttribute : TeaModel {
                /// <summary>
                /// The ACL ID.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// The name of the access control list (ACL).
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// Indicates whether the ACL is enabled. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                /// <summary>
                /// The ACL type. Valid values:
                /// 
                /// *   black: blacklist
                /// *   white: whitelist
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// The egress IP address.
                /// </summary>
                [NameInMap("ClassicEgressAddress")]
                [Validation(Required=false)]
                public string ClassicEgressAddress { get; set; }

                /// <summary>
                /// The internal CIDR block of the user\\"s VPC that can be accessed if the instance is a VPC integration instance.
                /// </summary>
                [NameInMap("ConnectCidrBlocks")]
                [Validation(Required=false)]
                public string ConnectCidrBlocks { get; set; }

                /// <summary>
                /// The ID of the user\\"s VPC if the instance is a VPC integration instance.
                /// </summary>
                [NameInMap("ConnectVpcId")]
                [Validation(Required=false)]
                public string ConnectVpcId { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The type of the dedicated instance. Valid values:
                /// 
                /// *   vpc_connect: VPC integration instance
                /// *   normal: conventional dedicated instance
                /// </summary>
                [NameInMap("DedicatedInstanceType")]
                [Validation(Required=false)]
                public string DedicatedInstanceType { get; set; }

                /// <summary>
                /// Indicates whether outbound IPv6 traffic is supported.
                /// </summary>
                [NameInMap("EgressIpv6Enable")]
                [Validation(Required=false)]
                public bool? EgressIpv6Enable { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The HTTPS security policy.
                /// </summary>
                [NameInMap("HttpsPolicies")]
                [Validation(Required=false)]
                public string HttpsPolicies { get; set; }

                /// <summary>
                /// The ID of the IPv6 ACL.
                /// </summary>
                [NameInMap("IPV6AclId")]
                [Validation(Required=false)]
                public string IPV6AclId { get; set; }

                /// <summary>
                /// The name of the IPv6 ACL.
                /// </summary>
                [NameInMap("IPV6AclName")]
                [Validation(Required=false)]
                public string IPV6AclName { get; set; }

                /// <summary>
                /// Indicates whether the IPv6 ACL is enabled. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("IPV6AclStatus")]
                [Validation(Required=false)]
                public string IPV6AclStatus { get; set; }

                /// <summary>
                /// The type of the IPv6 ACL. Valid values:
                /// 
                /// *   black: blacklist
                /// *   white: whitelist
                /// </summary>
                [NameInMap("IPV6AclType")]
                [Validation(Required=false)]
                public string IPV6AclType { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   PrePaid: subscription
                /// *   PayAsYouGo: pay-as-you-go
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The CIDR block of the dedicated instance.
                /// 
                /// *   172.16.0.0/12
                /// *   192.168.0.0/16
                /// </summary>
                [NameInMap("InstanceCidrBlock")]
                [Validation(Required=false)]
                public string InstanceCidrBlock { get; set; }

                /// <summary>
                /// The ID of the cluster to which the dedicated instance cluster belongs.
                /// </summary>
                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The requests per second (RPS) limit on the instance.
                /// </summary>
                [NameInMap("InstanceRpsLimit")]
                [Validation(Required=false)]
                public int? InstanceRpsLimit { get; set; }

                /// <summary>
                /// The instance specification.
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// The instance specification details.
                /// </summary>
                [NameInMap("InstanceSpecAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributes InstanceSpecAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributes : TeaModel {
                    [NameInMap("SpecAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributesSpecAttribute> SpecAttribute { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceAttributeInstanceSpecAttributesSpecAttribute : TeaModel {
                        /// <summary>
                        /// The variable name.
                        /// </summary>
                        [NameInMap("LocalName")]
                        [Validation(Required=false)]
                        public string LocalName { get; set; }

                        /// <summary>
                        /// The variable value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The instance type. Valid values:
                /// 
                /// *   VPC_SHARED: shared instance (VPC)
                /// *   VPC_DEDICATED: dedicated instance (VPC)
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The outbound public IP address.
                /// </summary>
                [NameInMap("InternetEgressAddress")]
                [Validation(Required=false)]
                public string InternetEgressAddress { get; set; }

                /// <summary>
                /// The internal CIDR block that is allowed to access the API Gateway instance.
                /// </summary>
                [NameInMap("IntranetSegments")]
                [Validation(Required=false)]
                public string IntranetSegments { get; set; }

                /// <summary>
                /// The end time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// The start time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// The network information of the user\\"s VPC if the instance is a VPC integration instance.
                /// </summary>
                [NameInMap("NetworkInterfaceAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributes NetworkInterfaceAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributes : TeaModel {
                    [NameInMap("NetworkInterfaceAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributesNetworkInterfaceAttribute> NetworkInterfaceAttribute { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributesNetworkInterfaceAttribute : TeaModel {
                        /// <summary>
                        /// The CIDR block of the vSwitch.
                        /// </summary>
                        [NameInMap("CidrBlock")]
                        [Validation(Required=false)]
                        public string CidrBlock { get; set; }

                        /// <summary>
                        /// The security group ID. Services in the same security group can access each other.
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// The vSwitch ID.
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        /// <summary>
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("PrivateDnsList")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributePrivateDnsList PrivateDnsList { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributePrivateDnsList : TeaModel {
                    [NameInMap("PrivateDns")]
                    [Validation(Required=false)]
                    public List<string> PrivateDns { get; set; }

                }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The instance status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether IPv6 traffic is supported.
                /// </summary>
                [NameInMap("SupportIpv6")]
                [Validation(Required=false)]
                public bool? SupportIpv6 { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributeTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceAttributeTagsTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The user VPC ID.
                /// </summary>
                [NameInMap("UserVpcId")]
                [Validation(Required=false)]
                public string UserVpcId { get; set; }

                /// <summary>
                /// The user vSwitch ID.
                /// </summary>
                [NameInMap("UserVswitchId")]
                [Validation(Required=false)]
                public string UserVswitchId { get; set; }

                /// <summary>
                /// The VPC egress CIDR block.
                /// </summary>
                [NameInMap("VpcEgressAddress")]
                [Validation(Required=false)]
                public string VpcEgressAddress { get; set; }

                /// <summary>
                /// Indicates whether VPC access is enabled.
                /// </summary>
                [NameInMap("VpcIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcIntranetEnable { get; set; }

                /// <summary>
                /// The ID of the account to which the VPC-based instance belongs.
                /// </summary>
                [NameInMap("VpcOwnerId")]
                [Validation(Required=false)]
                public long? VpcOwnerId { get; set; }

                /// <summary>
                /// Indicates whether virtual private cloud (VPC) Server Load Balancer (SLB) is enabled.
                /// </summary>
                [NameInMap("VpcSlbIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcSlbIntranetEnable { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The zone.
                /// </summary>
                [NameInMap("ZoneLocalName")]
                [Validation(Required=false)]
                public string ZoneLocalName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
