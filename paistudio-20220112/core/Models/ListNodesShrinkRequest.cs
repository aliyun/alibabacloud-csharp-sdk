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
        /// <item><description><para>CPU</para>
        /// </description></item>
        /// <item><description><para>GPU</para>
        /// </description></item>
        /// </list>
        /// <para>If omitted, this operation returns nodes of all accelerator types.</para>
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
        /// <para>When used with <c>ResourceGroupIds</c>, this parameter further filters the results to include only nodes from the specified resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("FilterByQuotaId")]
        [Validation(Required=false)]
        public string FilterByQuotaId { get; set; }

        /// <summary>
        /// <para>When used with <c>QuotaId</c>, this parameter further filters the results to include only nodes from the specified resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("FilterByResourceGroupIds")]
        [Validation(Required=false)]
        public string FilterByResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The GPU type. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T4</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("HealthCount")]
        [Validation(Required=false)]
        public string HealthCountShrink { get; set; }

        [NameInMap("HealthRate")]
        [Validation(Required=false)]
        public string HealthRateShrink { get; set; }

        [NameInMap("HyperNode")]
        [Validation(Required=false)]
        public string HyperNode { get; set; }

        [NameInMap("HyperZone")]
        [Validation(Required=false)]
        public string HyperZone { get; set; }

        [NameInMap("LayoutMode")]
        [Validation(Required=false)]
        public string LayoutMode { get; set; }

        [NameInMap("MachineGroupIds")]
        [Validation(Required=false)]
        public string MachineGroupIds { get; set; }

        /// <summary>
        /// <para>A comma-separated list of node names. Only nodes with names that match this list are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        /// <summary>
        /// <para>A comma-separated list of node statuses. If this parameter is omitted, this operation returns nodes of all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public string NodeStatuses { get; set; }

        /// <summary>
        /// <para>A comma-separated list of node specifications. If this parameter is omitted, this operation returns nodes of all specifications.</para>
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
        /// <item><description><para><c>desc</c>: Descending</para>
        /// </description></item>
        /// <item><description><para><c>asc</c>: Ascending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>A comma-separated list of order IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260590501560397</para>
        /// </summary>
        [NameInMap("OrderInstanceIds")]
        [Validation(Required=false)]
        public string OrderInstanceIds { get; set; }

        /// <summary>
        /// <para>A comma-separated list of order statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatuses")]
        [Validation(Required=false)]
        public string OrderStatuses { get; set; }

        /// <summary>
        /// <para>The page number. The first page is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
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
        /// <para>The ID of the resource quota that contains the nodes.</para>
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
        /// <para>A comma-separated list of resource group IDs. You must specify either this parameter or <c>QuotaId</c>.
        /// Constraints:</para>
        /// <ol>
        /// <item><description><para>The user ID of the request must match the user ID associated with the specified resource groups.</para>
        /// </description></item>
        /// <item><description><para>All specified resource groups must be of the same type.</para>
        /// </description></item>
        /// <item><description><para>All specified resource groups must be in the same VPC.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to return resource usage information. This parameter applies only when <c>QuotaId</c> is specified.</para>
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
