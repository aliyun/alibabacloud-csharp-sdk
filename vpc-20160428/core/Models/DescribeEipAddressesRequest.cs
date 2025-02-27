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
            /// <para>The filter key used to query resources. Set the value to <b>CreationStartTime</b>, which specifies the time when the system started to create the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used to query resources. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01T01:00Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the EIP that you want to query.</para>
        /// <para>You can specify up to 50 EIP IDs. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> If both <b>EipAddress</b> and <b>AllocationId</b> are specified, you can specify up to 50 EIP IDs for <b>AllocationId</b>, and specify up to 50 EIPs for <b>EipAddress</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7ujxscd****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The ID of the instance associated with the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zebb08phyccdvf****</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource with which you want to associate the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EcsInstance</b> (default): an Elastic Compute Service (ECS) instance in a virtual private cloud (VPC).</description></item>
        /// <item><description><b>SlbInstance</b>: a CLB instance in a VPC.</description></item>
        /// <item><description><b>Nat</b>: a NAT gateway.</description></item>
        /// <item><description><b>HaVip</b>: an HAVIP.</description></item>
        /// <item><description><b>NetworkInterface</b>: a secondary ENI.</description></item>
        /// <item><description><b>IpAddress</b>: an IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Each ECS instance, CLB instance, HAVIP, and IP address can be associated with only one EIP. A NAT gateway can be associated with multiple EIPs. The number of EIPs that you can associate with a secondary ENI depends on the association mode. For more information, see <a href="https://help.aliyun.com/document_detail/72125.html">Associate EIPs with and disassociate EIPs from cloud resources</a>.</para>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The EIP that you want to query.</para>
        /// <para>You can specify up to 50 EIPs. Separate multiple EIPs with commas (,).</para>
        /// <remarks>
        /// <para> If both <b>EipAddress</b> and <b>AllocationId</b> are specified, you can specify up to 50 EIPs for <b>EipAddress</b>, and specify up to 50 EIP IDs for <b>AllocationId</b>.</para>
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
        /// <para>The name must be 1 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
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
        /// <item><description><b>BGP</b> (default): Border Gateway Protocol (BGP) (Multi-ISP) lines. All regions support BGP (Multi-ISP) EIPs.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines. Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).</description></item>
        /// </list>
        /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see the <a href="https://help.aliyun.com/document_detail/32321.html">Line types</a> section of the &quot;What is EIP?&quot; topic.</para>
        /// <para>If you are allowed to use single-ISP bandwidth, you can also use one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b></description></item>
        /// <item><description><b>ChinaUnicom</b></description></item>
        /// <item><description><b>ChinaMobile</b></description></item>
        /// <item><description><b>ChinaTelecom_L2</b></description></item>
        /// <item><description><b>ChinaUnicom_L2</b></description></item>
        /// <item><description><b>ChinaMobile_L2</b></description></item>
        /// </list>
        /// <para>If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about pending orders. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The reason why the EIP is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>financial</b>: The EIP is locked due to overdue payments.</description></item>
        /// <item><description><b>security</b>: The EIP is locked for security reasons.</description></item>
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
        /// <para>The number of entries per page. Valid values: 1 to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IP address pool to which the EIP that you want to query belongs.</para>
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
        /// <para>Specifies whether to activate Anti-DDoS Pro/Premium. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the contiguous EIP group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eipsg-t4nr90yik5oy38xdy****</para>
        /// </summary>
        [NameInMap("SegmentInstanceId")]
        [Validation(Required=false)]
        public string SegmentInstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The state of the EIP. Valid values:</para>
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
        /// <para>The tags used to filter EIPs.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeEipAddressesRequestTag> Tag { get; set; }
        public class DescribeEipAddressesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
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
