// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipAddressesRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeEipAddressesRequestFilter> Filter { get; set; }
        public class DescribeEipAddressesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key used when querying resources. Set the value to <b>CreationStartTime</b>, which specifies the start time of resource creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used when querying resources. Specify the time in UTC in the <c>YYYY-MM-DDThh:mmZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01T01:00Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the EIP to query. </para>
        /// <para>You can enter up to 50 EIP instance IDs. Separate multiple instance IDs with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both <b>EipAddress</b> and <b>AllocationId</b>, you can enter up to 50 EIP instance IDs for <b>AllocationId</b> and up to 50 EIP addresses for <b>EipAddress</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7ujxscd****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The instance ID of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zebb08phyccdvf****</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the cloud service instance to associate with. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>EcsInstance</b> (default): an ECS instance in a VPC.</description></item>
        /// <item><description><b>SlbInstance</b>: a CLB instance in a VPC.</description></item>
        /// <item><description><b>Nat</b>: a NAT gateway.</description></item>
        /// <item><description><b>HaVip</b>: a high-availability virtual IP address. </description></item>
        /// <item><description><b>NetworkInterface</b>: a secondary elastic network interface (ENI).</description></item>
        /// <item><description><b>IpAddress</b>: an IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can associate only one EIP with each ECS instance, CLB instance, high-availability virtual IP address, or IP address at a time. You can associate multiple EIPs with a NAT gateway. The number of EIPs that can be associated with a secondary ENI depends on the EIP association mode. For more information, see <a href="https://help.aliyun.com/document_detail/72125.html">Overview of EIPs</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a check request and does not query resources. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the check, the corresponding error is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a regular request. If the request passes the check, the HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP to query.</para>
        /// <para>You can enter up to 50 EIP addresses. Separate multiple IP addresses with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both <b>EipAddress</b> and <b>AllocationId</b>, you can enter up to 50 EIP addresses for <b>EipAddress</b> and up to 50 EIP instance IDs for <b>AllocationId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>47.75.XX.XX</para>
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// <para>The name of the EIP.</para>
        /// <para>The name must be 1 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>EIP-01</para>
        /// </summary>
        [NameInMap("EipName")]
        [Validation(Required=false)]
        public string EipName { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP) line. BGP (multi-ISP) EIPs are supported in all regions.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (multi-ISP) Pro line. BGP (multi-ISP) Pro EIPs are supported only in the China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
        /// </list>
        /// <para>For more information about BGP (multi-ISP) and BGP (multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <para>If you are a whitelisted user of single-ISP bandwidth, you can also select the following types:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// <para>If you are an Alibaba Finance Cloud user in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>Specifies whether to include inactive subscription data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): does not include inactive subscription data.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: includes inactive subscription data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The lock type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>financial</b>: locked due to overdue payments.</para>
        /// </description></item>
        /// <item><description><para><b>security</b>: locked due to security reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>financial</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the IP address pool to which the EIP to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pippool-2vc0kxcedhquybdsz****</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the EIP belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4pcdvf****</para>
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
        /// <para>Specifies whether Anti-DDoS (Enhanced) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: disabled.</description></item>
        /// <item><description><b>true</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// <para>The instance ID of the contiguous EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eipsg-t4nr90yik5oy38xdy****</para>
        /// </summary>
        [NameInMap("SegmentInstanceId")]
        [Validation(Required=false)]
        public string SegmentInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a managed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is a managed instance.</description></item>
        /// <item><description><b>false</b>: The instance is not a managed instance.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all instances are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The status of the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Associating</b>: being associated.</para>
        /// </description></item>
        /// <item><description><para><b>Unassociating</b>: being disassociated.</para>
        /// </description></item>
        /// <item><description><para><b>InUse</b>: allocated.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>Releasing</b>: being released.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags used to filter EIPs.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeEipAddressesRequestTag> Tag { get; set; }
        public class DescribeEipAddressesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can enter up to 20 tag keys. If you specify this parameter, it cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can enter up to 20 tag values. If you specify this parameter, it can be an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
