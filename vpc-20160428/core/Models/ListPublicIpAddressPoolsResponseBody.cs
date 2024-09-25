// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The IP address pools.</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolList")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList> PublicIpAddressPoolList { get; set; }
        public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolList : TeaModel {
            /// <summary>
            /// <para>The service type of the IP address pool.</para>
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
            /// <para>The status of the IP address pool.</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>FinancialLocked</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The time when the IP address pool was created. The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
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
            /// <para>Indicates whether idle IP addresses exist.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>BGP</b>: BGP (Multi-ISP)</description></item>
            /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro</description></item>
            /// </list>
            /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
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
            /// <para>121012345612****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the IP address pool.</para>
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
            /// <para>The edition of Anti-DDoS.</para>
            /// <list type="bullet">
            /// <item><description>If you do not set this parameter, Anti-DDoS Origin Basic is used.</description></item>
            /// <item><description>If the value is set to <b>AntiDDoS_Enhanced</b>, Anti-DDoS Pro/Premium is used.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SecurityProtectionTypes")]
            [Validation(Required=false)]
            public List<string> SecurityProtectionTypes { get; set; }

            /// <summary>
            /// <para>The sharing type of the IP address pool.</para>
            /// <list type="bullet">
            /// <item><description>If <b>Shared</b> is returned, the IP address pool is shared.</description></item>
            /// <item><description>If an empty value is returned, the IP address pool is not shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The status of the IP address pool.</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags> Tags { get; set; }
            public class ListPublicIpAddressPoolsResponseBodyPublicIpAddressPoolListTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The total number of available IP addresses in the public IP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalIpNum")]
            [Validation(Required=false)]
            public int? TotalIpNum { get; set; }

            /// <summary>
            /// <para>The number of used IP addresses in the public IP address pool.</para>
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
            /// <item><description><b>admin</b>: An administrator can delete, modify, and query IP address pools, and can assign elastic IP addresses (EIPs) to the pool.</description></item>
            /// <item><description><b>user</b>: A user can only assign EIPs to the IP address pool and query the IP address pool, but cannot modify or delete the IP address pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            /// <summary>
            /// <para>The zone of the IP address pool. This parameter is returned only when the service type of the IP address pool is CloudBox.</para>
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
