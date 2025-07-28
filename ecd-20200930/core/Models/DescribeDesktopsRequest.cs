// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the cloud computer.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Postpaid (default): pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer pool. If you specify <c>OnlyDesktopGroup</c>, ignore <c>DesktopGroupId</c>. If you leave <c>DesktopId</c> empty, all IDs of the cloud computers in the cloud computer pool are queried.````</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The cloud computer IDs. You can specify the IDs of 1 to 100 cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The cloud computer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesktopName</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The cloud computer status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Stopped</description></item>
        /// <item><description>Starting</description></item>
        /// <item><description>Rebuilding</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Expired</description></item>
        /// <item><description>Deleted</description></item>
        /// <item><description>Pending</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// <para>The list of cloud computer status.</para>
        /// </summary>
        [NameInMap("DesktopStatusList")]
        [Validation(Required=false)]
        public List<string> DesktopStatusList { get; set; }

        /// <summary>
        /// <para>The cloud computer type. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the IDs of all supported types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The directory ID, which is the same as the office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The authorized users of the cloud computer. You can specify the IDs of 1 to 100 users.</para>
        /// <remarks>
        /// <para> During a specific period of time, only one user can connect to and use the cloud computer.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The list of authorized users that you want to exclude from the cloud computer. You can specify the IDs of 1 to 100 users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>andy</para>
        /// </summary>
        [NameInMap("ExcludedEndUserId")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserId { get; set; }

        /// <summary>
        /// <para>The time when a subscription cloud computer expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the information about the enterprise resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FillResourceGroup")]
        [Validation(Required=false)]
        public bool? FillResourceGroup { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude pooled cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterDesktopGroup")]
        [Validation(Required=false)]
        public bool? FilterDesktopGroup { get; set; }

        /// <summary>
        /// <para>The ID of the elastic GPU pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-0bm2iz1v6m6nx****</para>
        /// </summary>
        [NameInMap("GpuInstanceGroupId")]
        [Validation(Required=false)]
        public string GpuInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-boyczi8enfyc5****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        [NameInMap("IncludeAutoSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? IncludeAutoSnapshotPolicy { get; set; }

        /// <summary>
        /// <para>The flag that is used to manage the cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoFlag</para>
        /// </summary>
        [NameInMap("ManagementFlag")]
        [Validation(Required=false)]
        public string ManagementFlag { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100</description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether the shared group is a multi-cloud computer type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: a multi-cloud computer type.</description></item>
        /// <item><description>false: a single-cloud computer type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is left empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The office network name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query pooled cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyDesktopGroup")]
        [Validation(Required=false)]
        public bool? OnlyDesktopGroup { get; set; }

        /// <summary>
        /// <para>The operating systems (OSs).</para>
        /// </summary>
        [NameInMap("OsTypes")]
        [Validation(Required=false)]
        public List<string> OsTypes { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-all-enabled-policy</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The protocol.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDX: High-definition Experience (HDX) protocol</description></item>
        /// <item><description>ASP: in-house Adaptive Streaming Protocol (ASP) (recommended)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The ID of the network throttling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the image update information about the cloud computer.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service (EDS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4hsvzbbmqdzu3s****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-hb12mclyne09xw***</para>
        /// </summary>
        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud computer.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>duration: hourly plan (available for users in the whitelist)</description></item>
        /// <item><description>postPaid: pay-as-you-go</description></item>
        /// <item><description>monthPackage: monthly subscription (120-hour or 250-hour computing plan)</description></item>
        /// <item><description>prePaid: monthly subscription (unlimited-hour computing plan)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>monthPackage</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the cloud computer. A tag is a key-value pair that consists of a tag key and a tag value. Tags are used to identify resources. You can use tags to manage cloud computers by group. This facilitates search and batch operations. For more information, see <a href="https://help.aliyun.com/document_detail/203781.html">Use tags to manage cloud computers</a>.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDesktopsRequestTag> Tag { get; set; }
        public class DescribeDesktopsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. If you specify the <c>Tag</c> parameter, you must also specify the <c>Key</c> parameter. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c> and contain only spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
