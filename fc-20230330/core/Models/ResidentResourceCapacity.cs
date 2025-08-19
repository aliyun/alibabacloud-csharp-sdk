// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResidentResourceCapacity : TeaModel {
        /// <summary>
        /// <para>GPU 卡型</para>
        /// </summary>
        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>CPU 总核数</para>
        /// </summary>
        [NameInMap("totalCpuCores")]
        [Validation(Required=false)]
        public long? TotalCpuCores { get; set; }

        /// <summary>
        /// <para>总磁盘大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalDiskSize")]
        [Validation(Required=false)]
        public long? TotalDiskSize { get; set; }

        /// <summary>
        /// <para>GPU总卡数</para>
        /// </summary>
        [NameInMap("totalGpuCards")]
        [Validation(Required=false)]
        public long? TotalGpuCards { get; set; }

        /// <summary>
        /// <para>总显存大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalGpuMemorySize")]
        [Validation(Required=false)]
        public long? TotalGpuMemorySize { get; set; }

        /// <summary>
        /// <para>总内存大小，单位 GB</para>
        /// </summary>
        [NameInMap("totalMemorySize")]
        [Validation(Required=false)]
        public long? TotalMemorySize { get; set; }

    }

}
