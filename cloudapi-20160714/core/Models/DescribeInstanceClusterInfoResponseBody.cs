// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T18:29:27</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The cluster description, which can be up to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v0.0.4</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cluster details.</para>
        /// </summary>
        [NameInMap("InstanceClusterAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute InstanceClusterAttribute { get; set; }
        public class DescribeInstanceClusterInfoResponseBodyInstanceClusterAttribute : TeaModel {
            /// <summary>
            /// <para>The internal CIDR block of the user VPC that can be accessed by the cluster if the cluster consists of VPC integration instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;192.168.1.0/24&quot;,&quot;192.168.0.0/24&quot;]</para>
            /// </summary>
            [NameInMap("ConnectCidrBlocks")]
            [Validation(Required=false)]
            public string ConnectCidrBlocks { get; set; }

            /// <summary>
            /// <para>The ID of the user VPC that is connected to the cluster if the cluster consists of VPC integration instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w3kxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ConnectVpcId")]
            [Validation(Required=false)]
            public string ConnectVpcId { get; set; }

            /// <summary>
            /// <para>Indicates whether outbound IPv6 traffic is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EgressIpv6Enable")]
            [Validation(Required=false)]
            public bool? EgressIpv6Enable { get; set; }

            /// <summary>
            /// <para>The HTTPS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS2_TLS1_0</para>
            /// </summary>
            [NameInMap("HttpsPolicies")]
            [Validation(Required=false)]
            public string HttpsPolicies { get; set; }

            /// <summary>
            /// <para>The ID of the IPv4 access control list (ACL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-t4n8i4rvvp70kcyuoXXXX</para>
            /// </summary>
            [NameInMap("IPV4AclId")]
            [Validation(Required=false)]
            public string IPV4AclId { get; set; }

            /// <summary>
            /// <para>The name of the IPv4 ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-black</para>
            /// </summary>
            [NameInMap("IPV4AclName")]
            [Validation(Required=false)]
            public string IPV4AclName { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv4 access control is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("IPV4AclStatus")]
            [Validation(Required=false)]
            public string IPV4AclStatus { get; set; }

            /// <summary>
            /// <para>The type of the IPv4 ACL.</para>
            /// <list type="bullet">
            /// <item><description>black: blacklist</description></item>
            /// <item><description>white: whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>black</para>
            /// </summary>
            [NameInMap("IPV4AclType")]
            [Validation(Required=false)]
            public string IPV4AclType { get; set; }

            /// <summary>
            /// <para>The ID of the IPv6 ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-t4nevzhwbpe7cup18XXXX</para>
            /// </summary>
            [NameInMap("IPV6AclId")]
            [Validation(Required=false)]
            public string IPV6AclId { get; set; }

            /// <summary>
            /// <para>The name of the IPv6 ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IPV6AclName")]
            [Validation(Required=false)]
            public string IPV6AclName { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 access control is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("IPV6AclStatus")]
            [Validation(Required=false)]
            public string IPV6AclStatus { get; set; }

            /// <summary>
            /// <para>The type of the IPv6 ACL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>black: blacklist</description></item>
            /// <item><description>white: whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>white</para>
            /// </summary>
            [NameInMap("IPV6AclType")]
            [Validation(Required=false)]
            public string IPV6AclType { get; set; }

            /// <summary>
            /// <para>The outbound public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.106.XX.XX</para>
            /// </summary>
            [NameInMap("InternetEgressAddress")]
            [Validation(Required=false)]
            public string InternetEgressAddress { get; set; }

            /// <summary>
            /// <para>The outbound private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX/26</para>
            /// </summary>
            [NameInMap("IntranetEgressAddress")]
            [Validation(Required=false)]
            public string IntranetEgressAddress { get; set; }

            /// <summary>
            /// <para>The custom CIDR block. The configured CIDR block is considered as a private block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.0.0.1</para>
            /// </summary>
            [NameInMap("IntranetSegments")]
            [Validation(Required=false)]
            public string IntranetSegments { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 traffic is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }

            /// <summary>
            /// <para>The ID of the client VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zew2v4vcg78mXXXX</para>
            /// </summary>
            [NameInMap("UserVpcId")]
            [Validation(Required=false)]
            public string UserVpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch of the client VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zecr5r7ao44tslsXXXX</para>
            /// </summary>
            [NameInMap("UserVswitchId")]
            [Validation(Required=false)]
            public string UserVswitchId { get; set; }

            /// <summary>
            /// <para>The VIPs of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC_INTERNET_IPV6</para>
            /// </summary>
            [NameInMap("VipTypeList")]
            [Validation(Required=false)]
            public string VipTypeList { get; set; }

            /// <summary>
            /// <para>Indicates whether a virtual private cloud (VPC) domain name is enabled.</para>
            /// </summary>
            [NameInMap("VpcIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcIntranetEnable { get; set; }

            /// <summary>
            /// <para>The ID of the account to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165438596694XXXX</para>
            /// </summary>
            [NameInMap("VpcOwnerId")]
            [Validation(Required=false)]
            public long? VpcOwnerId { get; set; }

            /// <summary>
            /// <para>Indicates whether self-calling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VpcSlbIntranetEnable")]
            [Validation(Required=false)]
            public bool? VpcSlbIntranetEnable { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigateway-ht-04e41d95e9c1</para>
        /// </summary>
        [NameInMap("InstanceClusterId")]
        [Validation(Required=false)]
        public string InstanceClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceClusterName")]
        [Validation(Required=false)]
        public string InstanceClusterName { get; set; }

        /// <summary>
        /// <para>The cluster status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceClusterStatus")]
        [Validation(Required=false)]
        public string InstanceClusterStatus { get; set; }

        /// <summary>
        /// <para>The cluster type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("InstanceClusterType")]
        [Validation(Required=false)]
        public string InstanceClusterType { get; set; }

        /// <summary>
        /// <para>The cluster version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.5.3.856</para>
        /// </summary>
        [NameInMap("InstanceClusterVersion")]
        [Validation(Required=false)]
        public string InstanceClusterVersion { get; set; }

        /// <summary>
        /// <para>The dedicated instances contained in the cluster.</para>
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
                /// <para>The error message returned if the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance not found.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apigateway-ht-04e41d95e9c1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tf-testacceu-central-1apigatewayinstance8752</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the cluster was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-19 10:40:29 +0800</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
