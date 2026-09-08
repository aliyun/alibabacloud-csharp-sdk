// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The accelerator type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CPU</description></item>
        /// <item><description>GPU</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates all types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("AvailabilityZone")]
        [Validation(Required=false)]
        public string AvailabilityZone { get; set; }

        [NameInMap("CliqueID")]
        [Validation(Required=false)]
        public string CliqueID { get; set; }

        [NameInMap("DiskPL")]
        [Validation(Required=false)]
        public string DiskPL { get; set; }

        /// <summary>
        /// <para>Used together with ResourceGroupIds to display nodes in the resource groups that are bound to the specified quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("FilterByQuotaId")]
        [Validation(Required=false)]
        public string FilterByQuotaId { get; set; }

        /// <summary>
        /// <para>Used together with QuotaId to display nodes in the quota that belong to the specified resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("FilterByResourceGroupIds")]
        [Validation(Required=false)]
        public string FilterByResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The GPU type. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T4</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The number of healthy nodes.</para>
        /// </summary>
        [NameInMap("HealthCount")]
        [Validation(Required=false)]
        public string HealthCountShrink { get; set; }

        /// <summary>
        /// <para>The health rate of nodes (the proportion of healthy nodes).</para>
        /// </summary>
        [NameInMap("HealthRate")]
        [Validation(Required=false)]
        public string HealthRateShrink { get; set; }

        [NameInMap("HyperNode")]
        [Validation(Required=false)]
        public string HyperNode { get; set; }

        [NameInMap("HyperZone")]
        [Validation(Required=false)]
        public string HyperZone { get; set; }

        /// <summary>
        /// <para>The layout mode.</para>
        /// </summary>
        [NameInMap("LayoutMode")]
        [Validation(Required=false)]
        public string LayoutMode { get; set; }

        [NameInMap("MachineGroupIds")]
        [Validation(Required=false)]
        public string MachineGroupIds { get; set; }

        /// <summary>
        /// <para>The node names to display, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        /// <summary>
        /// <para>The node statuses, separated by commas. If this parameter is not specified, nodes in all statuses are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public string NodeStatuses { get; set; }

        /// <summary>
        /// <para>The resource node specifications, separated by commas. If this parameter is not configured, nodes of all node specifications are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.xlarge</para>
        /// </summary>
        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public string NodeTypes { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: Descending order.</description></item>
        /// <item><description>asc: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The order ID information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260590501560397</para>
        /// </summary>
        [NameInMap("OrderInstanceIds")]
        [Validation(Required=false)]
        public string OrderInstanceIds { get; set; }

        /// <summary>
        /// <para>The order statuses of the nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatuses")]
        [Validation(Required=false)]
        public string OrderStatuses { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("PodNum")]
        [Validation(Required=false)]
        public int? PodNum { get; set; }

        /// <summary>
        /// <para>The resource quota ID to which the node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("ReasonCodes")]
        [Validation(Required=false)]
        public string ReasonCodes { get; set; }

        /// <summary>
        /// <para>The IDs of resource groups, separated by commas. Either this parameter or QuotaId is required.</para>
        /// <para>Constraints:</para>
        /// <ol>
        /// <item><description>The UserId of the specified ResourceGroupId must match the UserId of the request.</description></item>
        /// <item><description>The specified resource groups must be of the same type.</description></item>
        /// <item><description>The specified resource groups must be associated with the same VPC at this stage.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The field used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to return resource usage information. This parameter takes effect only when QuotaId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public int? WorkloadNum { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
