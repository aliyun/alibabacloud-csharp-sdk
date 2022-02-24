// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ResourceInstance : TeaModel {
        /// <summary>
        /// 实例是否自动续费
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// 实例的计费类型
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// 实例的创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 实例过期时间
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 实例的Cpu个数
        /// </summary>
        [NameInMap("InstanceCpuCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCount { get; set; }

        /// <summary>
        /// 实例的Gpu个数
        /// </summary>
        [NameInMap("InstanceGpuCount")]
        [Validation(Required=false)]
        public int? InstanceGpuCount { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例IP
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// 实例的内存大小
        /// </summary>
        [NameInMap("InstanceMemory")]
        [Validation(Required=false)]
        public string InstanceMemory { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 实例的机型
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 实例被使用的CPU数量
        /// </summary>
        [NameInMap("InstanceUsedCpu")]
        [Validation(Required=false)]
        public float? InstanceUsedCpu { get; set; }

        /// <summary>
        /// 实例被使用的GPU数量
        /// </summary>
        [NameInMap("InstanceUsedGpu")]
        [Validation(Required=false)]
        public int? InstanceUsedGpu { get; set; }

        /// <summary>
        /// 实例被使用的内存大小
        /// </summary>
        [NameInMap("InstanceUsedMemory")]
        [Validation(Required=false)]
        public string InstanceUsedMemory { get; set; }

    }

}
