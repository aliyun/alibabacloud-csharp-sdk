// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent page exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of IP address pools.</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList> PublicIpAddressPoolList { get; set; }
        public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList : TeaModel {
            /// <summary>
            /// <para>The business type of the IP address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CloudBox</b>: CloudBox. This type is supported only for CloudBox users.</description></item>
            /// <item><description><b>Default</b> (default): Default. This indicates a non-special type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudBox</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The business status of the IP address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>FinancialLocked</b>: Locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T01:37:38Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AddressPoolDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether idle IP addresses are available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IpAddressRemaining")]
            [Validation(Required=false)]
            public bool? IpAddressRemaining { get; set; }

            /// <summary>
            /// <para>The line type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>BGP</b>: BGP (Multi-ISP) line.</para>
            /// </description></item>
            /// <item><description><para><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
            /// <para>If you are a single-ISP bandwidth whitelist user, the following types may also be returned:</para>
            /// <list type="bullet">
            /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
            /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
            /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
            /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
            /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
            /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
            /// </list>
            /// <para>If you are an Alibaba Finance Cloud user in the China (Hangzhou) region, <b>BGP_FinanceCloud</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The name of the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AddressPoolName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the IP address pool belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121012345612*****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The instance ID of the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pippool-6wetvn6fumkgycssx****</para>
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

            /// <summary>
            /// <para>The region ID of the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the IP address pool belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4pcdvf****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security protection level.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is empty, Anti-DDoS Basic is used by default.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to <b>AntiDDoS_Enhanced</b>, Anti-DDoS (Enhanced) is used.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("SecurityProtectionTypes")]
            [Validation(Required=false)]
            public List<string> SecurityProtectionTypes { get; set; }

            /// <summary>
            /// <para>The sharing type of the IP address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Shared</b>: The IP address pool is shared.</description></item>
            /// <item><description>Empty: The IP address pool is not shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The instance status of the IP address pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: available.</description></item>
            /// <item><description><b>Deleting</b>: delete in progress.</description></item>
            /// <item><description><b>Modifying</b>: modify in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags> Tags { get; set; }
            public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The total number of available IP addresses in the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// <para>The number of used IP addresses in the IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UsedIpNum")]
            [Validation(Required=false)]
            public int? UsedIpNum { get; set; }

            /// <summary>
            /// <para>The user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>admin</b>: administrator. Administrators can delete, modify, and query IP address pools, and allocate Elastic IP Addresses (EIPs) to IP address pools.</description></item>
            /// <item><description><b>user</b>: regular user. Regular users can only allocate EIPs to IP address pools and query IP address pools. They cannot modify or delete IP address pools.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            /// <summary>
            /// <para>The zone of the IP address pool.
            /// This parameter is returned only when the business type of the IP address pool is CloudBox.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

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
        /// <para>The total number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
