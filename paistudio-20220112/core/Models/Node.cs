// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// <para>The accelerator type of the resource node instance, such as CPU or GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The number of allocatable CPU cores.</para>
        /// </summary>
        [NameInMap("AllocatableCPU")]
        [Validation(Required=false)]
        public string AllocatableCPU { get; set; }

        /// <summary>
        /// <para>The amount of allocatable memory in GiB.</para>
        /// </summary>
        [NameInMap("AllocatableMemory")]
        [Validation(Required=false)]
        public string AllocatableMemory { get; set; }

        [NameInMap("AncestorQuotaWorkloadNum")]
        [Validation(Required=false)]
        public long? AncestorQuotaWorkloadNum { get; set; }

        [NameInMap("AvailabilityZone")]
        [Validation(Required=false)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// <para>The list of quotas that are bound to the node.</para>
        /// </summary>
        [NameInMap("BoundQuotas")]
        [Validation(Required=false)]
        public List<QuotaIdName> BoundQuotas { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the resource node.</para>
        /// 
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
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// <para>The GPU memory size in GiB.</para>
        /// </summary>
        [NameInMap("GPUMemory")]
        [Validation(Required=false)]
        public string GPUMemory { get; set; }

        /// <summary>
        /// <para>The GPU model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The time when the resource node was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        [Obsolete]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the resource node expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtExpiredTime")]
        [Validation(Required=false)]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// <para>The time when the resource node was last modified.</para>
        /// 
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
        /// <para>Indicates whether the node is bound to a quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsBound")]
        [Validation(Required=false)]
        public bool? IsBound { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LimitCPU")]
        [Validation(Required=false)]
        public string LimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LimitGPU")]
        [Validation(Required=false)]
        public string LimitGPU { get; set; }

        /// <summary>
        /// <para>The maximum memory size in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        /// <summary>
        /// <para>The ID of the machine group to which the resource node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1234456</para>
        /// </summary>
        [NameInMap("MachineGroupId")]
        [Validation(Required=false)]
        public string MachineGroupId { get; set; }

        /// <summary>
        /// <para>The memory size in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <para>The name of the resource node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The status of the resource node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        /// <summary>
        /// <para>The instance type of the resource node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c8i.xlarge</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The order status of the resource node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <para>The number of pods on the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PodNum")]
        [Validation(Required=false)]
        public long? PodNum { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The number of requested CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        /// <summary>
        /// <para>The number of requested GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public string RequestGPU { get; set; }

        /// <summary>
        /// <para>The requested memory size in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the resource group to which the resource node belongs.</para>
        /// 
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

        /// <summary>
        /// <para>The number of CPU cores that are reserved for the system.</para>
        /// </summary>
        [NameInMap("SystemReservedCPU")]
        [Validation(Required=false)]
        public string SystemReservedCPU { get; set; }

        /// <summary>
        /// <para>The amount of memory that is reserved for the system in GiB.</para>
        /// </summary>
        [NameInMap("SystemReservedMemory")]
        [Validation(Required=false)]
        public string SystemReservedMemory { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<UserInfo> Users { get; set; }

        /// <summary>
        /// <para>The number of workloads on the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public long? WorkloadNum { get; set; }

    }

}
