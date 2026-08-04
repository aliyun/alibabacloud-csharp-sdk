// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotasRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by cluster type.</para>
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
        /// <para>Filters the results by labels. Specify labels as key=value pairs, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>official=true,gpu=false</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The layout mode. Valid values: Tree and List.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tree</para>
        /// </summary>
        [NameInMap("LayoutMode")]
        [Validation(Required=false)]
        public string LayoutMode { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values are desc and asc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the results to return. The minimum value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The minimum value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the results by parent quota ID:</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, all quotas within the tenant are returned, including both root and child quotas.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to an empty string, all root quotas are returned.</para>
        /// </description></item>
        /// <item><description><para>If a specific parent quota ID is provided, all child quotas of that parent are returned.</para>
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
        /// <para>A comma-separated list of up to 100 quota IDs to filter the results. Only exact matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm,quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("QuotaIds")]
        [Validation(Required=false)]
        public string QuotaIds { get; set; }

        /// <summary>
        /// <para>Filters the results by quota name. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values are Lingjun, ECS, and ACS. The default value is ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. Valid values:</para>
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
        /// <para>A comma-separated list of quota statuses to filter the results. Only exact matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string Statuses { get; set; }

        /// <summary>
        /// <para>Specifies whether to return detailed information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns detailed information.</para>
        /// </description></item>
        /// <item><description><para>false: Does not return detailed information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>Filters the results by version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

        /// <summary>
        /// <para>A comma-separated list of up to 10 workspace IDs to filter the results. Only exact matching is supported.</para>
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
