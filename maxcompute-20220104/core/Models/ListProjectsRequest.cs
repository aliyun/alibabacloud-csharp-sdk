// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to list the built-in <b>SYSTEM_CATALOG</b> projects that are used to provide data such as project metadata and historical usage data. For more information, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tenant-level-information-schema">Tenant-level Information Schema</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The built-in SYSTEM_CATALOG projects are listed.</description></item>
        /// <item><description>false: The built-in SYSTEM_CATALOG projects are not listed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("listSystemCatalog")]
        [Validation(Required=false)]
        public bool? ListSystemCatalog { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        /// <summary>
        /// <para>Specifies the marker after which the returned list begins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The quota name that is automatically generated. You can log on to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a>, choose <b>Workspace</b> &gt; <b>Quotas</b> from the left-side navigation pane, and then view the quota name on the <b>Quotas</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;hsajkdgbkaubh&quot;</para>
        /// </summary>
        [NameInMap("quotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The quota nickname. You can log on to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a>, choose <b>Workspace</b> &gt; <b>Quotas</b> from the left-side navigation pane, and then view the quota nickname on the <b>Quotas</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaA</para>
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
        /// <para>The instance ID and billing method of the default computing quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;aaaa-bbbb&quot;</para>
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://maxcompute.console.aliyun.com">MaxCompute console</a>, and choose <b>Tenants</b> &gt; <b>Tenant Property</b> from the left-side navigation pane to view the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>549532154333697</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The project type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>managed</b>: internal project</description></item>
        /// <item><description><b>external</b>: external project</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;managed&quot;</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
