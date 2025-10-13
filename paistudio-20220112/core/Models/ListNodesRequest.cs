// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>quotamtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("FilterByQuotaId")]
        [Validation(Required=false)]
        public string FilterByQuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("FilterByResourceGroupIds")]
        [Validation(Required=false)]
        public string FilterByResourceGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>T4</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("HyperNode")]
        [Validation(Required=false)]
        public string HyperNode { get; set; }

        [NameInMap("HyperZone")]
        [Validation(Required=false)]
        public string HyperZone { get; set; }

        [NameInMap("MachineGroupIds")]
        [Validation(Required=false)]
        public string MachineGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public string NodeStatuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c6.xlarge</para>
        /// </summary>
        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public string NodeTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260590501560397</para>
        /// </summary>
        [NameInMap("OrderInstanceIds")]
        [Validation(Required=false)]
        public string OrderInstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatuses")]
        [Validation(Required=false)]
        public string OrderStatuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>rg69rj0leslwdnbe</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
