// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCommonBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Internet Shared Bandwidth instance.</para>
        /// </summary>
        [NameInMap("CommonBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages CommonBandwidthPackages { get; set; }
        public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages : TeaModel {
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage> CommonBandwidthPackage { get; set; }
            public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage : TeaModel {
                /// <summary>
                /// <para>The maximum bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The ID of the Internet Shared Bandwidth instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbwp-bp1t3sm1ffzmshdki****</para>
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// <para>The service type of the Internet Shared Bandwidth instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CloudBox</b> The cloud box. Only cloud box users can select this type.</description></item>
                /// <item><description><b>Default</b> (default): The general service type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CloudBox</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The service status of the Internet Shared Bandwidth instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The Internet Shared Bandwidth instance runs as expected.</description></item>
                /// <item><description><b>FinancialLocked</b>: An overdue payment occurs in the Internet Shared Bandwidth instance</description></item>
                /// <item><description><b>Unactivated</b>: The Internet Shared Bandwidth instance is not activated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The time when the Internet Shared Bandwidth instance was created. The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-06-28T06:39:20Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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
                /// <para>The description of the Internet Shared Bandwidth instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the Internet Shared Bandwidth instance expired. The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-15T03:08:37Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the information about pending orders is returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
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
                /// <item><description><b>BGP</b>: BGP (Multi-ISP) line The BGP (Multi-ISP) line is supported in all regions.</description></item>
                /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line The BGP (Multi-ISP) Pro line is supported in the China (Hong Kong), Singapore (Singapore), Japan (Tokyo), Philippines (Manila), Malaysia (Kuala Lumpur), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
                /// </list>
                /// <para>If you are allowed to use single-ISP bandwidth, one of the following values is returned:</para>
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
                /// <para>The billing method of the Internet Shared Bandwidth instance. Valid value:</para>
                /// <para><b>PostPaid</b>: pay-as-you-go</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The metering method of the Internet Shared Bandwidth instance. Valid value:</para>
                /// <para><b>PayByTraffic</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The name of the Internet Shared Bandwidth instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The elastic IP addresses (EIPs) that are associated with the Internet Shared Bandwidth instance.</para>
                /// </summary>
                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        /// <summary>
                        /// <para>The ID of the EIP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eip-bp13e9i2qst4g6jzi****</para>
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the EIP is associated with the Internet Shared Bandwidth instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>BINDED</b></description></item>
                        /// <item><description><b>BINDING</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BINDED</para>
                        /// </summary>
                        [NameInMap("BandwidthPackageIpRelationStatus")]
                        [Validation(Required=false)]
                        public string BandwidthPackageIpRelationStatus { get; set; }

                        /// <summary>
                        /// <para>The public IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47.95.XX.XX</para>
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                /// <summary>
                /// <para>The percentage of the minimum bandwidth commitment. Only <b>20</b> is returned.</para>
                /// <remarks>
                /// <para> This parameter is supported only on the Alibaba Cloud China site.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public int? Ratio { get; set; }

                /// <summary>
                /// <para>The ID of the region where the Internet Shared Bandwidth instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the renewal took effect. The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-30T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// <para>The new maximum bandwidth after the configurations are changed. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// <para>The metering method after the configurations are changed. Valid value:</para>
                /// <para><b>PayByTraffic</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// <para>The renewal method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RENEWCHANGE</b>: renewal with a specification change</description></item>
                /// <item><description><b>TEMP_UPGRADE</b>: renewal with a temporary upgrade</description></item>
                /// <item><description><b>UPGRADE</b>: renewal with an upgrade</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RENEWCHANGE</para>
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The editions of Anti-DDoS.</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is empty, Anti-DDoS Origin Basic is enabled.</description></item>
                /// <item><description>If <b>AntiDDoS_Enhanced</b> is returned, Anti-DDoS Pro/Premium is enabled.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the resource is created by the service account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The resource is not created by the service account.</description></item>
                /// <item><description><b>1</b>: The resource is created by the service account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                /// <summary>
                /// <para>The status of the Internet Shared Bandwidth instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b>: The Internet Shared Bandwidth instance is available.</description></item>
                /// <item><description><b>Modifying</b>: The Internet Shared Bandwidth instance is being modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag that is added to the Internet Shared Bandwidth instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags Tags { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag> Tag { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key that is added to the Internet Shared Bandwidth instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KeyTest</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value that is added to the Internet Shared Bandwidth instance.</para>
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
                /// <para>The zone of the Internet Shared Bandwidth instance. This parameter is returned only when BizType is set to CloudBox. If BizType is set to Default, an empty value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1-lzdvn-cb</para>
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
        /// <para>20E6FD1C-7321-4DAD-BDFD-EC8769E4AA33</para>
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
