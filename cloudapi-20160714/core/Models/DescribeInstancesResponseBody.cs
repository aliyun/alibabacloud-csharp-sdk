// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instances.</para>
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
                /// <para>The ACL ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-uf6f9zfxfxtp5j9ng3yv4</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>The name of the access control list (ACL).</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

                /// <summary>
                /// <para>Indicates whether the ACL is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                /// <summary>
                /// <para>The ACL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>black: blacklist</description></item>
                /// <item><description>white: whitelist</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>white</para>
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The egress IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.1</para>
                /// </summary>
                [NameInMap("ClassicEgressAddress")]
                [Validation(Required=false)]
                public string ClassicEgressAddress { get; set; }

                /// <summary>
                /// <para>The internal CIDR block of the user\&quot;s VPC that can be accessed if the instance is a VPC integration instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;172.16.0.0/24\&quot;,\&quot;172.16.1.0/24\&quot;]</para>
                /// </summary>
                [NameInMap("ConnectCidrBlocks")]
                [Validation(Required=false)]
                public string ConnectCidrBlocks { get; set; }

                /// <summary>
                /// <para>The ID of the user\&quot;s VPC if the instance is a VPC integration instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5eo7khlb4h4f8y9egsdg</para>
                /// </summary>
                [NameInMap("ConnectVpcId")]
                [Validation(Required=false)]
                public string ConnectVpcId { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-22 15:36:53.0</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The type of the dedicated instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>vpc_connect: VPC integration instance</description></item>
                /// <item><description>normal: conventional dedicated instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc_connect</para>
                /// </summary>
                [NameInMap("DedicatedInstanceType")]
                [Validation(Required=false)]
                public string DedicatedInstanceType { get; set; }

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
                /// <para>The time when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1659801600000</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The HTTPS security policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS2_TLS1_2</para>
                /// </summary>
                [NameInMap("HttpsPolicies")]
                [Validation(Required=false)]
                public string HttpsPolicies { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-124resFfs235</para>
                /// </summary>
                [NameInMap("IPV6AclId")]
                [Validation(Required=false)]
                public string IPV6AclId { get; set; }

                /// <summary>
                /// <para>The name of the IPv6 ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testIPV6</para>
                /// </summary>
                [NameInMap("IPV6AclName")]
                [Validation(Required=false)]
                public string IPV6AclName { get; set; }

                /// <summary>
                /// <para>Indicates whether the IPv6 ACL is enabled. Valid values:</para>
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
                /// <para>black</para>
                /// </summary>
                [NameInMap("IPV6AclType")]
                [Validation(Required=false)]
                public string IPV6AclType { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrePaid: subscription</description></item>
                /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The CIDR block of the dedicated instance.</para>
                /// <list type="bullet">
                /// <item><description>172.16.0.0/12</description></item>
                /// <item><description>192.168.0.0/16</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("InstanceCidrBlock")]
                [Validation(Required=false)]
                public string InstanceCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the cluster to which the dedicated instance cluster belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apigateway-cluster-sh-1523cafbgffd</para>
                /// </summary>
                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-shared-vpc-020</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The requests per second (RPS) limit on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("InstanceRpsLimit")]
                [Validation(Required=false)]
                public int? InstanceRpsLimit { get; set; }

                /// <summary>
                /// <para>The instance specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api.s1.small</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The instance specification details.</para>
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
                        /// <para>The variable name.</para>
                        /// </summary>
                        [NameInMap("LocalName")]
                        [Validation(Required=false)]
                        public string LocalName { get; set; }

                        /// <summary>
                        /// <para>The variable value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2500</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VPC_SHARED: shared instance (VPC)</description></item>
                /// <item><description>VPC_DEDICATED: dedicated instance (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC_SHARED</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The outbound public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.241.89.244</para>
                /// </summary>
                [NameInMap("InternetEgressAddress")]
                [Validation(Required=false)]
                public string InternetEgressAddress { get; set; }

                /// <summary>
                /// <para>The internal CIDR block that is allowed to access the API Gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;172.36.0.0/16\&quot;,\&quot;172.31.16.0/20\&quot;]</para>
                /// </summary>
                [NameInMap("IntranetSegments")]
                [Validation(Required=false)]
                public string IntranetSegments { get; set; }

                /// <summary>
                /// <para>The end time of the maintenance window. The time is in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00Z</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the maintenance window. The time is in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22:00Z</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// <para>The network information of the user\&quot;s VPC if the instance is a VPC integration instance.</para>
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
                        /// <para>The CIDR block of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.17.0/24</para>
                        /// </summary>
                        [NameInMap("CidrBlock")]
                        [Validation(Required=false)]
                        public string CidrBlock { get; set; }

                        /// <summary>
                        /// <para>The security group ID. Services in the same security group can access each other.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-2zeehz13zcyj1kfk3o85</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-2zeqals6rbj51bhjn8b89</para>
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        /// <summary>
                        /// <para>The zone ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shenzhen-d</para>
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
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 traffic is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>The user VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-t<em><b>hx</b></em><em>yu9</em>***t0g4</para>
                /// </summary>
                [NameInMap("UserVpcId")]
                [Validation(Required=false)]
                public string UserVpcId { get; set; }

                /// <summary>
                /// <para>The user vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-t4<em><b>eh</b></em><em>d7q</em>***i2f</para>
                /// </summary>
                [NameInMap("UserVswitchId")]
                [Validation(Required=false)]
                public string UserVswitchId { get; set; }

                /// <summary>
                /// <para>The VPC egress CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.104.254.0/26</para>
                /// </summary>
                [NameInMap("VpcEgressAddress")]
                [Validation(Required=false)]
                public string VpcEgressAddress { get; set; }

                /// <summary>
                /// <para>Indicates whether VPC access is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("VpcIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcIntranetEnable { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the VPC-based instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1408453217640291****</para>
                /// </summary>
                [NameInMap("VpcOwnerId")]
                [Validation(Required=false)]
                public long? VpcOwnerId { get; set; }

                /// <summary>
                /// <para>Indicates whether virtual private cloud (VPC) Server Load Balancer (SLB) is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("VpcSlbIntranetEnable")]
                [Validation(Required=false)]
                public bool? VpcSlbIntranetEnable { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-MAZ5(g,h)</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The zone.</para>
                /// </summary>
                [NameInMap("ZoneLocalName")]
                [Validation(Required=false)]
                public string ZoneLocalName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEB6EC62-B6C7-5082-A45A-45A204724AC2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
