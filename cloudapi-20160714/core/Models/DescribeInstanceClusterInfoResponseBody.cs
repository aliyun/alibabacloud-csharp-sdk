// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterInfoResponseBody : TeaModel {
        /// <summary>
        /// The time when the cluster was created.
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The cluster description, which can be up to 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The cluster details.
        /// </summary>
        [NameInMap("InstanceClusterAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute InstanceClusterAttribute { get; set; }
        public class DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute : TeaModel {
            /// <summary>
            /// The internal CIDR block of the user VPC that can be accessed by the cluster if the cluster consists of VPC integration instances.
            /// </summary>
            [NameInMap("ConnectCidrBlocks")]
            [Validation(Required=false)]
            public string ConnectCidrBlocks { get; set; }

            /// <summary>
            /// The ID of the user VPC that is connected to the cluster if the cluster consists of VPC integration instances.
            /// </summary>
            [NameInMap("ConnectVpcId")]
            [Validation(Required=false)]
            public string ConnectVpcId { get; set; }

            /// <summary>
            /// Indicates whether outbound IPv6 traffic is supported.
            /// </summary>
            [NameInMap("EgressIpv6Enable")]
            [Validation(Required=false)]
            public bool? EgressIpv6Enable { get; set; }

            /// <summary>
            /// The HTTPS security policy.
            /// </summary>
            [NameInMap("HttpsPolicies")]
            [Validation(Required=false)]
            public string HttpsPolicies { get; set; }

            /// <summary>
            /// The ID of the IPv4 access control list (ACL).
            /// </summary>
            [NameInMap("IPV4AclId")]
            [Validation(Required=false)]
            public string IPV4AclId { get; set; }

            /// <summary>
            /// The name of the IPv4 ACL.
            /// </summary>
            [NameInMap("IPV4AclName")]
            [Validation(Required=false)]
            public string IPV4AclName { get; set; }

            /// <summary>
            /// Indicates whether IPv4 access control is enabled. Valid values:
            /// 
            /// *   on
            /// *   off
            /// </summary>
            [NameInMap("IPV4AclStatus")]
            [Validation(Required=false)]
            public string IPV4AclStatus { get; set; }

            /// <summary>
            /// The type of the IPv4 ACL.
            /// 
            /// *   black: blacklist
            /// *   white: whitelist
            /// </summary>
            [NameInMap("IPV4AclType")]
            [Validation(Required=false)]
            public string IPV4AclType { get; set; }

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
            /// Indicates whether IPv6 access control is enabled. Valid values:
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
            /// The outbound public IP address.
            /// </summary>
            [NameInMap("InternetEgressAddress")]
            [Validation(Required=false)]
            public string InternetEgressAddress { get; set; }

            /// <summary>
            /// The outbound private IP address.
            /// </summary>
            [NameInMap("IntranetEgressAddress")]
            [Validation(Required=false)]
            public string IntranetEgressAddress { get; set; }

            /// <summary>
            /// The custom CIDR block. The configured CIDR block is considered as a private block.
            /// </summary>
            [NameInMap("IntranetSegments")]
            [Validation(Required=false)]
            public string IntranetSegments { get; set; }

            /// <summary>
            /// Indicates whether IPv6 traffic is supported.
            /// </summary>
            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }

            /// <summary>
            /// The ID of the client VPC.
            /// </summary>
            [NameInMap("UserVpcId")]
            [Validation(Required=false)]
            public string UserVpcId { get; set; }

            /// <summary>
            /// The vSwitch of the client VPC.
            /// </summary>
            [NameInMap("UserVswitchId")]
            [Validation(Required=false)]
            public string UserVswitchId { get; set; }

            /// <summary>
            /// The VIPs of the cluster.
            /// </summary>
            [NameInMap("VipTypeList")]
            [Validation(Required=false)]
            public string VipTypeList { get; set; }

            /// <summary>
            /// Indicates whether a virtual private cloud (VPC) domain name is enabled.
            /// </summary>
            [NameInMap("VpcIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcIntranetEnable { get; set; }

            /// <summary>
            /// The ID of the account to which the VPC belongs.
            /// </summary>
            [NameInMap("VpcOwnerId")]
            [Validation(Required=false)]
            public long? VpcOwnerId { get; set; }

            /// <summary>
            /// Indicates whether self-calling is enabled.
            /// </summary>
            [NameInMap("VpcSlbIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcSlbIntranetEnable { get; set; }

        }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("InstanceClusterId")]
        [Validation(Required=false)]
        public string InstanceClusterId { get; set; }

        /// <summary>
        /// The cluster name.
        /// </summary>
        [NameInMap("InstanceClusterName")]
        [Validation(Required=false)]
        public string InstanceClusterName { get; set; }

        /// <summary>
        /// The cluster status.
        /// </summary>
        [NameInMap("InstanceClusterStatus")]
        [Validation(Required=false)]
        public string InstanceClusterStatus { get; set; }

        /// <summary>
        /// The cluster type.
        /// </summary>
        [NameInMap("InstanceClusterType")]
        [Validation(Required=false)]
        public string InstanceClusterType { get; set; }

        /// <summary>
        /// The cluster version.
        /// </summary>
        [NameInMap("InstanceClusterVersion")]
        [Validation(Required=false)]
        public string InstanceClusterVersion { get; set; }

        /// <summary>
        /// The dedicated instances contained in the cluster.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public DescribeInstanceClusterInfoResponseBodyInstanceList InstanceList { get; set; }
        public class DescribeInstanceClusterInfoResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceClusterInfoResponseBodyInstanceListInstance> Instance { get; set; }
            public class DescribeInstanceClusterInfoResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// The error message returned if the call fails.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

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
                /// The instance status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The time when the cluster was last modified.
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
