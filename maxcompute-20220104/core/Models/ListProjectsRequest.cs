// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to list the built-in <b>SYSTEM_CATALOG</b> project. This project provides information such as project metadata and usage history. For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tenant-level-information-schema">Information Schema</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("listSystemCatalog")]
        [Validation(Required=false)]
        public bool? ListSystemCatalog { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting point of the query. The results are returned in alphabetical order, starting from the entry that immediately follows the marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        /// <summary>
        /// <para>The prefix of the resource names to query. For example, if you specify <c>a</c> for this parameter, only resources whose names start with &quot;a&quot; are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The quota name. The system automatically generates this name. To obtain the quota name, log in to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a> and select <b>Workspace</b> &gt; <b>Quota</b> <b>Management</b> from the navigation pane on the left.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_5495***3697</para>
        /// </summary>
        [NameInMap("quotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The quota nickname. To obtain the quota nickname, log in to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a> and select <b>Workspace</b> &gt; <b>Quota</b> <b>Management</b> from the navigation pane on the left.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os_PayAsYouGoQuota</para>
        /// </summary>
        [NameInMap("quotaNickName")]
        [Validation(Required=false)]
        public string QuotaNickName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The instance ID and billing method of the default compute quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;resourceId&quot;: &quot;b7afb7d1-<b><b>-</b></b>-****-c393669c307b&quot;,
        ///       &quot;resourceType&quot;: &quot;PayAsYouGo&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <summary>
        /// <para>The sort field. The only supported value is <c>createdTime</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createdTime</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. This parameter takes effect only when <c>sortBy</c> is specified. Valid values are <c>ASC</c> and <c>DESC</c>. The values are case-insensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("sortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the ID, log in to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a> and select <b>Tenant Management</b> &gt; <b>Tenant Properties</b> from the navigation pane on the left.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5495****3697</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The project type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>managed</b>: a managed project.</para>
        /// </description></item>
        /// <item><description><para><b>external</b>: an external project.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
