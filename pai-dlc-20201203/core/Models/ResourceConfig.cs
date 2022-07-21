// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ResourceConfig : TeaModel {
        /// <summary>
        /// CPU核心数
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// GPU核心数
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// 显卡类型
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// 内存容量
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// 共享内存容量
        /// </summary>
        [NameInMap("SharedMemory")]
        [Validation(Required=false)]
        public string SharedMemory { get; set; }

    }

}
