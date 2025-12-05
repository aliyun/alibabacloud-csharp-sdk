// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResidentResourceAllocation : TeaModel {
        /// <summary>
        /// <para>使用该资源池的函数名</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>实例数</para>
        /// </summary>
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>函数的别名</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>CPU 占用总核数</para>
        /// </summary>
        [NameInMap("totalCpuCores")]
        [Validation(Required=false)]
        public double? TotalCpuCores { get; set; }

        /// <summary>
        /// <para>占用磁盘大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalDiskSize")]
        [Validation(Required=false)]
        public double? TotalDiskSize { get; set; }

        /// <summary>
        /// <para>占用显存大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalGpuMemorySize")]
        [Validation(Required=false)]
        public double? TotalGpuMemorySize { get; set; }

        /// <summary>
        /// <para>内存占用大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalMemorySize")]
        [Validation(Required=false)]
        public double? TotalMemorySize { get; set; }

    }

}
