// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of allocatable CPU cores on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AllocatableCpu")]
        [Validation(Required=false)]
        public string AllocatableCpu { get; set; }

        /// <summary>
        /// <para>The allocatable memory size on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("AllocatableMemory")]
        [Validation(Required=false)]
        public string AllocatableMemory { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// <para>The default GPU driver version of each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>535</para>
        /// </summary>
        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        /// <summary>
        /// <para>The number of ECS instances.</para>
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
        /// <para>The time when the machine group was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtExpiredTime")]
        [Validation(Required=false)]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// <para>The time when the machine group was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The time when the machine group was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtStartedTime")]
        [Validation(Required=false)]
        public string GmtStartedTime { get; set; }

        /// <summary>
        /// <para>The number of GPU cores on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public string Gpu { get; set; }

        /// <summary>
        /// <para>The GPU type of each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A100</para>
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The ID of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mgmioirqjgw6c5lg</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        /// <summary>
        /// <para>The memory size of each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <para>The name of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testMachineGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing duration. If PaymentDurationUnit is set to Month, valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public string PaymentDuration { get; set; }

        /// <summary>
        /// <para>The billing duration unit of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. Each resource group has a globally unique ID. You can use the resource group ID to retrieve the information about the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The instance is being created.</description></item>
        /// <item><description>Ready: The instance is running.</description></item>
        /// <item><description>Expiring: The instance is about to expire.</description></item>
        /// <item><description>Expired: The instance has expired.</description></item>
        /// <item><description>Stopping: The instance is being stopped.</description></item>
        /// <item><description>Stopped: The instance is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The GPU driver versions supported by nodes in the machine group.</para>
        /// </summary>
        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

        /// <summary>
        /// <para>The number of system-reserved CPU cores on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SystemReservedCpu")]
        [Validation(Required=false)]
        public string SystemReservedCpu { get; set; }

        /// <summary>
        /// <para>The size of system-reserved memory on each machine in the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("SystemReservedMemory")]
        [Validation(Required=false)]
        public string SystemReservedMemory { get; set; }

        /// <summary>
        /// <para>The list of tags to query. The value is a JSON string that contains up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetResourceGroupMachineGroupResponseBodyTags> Tags { get; set; }
        public class GetResourceGroupMachineGroupResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The value of the tag. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
