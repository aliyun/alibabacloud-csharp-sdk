// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RayCluster</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("HasResource")]
        [Validation(Required=false)]
        public string HasResource { get; set; }

        /// <summary>
        /// <para>Filters by label key and value. Separate multiple labels with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>official=true,gpu=false</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The display mode. Valid values: tree or list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tree</para>
        /// </summary>
        [NameInMap("LayoutMode")]
        [Validation(Required=false)]
        public string LayoutMode { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: desc or asc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number to query. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by ParentQuotaId:</para>
        /// <list type="bullet">
        /// <item><description><para>Not specified: lists all quotas under the tenant, including root quotas and child quotas.</para>
        /// </description></item>
        /// <item><description><para>Empty string: lists all root quotas.</para>
        /// </description></item>
        /// <item><description><para>Non-empty string: lists all child quotas of the specified ParentQuotaId.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <para>Comma-separated QuotaIds for filtering. Only exact match is supported. A maximum of 100 IDs can be specified at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm,quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("QuotaIds")]
        [Validation(Required=false)]
        public string QuotaIds { get; set; }

        /// <summary>
        /// <para>Filters by QuotaName. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The resource type of the quota (Lingjun/ECS/ACS). Default value: ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>QuotaName</para>
        /// </description></item>
        /// <item><description><para>Status</para>
        /// </description></item>
        /// <item><description><para>CPU</para>
        /// </description></item>
        /// <item><description><para>Memory</para>
        /// </description></item>
        /// <item><description><para>GPU</para>
        /// </description></item>
        /// <item><description><para>GmtCreatedTime</para>
        /// </description></item>
        /// <item><description><para>GmtModifiedTime</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Comma-separated quota statuses for filtering. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

        /// <summary>
        /// <para>Specifies whether to display details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Displays details.</description></item>
        /// <item><description>false: Does not display details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>Filters by version information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

        /// <summary>
        /// <para>Comma-separated WorkspaceIds for filtering. Only exact match is supported. A maximum of 10 IDs can be specified at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21345,38727</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

        /// <summary>
        /// <para>The name of the associated workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myshellprod</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
