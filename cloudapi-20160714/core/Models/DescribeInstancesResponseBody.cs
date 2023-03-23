// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the instances.
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
                /// The ID of the access control policy.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// The name of the access control policy.
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// Indicates whether access control is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                /// <summary>
                /// The type of the access control policy. Valid values:
                /// 
                /// *   black: blacklist
                /// *   white: whitelist
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// The outbound IP address.
                /// </summary>
                [NameInMap("ClassicEgressAddress")]
                [Validation(Required=false)]
                public string ClassicEgressAddress { get; set; }

                [NameInMap("ConnectVpcId")]
                [Validation(Required=false)]
                public string ConnectVpcId { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DedicatedInstanceType")]
                [Validation(Required=false)]
                public string DedicatedInstanceType { get; set; }

                /// <summary>
                /// Indicates whether outbound IPv6 is supported.
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

                [NameInMap("IPV6AclId")]
                [Validation(Required=false)]
                public string IPV6AclId { get; set; }

                [NameInMap("IPV6AclName")]
                [Validation(Required=false)]
                public string IPV6AclName { get; set; }

                [NameInMap("IPV6AclStatus")]
                [Validation(Required=false)]
                public string IPV6AclStatus { get; set; }

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

                [NameInMap("InstanceCidrBlock")]
                [Validation(Required=false)]
                public string InstanceCidrBlock { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The records per second (RPS) limit on the instance.
                /// </summary>
                [NameInMap("InstanceRpsLimit")]
                [Validation(Required=false)]
                public int? InstanceRpsLimit { get; set; }

                /// <summary>
                /// The specifications of the instance.
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// The specifications of the instance.
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
                /// The instance type.
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

                [NameInMap("IntranetSegments")]
                [Validation(Required=false)]
                public string IntranetSegments { get; set; }

                [NameInMap("NetworkInterfaceAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributes NetworkInterfaceAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributes : TeaModel {
                    [NameInMap("NetworkInterfaceAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributesNetworkInterfaceAttribute> NetworkInterfaceAttribute { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceAttributeNetworkInterfaceAttributesNetworkInterfaceAttribute : TeaModel {
                        [NameInMap("CidrBlock")]
                        [Validation(Required=false)]
                        public string CidrBlock { get; set; }

                        [NameInMap("NetworkInterfaceId")]
                        [Validation(Required=false)]
                        public string NetworkInterfaceId { get; set; }

                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The region where the instance is located.
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
                /// Indicates whether IPv6 is supported.
                /// </summary>
                [NameInMap("SupportIpv6")]
                [Validation(Required=false)]
                public bool? SupportIpv6 { get; set; }

                /// <summary>
                /// The ID of the user\"s VPC.
                /// </summary>
                [NameInMap("UserVpcId")]
                [Validation(Required=false)]
                public string UserVpcId { get; set; }

                /// <summary>
                /// The ID of the user interaction machine.
                /// </summary>
                [NameInMap("UserVswitchId")]
                [Validation(Required=false)]
                public string UserVswitchId { get; set; }

                [NameInMap("VipTypeList")]
                [Validation(Required=false)]
                public string VipTypeList { get; set; }

                /// <summary>
                /// The outbound CIDR block of the VPC.
                /// </summary>
                [NameInMap("VpcEgressAddress")]
                [Validation(Required=false)]
                public string VpcEgressAddress { get; set; }

                /// <summary>
                /// Indicates whether VPC is enabled.
                /// </summary>
                [NameInMap("VpcIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcIntranetEnable { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the VPC belongs.
                /// </summary>
                [NameInMap("VpcOwnerId")]
                [Validation(Required=false)]
                public long? VpcOwnerId { get; set; }

                /// <summary>
                /// Indicates whether VPC SLB is enabled.
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
        /// The number of items returned per page.
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
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
