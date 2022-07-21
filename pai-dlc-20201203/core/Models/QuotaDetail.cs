// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class QuotaDetail : TeaModel {
        /// <summary>
        /// CPU核数
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// GPU卡数
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// GPU详情
        /// </summary>
        [NameInMap("GPUDetails")]
        [Validation(Required=false)]
        public List<GPUDetail> GPUDetails { get; set; }

        /// <summary>
        /// GPU卡型
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// GPU卡型全名
        /// </summary>
        [NameInMap("GPUTypeFullName")]
        [Validation(Required=false)]
        public string GPUTypeFullName { get; set; }

        /// <summary>
        /// 内存容量
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
