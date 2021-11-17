// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// cpu核数
        /// </summary>
        [NameInMap("CpuCoreCount")]
        [Validation(Required=false)]
        public long? CpuCoreCount { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [NameInMap("Discount")]
        [Validation(Required=false)]
        public float? Discount { get; set; }

        /// <summary>
        /// 国内价格
        /// </summary>
        [NameInMap("DomesticPrice")]
        [Validation(Required=false)]
        public float? DomesticPrice { get; set; }

        /// <summary>
        /// GPU卡数
        /// </summary>
        [NameInMap("GPUAmount")]
        [Validation(Required=false)]
        public long? GPUAmount { get; set; }

        /// <summary>
        /// GPU卡型
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// 实例接收带宽
        /// </summary>
        [NameInMap("InstanceBandwidthRx")]
        [Validation(Required=false)]
        public long? InstanceBandwidthRx { get; set; }

        /// <summary>
        /// 实例发送带宽
        /// </summary>
        [NameInMap("InstanceBandwidthTx")]
        [Validation(Required=false)]
        public long? InstanceBandwidthTx { get; set; }

        /// <summary>
        /// 实例每秒发包数
        /// </summary>
        [NameInMap("InstancePpsRx")]
        [Validation(Required=false)]
        public long? InstancePpsRx { get; set; }

        /// <summary>
        /// 实例每秒收包数
        /// </summary>
        [NameInMap("InstancePpsTx")]
        [Validation(Required=false)]
        public long? InstancePpsTx { get; set; }

        /// <summary>
        /// 规格族
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// 实例类型id
        /// </summary>
        [NameInMap("InstanceTypeId")]
        [Validation(Required=false)]
        public string InstanceTypeId { get; set; }

        /// <summary>
        /// 是否国际站用户
        /// </summary>
        [NameInMap("International")]
        [Validation(Required=false)]
        public bool? International { get; set; }

        /// <summary>
        /// 存储盘容量
        /// </summary>
        [NameInMap("LocalStorageCapacity")]
        [Validation(Required=false)]
        public long? LocalStorageCapacity { get; set; }

        /// <summary>
        /// 内存容量
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public float? MemorySize { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public float? Price { get; set; }

        /// <summary>
        /// 价格（人民币）
        /// </summary>
        [NameInMap("PriceCNY")]
        [Validation(Required=false)]
        public float? PriceCNY { get; set; }

        /// <summary>
        /// 价格（美元）
        /// </summary>
        [NameInMap("PriceUSD")]
        [Validation(Required=false)]
        public float? PriceUSD { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 系统盘存储类型
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// 系统盘容量
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public long? SystemDiskSize { get; set; }

    }

}
