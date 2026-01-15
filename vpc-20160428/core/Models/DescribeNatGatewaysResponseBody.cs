// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the NAT gateway.</para>
        /// </summary>
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public DescribeNatGatewaysResponseBodyNatGateways NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("NatGateway")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGateway> NatGateway { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysNatGateway : TeaModel {
                /// <summary>
                /// <para>Access mode for reverse access to VPC NAT gateway.</para>
                /// </summary>
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayAccessMode AccessMode { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayAccessMode : TeaModel {
                    /// <summary>
                    /// <para>Access mode, with values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>route</b>: Route mode.</description></item>
                    /// <item><description><b>tunnel</b>: Tunnel mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>route</para>
                    /// </summary>
                    [NameInMap("ModeValue")]
                    [Validation(Required=false)]
                    public string ModeValue { get; set; }

                    /// <summary>
                    /// <para>Tunnel mode type:</para>
                    /// <list type="bullet">
                    /// <item><description><b>geneve</b>: Geneve type.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>geneve</para>
                    /// </summary>
                    [NameInMap("TunnelType")]
                    [Validation(Required=false)]
                    public string TunnelType { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether automatic payment is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: no</description></item>
                /// <item><description><b>true</b>: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoPay")]
                [Validation(Required=false)]
                public bool? AutoPay { get; set; }

                /// <summary>
                /// <para>The status of the NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: normal</description></item>
                /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The time when the NAT gateway was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-08T12:20:20Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the deletion protection feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The description of the NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAT</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the traffic monitoring feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EcsMetricEnabled")]
                [Validation(Required=false)]
                public bool? EcsMetricEnabled { get; set; }

                /// <summary>
                /// <para>The mode in which the NAT gateway is associated with an elastic IP address (EIP). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>MULTI_BINDED</b>: multi-EIP-to-ENI mode</description></item>
                /// <item><description><b>NAT</b>: NAT mode, which is compatible with IPv4 addresses.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Note: If you use the NAT mode, the EIP occupies one private IP address on the vSwitch of the NAT gateway. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, the NAT gateway fails to be associated with the EIP. In NAT mode, you can associate a NAT gateway with up to 50 EIPs.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>MULTI_BINDED</para>
                /// </summary>
                [NameInMap("EipBindMode")]
                [Validation(Required=false)]
                public string EipBindMode { get; set; }

                /// <summary>
                /// <para>Whether to enable session logging, with values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Session logging is enabled. </description></item>
                /// <item><description><b>false</b>: Session logging is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSessionLog")]
                [Validation(Required=false)]
                public string EnableSessionLog { get; set; }

                /// <summary>
                /// <para>The time when the NAT gateway expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-26T16:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the DNAT table.</para>
                /// </summary>
                [NameInMap("ForwardTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the FULLNAT table.</para>
                /// </summary>
                [NameInMap("FullNatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds FullNatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds : TeaModel {
                    [NameInMap("FullNatTableId")]
                    [Validation(Required=false)]
                    public List<string> FullNatTableId { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the ICMP non-retrieval feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IcmpReplyEnabled")]
                [Validation(Required=false)]
                public bool? IcmpReplyEnabled { get; set; }

                /// <summary>
                /// <para>The billing method of the NAT gateway. The value is set to <b>PostPaid</b>, which indicates the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The metering method of the NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PayBySpec</b>: pay-by-specification</description></item>
                /// <item><description><b>PayByLcu</b>: pay-by-CU</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByLcu</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The list of elastic IP addresses (EIPs) that are associated with the Internet NAT gateway.</para>
                /// </summary>
                [NameInMap("IpLists")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists IpLists { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists : TeaModel {
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList> IpList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList : TeaModel {
                        /// <summary>
                        /// <para>The ID of the EIP associated with the NAT gateway.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eip-m5egzuvp3dgixen6****</para>
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// <para>The IP address of the EIP associated with the NAT gateway.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>116.62.XX.XX</para>
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        /// <summary>
                        /// <para>The private IP address of the NAT gateway.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.XX.XX</para>
                        /// </summary>
                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                        /// <summary>
                        /// <para>Indicates whether IP addresses that are used in DNAT entries can be specified in SNAT entries. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: yes</description></item>
                        /// <item><description><b>false</b>: no</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("SnatEntryEnabled")]
                        [Validation(Required=false)]
                        public bool? SnatEntryEnabled { get; set; }

                        /// <summary>
                        /// <para>The association between the EIP and the Internet NAT gateway. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>UsedByForwardTable</b>: The EIP is specified in a DNAT entry.</description></item>
                        /// <item><description><b>UsedBySnatTable</b>: The EIP is specified in an SNAT entry.</description></item>
                        /// <item><description><b>UsedByForwardSnatTable</b>: The EIP is specified in both an SNAT entry and a DNAT entry.</description></item>
                        /// <item><description><b>Idle</b>: The EIP is not specified in a DNAT or SNAT entry.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>UsedByForwardTable</para>
                        /// </summary>
                        [NameInMap("UsingStatus")]
                        [Validation(Required=false)]
                        public string UsingStatus { get; set; }

                    }

                }

                /// <summary>
                /// <para>List of NAT IP prefix address segments.</para>
                /// </summary>
                [NameInMap("IpPrefixList")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixList IpPrefixList { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixList : TeaModel {
                    [NameInMap("IpPrefixList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixListIpPrefixList> IpPrefixList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixListIpPrefixList : TeaModel {
                        /// <summary>
                        /// <para>NAT IP prefix address range</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.0.0/28</para>
                        /// </summary>
                        [NameInMap("IpPrefix")]
                        [Validation(Required=false)]
                        public string IpPrefix { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-bp1047e2d4z7kf2ki****</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// <para>The private network information about the enhanced Internet NAT gateway.</para>
                /// <remarks>
                /// <para> If <b>NatType</b> is set to <b>Normal</b>, all parameters returned in this list are empty.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("NatGatewayPrivateInfo")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo NatGatewayPrivateInfo { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo : TeaModel {
                    /// <summary>
                    /// <para>The ID of the elastic network interface (ENI).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eni-m5eg4ozy5st8q3q4****</para>
                    /// </summary>
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public string EniInstanceId { get; set; }

                    /// <summary>
                    /// <para>The mode in which the ENI is associated with the NAT gateway.</para>
                    /// <list type="bullet">
                    /// <item><description><b>indirect</b>: non-cut-through mode</description></item>
                    /// <item><description>If an empty value is returned, it indicates that the cut-through mode is used.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>indirect</para>
                    /// </summary>
                    [NameInMap("EniType")]
                    [Validation(Required=false)]
                    public string EniType { get; set; }

                    /// <summary>
                    /// <para>The zone to which the NAT gateway belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-b</para>
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// <para>The maximum bandwidth. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5120</para>
                    /// </summary>
                    [NameInMap("MaxBandwidth")]
                    [Validation(Required=false)]
                    public int? MaxBandwidth { get; set; }

                    /// <summary>
                    /// <para>The number of new connections to the NAT gateway. Unit: connections per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("MaxSessionEstablishRate")]
                    [Validation(Required=false)]
                    public int? MaxSessionEstablishRate { get; set; }

                    /// <summary>
                    /// <para>The number of concurrent connections to the NAT gateway. Unit: connections.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000000</para>
                    /// </summary>
                    [NameInMap("MaxSessionQuota")]
                    [Validation(Required=false)]
                    public int? MaxSessionQuota { get; set; }

                    /// <summary>
                    /// <para>The private IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.XX.XX</para>
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch to which the NAT gateway belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1s2laxhdf9ayjbo****</para>
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

                /// <summary>
                /// <para>The type of the NAT gateway. The value is set to <b>Enhanced</b> (enhanced NAT gateway).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enhanced</para>
                /// </summary>
                [NameInMap("NatType")]
                [Validation(Required=false)]
                public string NatType { get; set; }

                /// <summary>
                /// <para>The type of NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>internet</b>: an Internet NAT gateway</description></item>
                /// <item><description><b>intranet</b>: a VPC NAT gateway</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>internet</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>Indicates whether the NAT gateway supports PrivateLink. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PrivateLinkEnabled")]
                [Validation(Required=false)]
                public bool? PrivateLinkEnabled { get; set; }

                /// <summary>
                /// <para>The mode that is used by PrivateLink. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FullNat</b>: the FULLNAT mode</description></item>
                /// <item><description><b>Geneve</b>: the GENEVE mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullNat</para>
                /// </summary>
                [NameInMap("PrivateLinkMode")]
                [Validation(Required=false)]
                public string PrivateLinkMode { get; set; }

                /// <summary>
                /// <para>The ID of the region where the NAT gateway is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the contiguous EIP group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the firewall feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: no</description></item>
                /// <item><description><b>true</b>: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SecurityProtectionEnabled")]
                [Validation(Required=false)]
                public bool? SecurityProtectionEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the SNAT table of the NAT gateway.</para>
                /// </summary>
                [NameInMap("SnatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds SnatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds : TeaModel {
                    [NameInMap("SnatTableId")]
                    [Validation(Required=false)]
                    public List<string> SnatTableId { get; set; }

                }

                /// <summary>
                /// <para>The size of the NAT gateway. An empty value is returned for the parameter.</para>
                /// <para>If <b>InternetChargeType</b> is set to <b>PayByLcu</b>, an empty value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Small</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The status of the NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b>: After you send a request to create a NAT gateway, the system creates the NAT gateway in the background. The NAT gateway remains in the Creating state until the operation is completed.</description></item>
                /// <item><description><b>Available</b>: The NAT gateway remains in a stable state after the NAT gateway is created.</description></item>
                /// <item><description><b>Modifying</b>: After you send a request to modify a NAT gateway, the system modifies the NAT gateway in the background. The NAT gateway remains in the Modifying state until the operation is completed.</description></item>
                /// <item><description><b>Deleting</b>: After you send a request to delete a NAT gateway, the system deletes the NAT gateway in the background. The NAT gateway remains in the Deleting state until the operation is completed.</description></item>
                /// <item><description><b>Converting</b>: After you send a request to upgrade a standard NAT gateway to an enhanced NAT gateway, the system upgrades the NAT gateway in the background. The NAT gateway remains in the Converting state until the operation is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags that are added to the resource group.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags Tags { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag> Tag { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KeyTest</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>valueTest</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the VPC where the NAT gateway is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp15zckdt37pq72z****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of NAT gateway entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
