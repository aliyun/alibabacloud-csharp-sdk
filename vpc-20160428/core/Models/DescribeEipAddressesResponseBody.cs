// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the EIPs.</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                /// <summary>
                /// <para>The ID of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-2zeerraiwb7ujcdvf****</para>
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// <para>The time when the EIP was created. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-23T01:37:38Z</para>
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the EIP. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the Internet Shared Bandwidth instance with which the EIP is associated. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("BandwidthPackageBandwidth")]
                [Validation(Required=false)]
                public string BandwidthPackageBandwidth { get; set; }

                /// <summary>
                /// <para>The ID of the Internet Shared Bandwidth instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbwp-bp1ego3i4j07ccdvf****</para>
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// <para>The type of the bandwidth. Only <b>CommonBandwidthPackage</b> may be returned, which indicates Internet Shared Bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CommonBandwidthPackage</para>
                /// </summary>
                [NameInMap("BandwidthPackageType")]
                [Validation(Required=false)]
                public string BandwidthPackageType { get; set; }

                /// <summary>
                /// <para>The service type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CloudBox</b> Only cloud box users can select this type.</description></item>
                /// <item><description><b>Default</b> (default)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CloudBox</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The service status of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>OperationLock</b></description></item>
                /// <item><description><b>Unactivated</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The billing method of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
                /// <item><description><b>PrePaid</b>: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The description of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the EIP when it is not associated with an Internet Shared Bandwidth instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public string EipBandwidth { get; set; }

                /// <summary>
                /// <para>The time when the EIP expires. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-23T02:00:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>Indicates whether fine-grained monitoring is enabled for the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HDMonitorStatus")]
                [Validation(Required=false)]
                public string HDMonitorStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether renewal data is included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b> A value of <b>true</b> is returned only when <b>IncludeReservationData</b> is set to <b>true</b> and some orders have not taken effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// <para>The line type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BGP</b>: BGP (Multi-ISP). The BGP (Multi-ISP) line is supported in all regions.</description></item>
                /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines. BGP (Multi-ISP) Pro line is supported only in the China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
                /// </list>
                /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see the <a href="https://help.aliyun.com/document_detail/32321.html">Line types</a> section of the &quot;What is EIP?&quot; topic.</para>
                /// <para>If you are allowed to use single-ISP bandwidth, one of the following values may be returned:</para>
                /// <list type="bullet">
                /// <item><description><b>ChinaTelecom</b></description></item>
                /// <item><description><b>ChinaUnicom</b></description></item>
                /// <item><description><b>ChinaMobile</b></description></item>
                /// <item><description><b>ChinaTelecom_L2</b></description></item>
                /// <item><description><b>ChinaUnicom_L2</b></description></item>
                /// <item><description><b>ChinaMobile_L2</b></description></item>
                /// </list>
                /// <para>If your services are deployed in China East 1 Finance, <b>BGP_FinanceCloud</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// <para>The ID of the associated instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp15zckdt37cdvf****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region ID of the associated instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("InstanceRegionId")]
                [Validation(Required=false)]
                public string InstanceRegionId { get; set; }

                /// <summary>
                /// <para>The type of the associated instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EcsInstance</b>: an ECS instance in a VPC.</description></item>
                /// <item><description><b>SlbInstance</b>: a CLB instance in a VPC.</description></item>
                /// <item><description><b>Nat</b>: a NAT gateway.</description></item>
                /// <item><description><b>HaVip</b>: an HAVIP.</description></item>
                /// <item><description><b>NetworkInterface</b>: a secondary ENI.</description></item>
                /// <item><description><b>IpAddress</b>: an IP address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EcsInstance</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The metering method of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PayByBandwidth</b></description></item>
                /// <item><description><b>PayByTraffic</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.75.XX.XX</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The association mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NAT</b>: NAT mode</description></item>
                /// <item><description><b>MULTI_BINDED</b>: multi-EIP-to-ENI mode</description></item>
                /// <item><description><b>BINDED</b>: cut-through mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NAT</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The name of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EIP-01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network type. Only <b>public</b> may be returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Netmode")]
                [Validation(Required=false)]
                public string Netmode { get; set; }

                /// <summary>
                /// <para>The details about the locked EIP.</para>
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks OperationLocks { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason : TeaModel {
                        /// <summary>
                        /// <para>The reason why the EIP is locked. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>financial</b>: The EIP is locked due to overdue payments.</description></item>
                        /// <item><description><b>security</b>: The instance is locked for security purposes.</description></item>
                        /// <item><description><b>sharedPool</b>: The shared IP address pool is locked due to overdue payments.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>financial</para>
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The private IP address of the secondary ENI with which the EIP is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The ID of the IP address pool to which the EIP belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pippool-2vc0kxcedhquybdsz****</para>
                /// </summary>
                [NameInMap("PublicIpAddressPoolId")]
                [Validation(Required=false)]
                public string PublicIpAddressPoolId { get; set; }

                /// <summary>
                /// <para>The region ID of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the renewal took effect. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-23T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// <para>The metering method that is used after the renewal takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PayByBandwidth</b></description></item>
                /// <item><description><b>PayByTraffic</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// <para>The type of the renewal order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RENEWCHANGE</b>: renewal with an upgrade or a downgrade.</description></item>
                /// <item><description><b>TEMP_UPGRADE</b>: temporary upgrade.</description></item>
                /// <item><description><b>UPGRADE</b>: upgrade.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RENEWCHANGE</para>
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazcdxs****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether level-2 throttling is configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SecondLimited")]
                [Validation(Required=false)]
                public bool? SecondLimited { get; set; }

                /// <summary>
                /// <para>The edition of Anti-DDoS.</para>
                /// <list type="bullet">
                /// <item><description>If an empty value is returned, it indicates that Anti-DDoS Origin Basic is used.</description></item>
                /// <item><description>If <b>AntiDDoS_Enhanced</b> is returned, it indicates that Anti-DDoS Pro/Premium is used.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the contiguous EIP group.</para>
                /// <para>This value is returned only when you query contiguous EIPs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eipsg-t4nr90yik5oy38xd****</para>
                /// </summary>
                [NameInMap("SegmentInstanceId")]
                [Validation(Required=false)]
                public string SegmentInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the service provider to which the managed instance belongs.</para>
                /// <remarks>
                /// <para>This is only valid when the ServiceManaged parameter is set to True.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>197*************</para>
                /// </summary>
                [NameInMap("ServiceID")]
                [Validation(Required=false)]
                public long? ServiceID { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                /// <summary>
                /// <para>The status of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Associating</b></description></item>
                /// <item><description><b>Unassociating</b></description></item>
                /// <item><description><b>InUse</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Releasing</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the EIP.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the EIP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KeyTest</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the EIP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ValueTest</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the VPC in which an IPv4 gateway is created and that is deployed in the same region as the EIP.</para>
                /// <para>When you associate an EIP with an IP address, the system can enable the IP address to access the Internet based on VPC route configurations.</para>
                /// <remarks>
                /// <para> This parameter is returned if the value of <b>InstanceType</b> is <b>IpAddress</b>. In this case, the EIP is associated with an IP address.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp15zckdt37pq72zv****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone of the EIP.</para>
                /// <para>This parameter is returned only when the service type is CloudBox.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
