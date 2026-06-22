// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class InstanceType : TeaModel {
        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>X86</c>: X86 architecture.</para>
        /// </description></item>
        /// <item><description><para><c>ARM</c>: ARM architecture.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>The number of vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CpuCore")]
        [Validation(Required=false)]
        public int? CpuCore { get; set; }

        /// <summary>
        /// <para>The instance category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>General-purpose</c>: A general-purpose instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Compute-optimized</c>: A compute-optimized instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Memory-optimized</c>: A memory-optimized instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Big data</c>: A big data instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Local SSDs</c>: A local SSD instance type.</para>
        /// </description></item>
        /// <item><description><para><c>High Clock Speed</c>: A high clock speed instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Enhanced</c>: An enhanced instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Shared</c>: A shared instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Compute-optimized with GPU</c>: A compute-optimized instance type with GPUs.</para>
        /// </description></item>
        /// <item><description><para><c>Visual Compute-optimized</c>: A visual compute-optimized instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Heterogeneous Service</c>: A heterogeneous service instance type.</para>
        /// </description></item>
        /// <item><description><para><c>Compute-optimized with FPGA</c>: A compute-optimized instance type with FPGAs.</para>
        /// </description></item>
        /// <item><description><para><c>Compute-optimized with NPU</c>: A compute-optimized instance type with NPUs.</para>
        /// </description></item>
        /// <item><description><para><c>ECS Bare Metal</c>: An ECS Bare Metal instance.</para>
        /// </description></item>
        /// <item><description><para><c>Super Computing Cluster</c>: A supercomputing cluster instance type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Compute-optimized</para>
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>The ECS instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance type families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType_ { get; set; }

        /// <summary>
        /// <para>The instance type family. For valid values, see the ECS documentation for <a href="https://help.aliyun.com/document_detail/25621.html">DescribeInstanceTypeFamilies</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The number of local disks attached to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("LocalStorageAmount")]
        [Validation(Required=false)]
        public int? LocalStorageAmount { get; set; }

        /// <summary>
        /// <para>The capacity of each local disk attached to the instance, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("LocalStorageCapacity")]
        [Validation(Required=false)]
        public long? LocalStorageCapacity { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance type is I/O optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The instance type is I/O optimized.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The instance type is not I/O optimized.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Optimized")]
        [Validation(Required=false)]
        public bool? Optimized { get; set; }

    }

}
