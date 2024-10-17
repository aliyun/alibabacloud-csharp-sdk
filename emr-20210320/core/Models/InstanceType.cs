// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class InstanceType : TeaModel {
        /// <summary>
        /// <para>cpu架构。</para>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>vCPU内核数目。</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CpuCore")]
        [Validation(Required=false)]
        public int? CpuCore { get; set; }

        /// <summary>
        /// <para>实例规格分类。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>General-purpose： 通用型。</description></item>
        /// <item><description>Compute-optimized：计算型。</description></item>
        /// <item><description>Memory-optimized：内存型。</description></item>
        /// <item><description>Big data：大数据型。</description></item>
        /// <item><description>Local SSDs ：本地SSD型。</description></item>
        /// <item><description>High Clock Speed ：高主频型。</description></item>
        /// <item><description>Enhanced ：增强型。</description></item>
        /// <item><description>Shared：共享型。</description></item>
        /// <item><description>Compute-optimized with GPU ：GPU计算型。</description></item>
        /// <item><description>Visual Compute-optimized ：视觉计算型。</description></item>
        /// <item><description>Heterogeneous Service ：异构服务型。</description></item>
        /// <item><description>Compute-optimized with FPGA ：FPGA计算型。</description></item>
        /// <item><description>Compute-optimized with NPU ：NPU计算型。</description></item>
        /// <item><description>ECS Bare Metal ：弹性裸金属服务器。</description></item>
        /// <item><description>Super Computing Cluster：超级计算集群。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Compute-optimized</para>
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>实例规格。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType_ { get; set; }

        /// <summary>
        /// <para>实例规格所属的实例规格族。取值请参见DescribeInstanceTypeFamilies。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>实例挂载的本地盘的数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("LocalStorageAmount")]
        [Validation(Required=false)]
        public int? LocalStorageAmount { get; set; }

        /// <summary>
        /// <para>实例挂载的本地盘的单盘容量。单位：GiB</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("LocalStorageCapacity")]
        [Validation(Required=false)]
        public long? LocalStorageCapacity { get; set; }

        /// <summary>
        /// <para>是否IO优化类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Optimized")]
        [Validation(Required=false)]
        public bool? Optimized { get; set; }

    }

}
