// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class EcsSpec : TeaModel {
        /// <summary>
        /// cpu数量
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// gpu卡数
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// GPU卡类型
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 内存(GiB)
        /// </summary>
        [NameInMap("MemoryInGiB")]
        [Validation(Required=false)]
        public long? MemoryInGiB { get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// 磁盘大小(GiB)
        /// </summary>
        [NameInMap("SystemDiskSizeInGiB")]
        [Validation(Required=false)]
        public long? SystemDiskSizeInGiB { get; set; }

    }

}
