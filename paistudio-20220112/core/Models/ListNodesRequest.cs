// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The accelerator type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CPU</description></item>
        /// <item><description>GPU</description></item>
        /// </list>
        /// <para>If this parameter is left empty, all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The zone where the nodes reside.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0</para>
        /// </summary>
        [NameInMap("AvailabilityZone")]
        [Validation(Required=false)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// <para>The clique ID.</para>
        /// </summary>
        [NameInMap("CliqueID")]
        [Validation(Required=false)]
        public string CliqueID { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL2</para>
        /// </summary>
        [NameInMap("DiskPL")]
        [Validation(Required=false)]
        public string DiskPL { get; set; }

        /// <summary>
        /// <para>Used together with ResourceGroupIds to display nodes in the resource group that are bound to specific quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("FilterByQuotaId")]
        [Validation(Required=false)]
        public string FilterByQuotaId { get; set; }

        /// <summary>
        /// <para>Used together with QuotaId to display nodes in the quota that belong to specific resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("FilterByResourceGroupIds")]
        [Validation(Required=false)]
        public string FilterByResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The GPU card type. Fuzzy match is supported.</para>
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
        public ListNodesRequestHealthCount HealthCount { get; set; }
        public class ListNodesRequestHealthCount : TeaModel {
            /// <summary>
            /// <para>The comparison operator. Valid values: ge, gte, eq, lte, and lt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>le</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The threshold for the number of healthy nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public int? Value { get; set; }

        }

        /// <summary>
        /// <para>The health rate of the nodes, which is the proportion of healthy nodes.</para>
        /// </summary>
        [NameInMap("HealthRate")]
        [Validation(Required=false)]
        public ListNodesRequestHealthRate HealthRate { get; set; }
        public class ListNodesRequestHealthRate : TeaModel {
            /// <summary>
            /// <para>The comparison operator. Valid values: ge, gte, eq, lte, and lt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ge</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The health rate threshold. Unit: percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public int? Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the hypernode.</para>
        /// </summary>
        [NameInMap("HyperNode")]
        [Validation(Required=false)]
        public string HyperNode { get; set; }

        /// <summary>
        /// <para>The hyperzone where the nodes reside.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0</para>
        /// </summary>
        [NameInMap("HyperZone")]
        [Validation(Required=false)]
        public string HyperZone { get; set; }

        /// <summary>
        /// <para>The layout mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tree</para>
        /// </summary>
        [NameInMap("LayoutMode")]
        [Validation(Required=false)]
        public string LayoutMode { get; set; }

        /// <summary>
        /// <para>The IDs of the machine groups to which the nodes belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg124</para>
        /// </summary>
        [NameInMap("MachineGroupIds")]
        [Validation(Required=false)]
        public string MachineGroupIds { get; set; }

        /// <summary>
        /// <para>The names of the nodes to display. Separate multiple names with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        /// <summary>
        /// <para>The status of the node. Separate multiple statuses with commas. If you do not specify this parameter, the system returns a list of nodes in all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public string NodeStatuses { get; set; }

        /// <summary>
        /// <para>The list of resource node specifications. Separate multiple specifications with commas. If you do not specify this parameter, the system returns a list of machines of all resource node specifications.</para>
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
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
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
        /// <para>The order status of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatuses")]
        [Validation(Required=false)]
        public string OrderStatuses { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of the node order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The number of pods on the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodNum")]
        [Validation(Required=false)]
        public int? PodNum { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota to which the node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The reason codes for the current status of the nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CordonByUser</para>
        /// </summary>
        [NameInMap("ReasonCodes")]
        [Validation(Required=false)]
        public string ReasonCodes { get; set; }

        /// <summary>
        /// <para>The list of resource group IDs. Separate multiple IDs with commas. You must specify either this parameter or QuotaId.
        /// Constraints:</para>
        /// <ol>
        /// <item><description>The user ID of the specified resource group must match the user ID of the request.</description></item>
        /// <item><description>The resource groups in the list must be of the same type.</description></item>
        /// <item><description>The VPCs associated with the resource groups in the list must be the same.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>rg-dlc</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The field based on which the results are sorted.</para>
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

        /// <summary>
        /// <para>The number of workloads on the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public int? WorkloadNum { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the nodes belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
