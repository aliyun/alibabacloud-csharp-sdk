// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// 本分页中请求的实例列表
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<ListEcsSpecsResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class ListEcsSpecsResponseBodyEcsSpecs : TeaModel {
            /// <summary>
            /// 资源类型
            /// </summary>
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            /// <summary>
            /// CPU核数
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public long? CPU { get; set; }

            /// <summary>
            /// 货币单位
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// GPU卡数
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public long? GPU { get; set; }

            /// <summary>
            /// 显卡类型
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// 实例接收带宽
            /// </summary>
            [NameInMap("InstanceBandwidthRx")]
            [Validation(Required=false)]
            public long? InstanceBandwidthRx { get; set; }

            /// <summary>
            /// 实例规格
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// 内存大小(GB)
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// 价格
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// 系统盘大小(GB)
            /// </summary>
            [NameInMap("SystemDiskCapacity")]
            [Validation(Required=false)]
            public long? SystemDiskCapacity { get; set; }

        }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 实例总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
