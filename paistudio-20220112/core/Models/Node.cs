// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("AllocatableCPU")]
        [Validation(Required=false)]
        public string AllocatableCPU { get; set; }

        [NameInMap("AllocatableMemory")]
        [Validation(Required=false)]
        public string AllocatableMemory { get; set; }

        [NameInMap("AncestorQuotaWorkloadNum")]
        [Validation(Required=false)]
        public long? AncestorQuotaWorkloadNum { get; set; }

        [NameInMap("AvailabilityZone")]
        [Validation(Required=false)]
        public string AvailabilityZone { get; set; }

        [NameInMap("BoundQuotas")]
        [Validation(Required=false)]
        public List<QuotaIdName> BoundQuotas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>281044699048527748</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("DescendantQuotaWorkloadNum")]
        [Validation(Required=false)]
        public long? DescendantQuotaWorkloadNum { get; set; }

        [NameInMap("DiskCapacity")]
        [Validation(Required=false)]
        public long? DiskCapacity { get; set; }

        [NameInMap("DiskPL")]
        [Validation(Required=false)]
        public string DiskPL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        [NameInMap("GPUMemory")]
        [Validation(Required=false)]
        public string GPUMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtExpiredTime")]
        [Validation(Required=false)]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("HyperZone")]
        [Validation(Required=false)]
        public string HyperZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsBound")]
        [Validation(Required=false)]
        public bool? IsBound { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitCPU")]
        [Validation(Required=false)]
        public string LimitCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LimitGPU")]
        [Validation(Required=false)]
        public string LimitGPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mg1234456</para>
        /// </summary>
        [NameInMap("MachineGroupId")]
        [Validation(Required=false)]
        public string MachineGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c8i.xlarge</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PodNum")]
        [Validation(Required=false)]
        public long? PodNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public string RequestGPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        [NameInMap("SelfQuotaWorkloadNum")]
        [Validation(Required=false)]
        public long? SelfQuotaWorkloadNum { get; set; }

        [NameInMap("SubNodes")]
        [Validation(Required=false)]
        public List<string> SubNodes { get; set; }

        [NameInMap("SystemReservedCPU")]
        [Validation(Required=false)]
        public string SystemReservedCPU { get; set; }

        [NameInMap("SystemReservedMemory")]
        [Validation(Required=false)]
        public string SystemReservedMemory { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<UserInfo> Users { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public long? WorkloadNum { get; set; }

    }

}
