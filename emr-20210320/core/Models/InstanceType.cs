// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class InstanceType : TeaModel {
        /// <summary>
        /// cpu架构。
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// vCPU内核数目。
        /// </summary>
        [NameInMap("CpuCore")]
        [Validation(Required=false)]
        public int? CpuCore { get; set; }

        /// <summary>
        /// 实例规格分类。取值范围：
        /// - General-purpose： 通用型。
        /// - Compute-optimized：计算型。
        /// - Memory-optimized：内存型。
        /// - Big data：大数据型。
        /// - Local SSDs ：本地SSD型。
        /// - High Clock Speed ：高主频型。
        /// - Enhanced ：增强型。
        /// - Shared：共享型。
        /// - Compute-optimized with GPU ：GPU计算型。
        /// - Visual Compute-optimized ：视觉计算型。
        /// - Heterogeneous Service ：异构服务型。
        /// - Compute-optimized with FPGA ：FPGA计算型。
        /// - Compute-optimized with NPU ：NPU计算型。
        /// - ECS Bare Metal ：弹性裸金属服务器。
        /// - Super Computing Cluster：超级计算集群。
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// 实例规格。
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType_ { get; set; }

        /// <summary>
        /// 实例规格所属的实例规格族。取值请参见DescribeInstanceTypeFamilies。
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// 实例挂载的本地盘的数量。
        /// </summary>
        [NameInMap("LocalStorageAmount")]
        [Validation(Required=false)]
        public int? LocalStorageAmount { get; set; }

        /// <summary>
        /// 实例挂载的本地盘的单盘容量。单位：GiB
        /// </summary>
        [NameInMap("LocalStorageCapacity")]
        [Validation(Required=false)]
        public long? LocalStorageCapacity { get; set; }

        /// <summary>
        /// 是否IO优化类型。
        /// </summary>
        [NameInMap("Optimized")]
        [Validation(Required=false)]
        public bool? Optimized { get; set; }

    }

}
