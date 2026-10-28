// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class MachineGroup : TeaModel {
        /// <summary>
        /// <para>The number of allocatable CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("AllocatableCpu")]
        [Validation(Required=false)]
        public long? AllocatableCpu { get; set; }

        /// <summary>
        /// <para>The allocatable memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("AllocatableMemory")]
        [Validation(Required=false)]
        public long? AllocatableMemory { get; set; }

        /// <summary>
        /// <para>The number of CPU cores in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The ID of the machine group creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612285282502324</para>
        /// </summary>
        [NameInMap("CreatorID")]
        [Validation(Required=false)]
        public string CreatorID { get; set; }

        /// <summary>
        /// <para>The default driver supported by the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        /// <summary>
        /// <para>The cloud disk size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DiskCapacity")]
        [Validation(Required=false)]
        public long? DiskCapacity { get; set; }

        /// <summary>
        /// <para>The cloud disk performance level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DiskPL")]
        [Validation(Required=false)]
        public string DiskPL { get; set; }

        /// <summary>
        /// <para>The resource count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EcsCount")]
        [Validation(Required=false)]
        public long? EcsCount { get; set; }

        /// <summary>
        /// <para>The ECS instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtExpiredTime")]
        [Validation(Required=false)]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtStartedTime")]
        [Validation(Required=false)]
        public string GmtStartedTime { get; set; }

        /// <summary>
        /// <para>The number of GPUs in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU memory size of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public long? GpuMemory { get; set; }

        /// <summary>
        /// <para>The GPU type of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A100</para>
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The machine group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        /// <summary>
        /// <para>The memory size of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        /// <summary>
        /// <para>The duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public string PaymentDuration { get; set; }

        /// <summary>
        /// <para>region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The machine group error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The machine group error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The machine group status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of NVIDIA GPU driver versions supported by the machine group.</para>
        /// </summary>
        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

        /// <summary>
        /// <para>The number of system-reserved CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SystemReservedCpu")]
        [Validation(Required=false)]
        public long? SystemReservedCpu { get; set; }

        /// <summary>
        /// <para>The size of system-reserved memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("SystemReservedMemory")]
        [Validation(Required=false)]
        public long? SystemReservedMemory { get; set; }

    }

}
