// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class EcsSpec : TeaModel {
        /// <summary>
        /// 加速器类型
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// cpu数量
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// gpu数量
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// gpu类型
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// 规格类型
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 是否有库存
        /// </summary>
        [NameInMap("IsAvailable")]
        [Validation(Required=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Memory数量
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

    }

}
