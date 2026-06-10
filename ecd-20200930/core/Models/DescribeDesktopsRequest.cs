// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. Call <a href="t2167755.xdita#"></a>to list regions that support Elastic Desktop Service (EDS).</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The expiration time for subscription desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The list of authorized users for the desktop. You can specify 1 to 100 users.</para>
        /// <remarks>
        /// <para>Only one user can connect to and use the desktop at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The directory ID. This is the same as the office site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer01</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paged query.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum value: 100.</para>
        /// </description></item>
        /// <item><description><para>Default value: 10</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// <para>The elastic GPU pool ID.</para>
        /// </summary>
        [NameInMap("DesktopStatusList")]
        [Validation(Required=false)]
        public List<string> DesktopStatusList { get; set; }

        /// <summary>
        /// <para>The list of image IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The office site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The list of authorized users to exclude from the desktop. You can specify 1 to 100 users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>Whether to exclude pooled desktops (desktops in a desktop pool).</para>
        /// 
        /// <b>Example:</b>
        /// <para>andy</para>
        /// </summary>
        [NameInMap("ExcludedEndUserId")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserId { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FillResourceGroup")]
        [Validation(Required=false)]
        public bool? FillResourceGroup { get; set; }

        /// <summary>
        /// <para>The management flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterDesktopGroup")]
        [Validation(Required=false)]
        public bool? FilterDesktopGroup { get; set; }

        /// <summary>
        /// <para>The public network bandwidth throttling rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-0bm2iz1v6m6nx****</para>
        /// </summary>
        [NameInMap("GpuInstanceGroupId")]
        [Validation(Required=false)]
        public string GpuInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The cloud computer status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-boyczi8enfyc5****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The list of desktop statuses.</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        [NameInMap("IncludeAutoSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? IncludeAutoSnapshotPolicy { get; set; }

        /// <summary>
        /// <para>Whether to query image version information for the desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoFlag</para>
        /// </summary>
        [NameInMap("ManagementFlag")]
        [Validation(Required=false)]
        public string ManagementFlag { get; set; }

        /// <summary>
        /// <para>The token that starts the next query. An empty NextToken means no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The user name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The desktop policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The desktop pool ID. If you specify <c>DesktopId</c>, this parameter is ignored. If <c>DesktopId</c> is empty, the system uses <c>DesktopGroupId</c> to retrieve all desktop IDs in the pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyDesktopGroup")]
        [Validation(Required=false)]
        public bool? OnlyDesktopGroup { get; set; }

        /// <summary>
        /// <para>The desktop instance type. Call <a href="t2167746.xdita#"></a>to list supported instance types.</para>
        /// </summary>
        [NameInMap("OsTypes")]
        [Validation(Required=false)]
        public List<string> OsTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Whether multiple resources exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method for the desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-all-enabled-policy</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The desktop IDs. You can specify 1 to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The purchase method for the desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The list of tags. Each tag is a key-value pair used to label resources. Use tags to group and manage desktops, making them easier to search and operate on in bulk. For more information, see <a href="t2042630.xdita#"></a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        /// <summary>
        /// <para>The cloud computer pool ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Whether to query enterprise resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4hsvzbbmqdzu3s****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Whether to query only pooled desktops (desktops in a desktop pool).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-hb12mclyne09xw***</para>
        /// </summary>
        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The enterprise resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monthPackage</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The snapshot policy ID.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDesktopsRequestTag> Tag { get; set; }
        public class DescribeDesktopsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. If you specify <c>Tag</c>, then <c>Key</c> is required. The key can be up to 128 characters long. It cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. It cannot consist only of whitespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters long. It cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The desktop name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
