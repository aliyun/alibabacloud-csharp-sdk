// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCustinsResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCustinsResourceInfoResponseBodyData> Data { get; set; }
        public class DescribeCustinsResourceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The deadline for the CPU adjustment.
            /// </summary>
            [NameInMap("CpuAdjustDeadline")]
            [Validation(Required=false)]
            public string CpuAdjustDeadline { get; set; }

            /// <summary>
            /// The maximum percentage of the system CPU resources that the instance can use.
            /// </summary>
            [NameInMap("CpuAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxRatio { get; set; }

            /// <summary>
            /// The maximum CPU utilization.
            /// </summary>
            [NameInMap("CpuAdjustableMaxValue")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxValue { get; set; }

            /// <summary>
            /// The CPU utilization.
            /// </summary>
            [NameInMap("CpuIncreaseRatio")]
            [Validation(Required=false)]
            public string CpuIncreaseRatio { get; set; }

            /// <summary>
            /// The CPU utilization. Unit: percentage.
            /// </summary>
            [NameInMap("CpuIncreaseRatioValue")]
            [Validation(Required=false)]
            public string CpuIncreaseRatioValue { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The maximum IOPS.
            /// </summary>
            [NameInMap("IopsAdjustableMaxValue")]
            [Validation(Required=false)]
            public string IopsAdjustableMaxValue { get; set; }

            /// <summary>
            /// The deadline for the adjustment of the maximum number of connections.
            /// </summary>
            [NameInMap("MaxConnAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxConnAdjustDeadline { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MaxConnAdjustableMaxValue { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatio { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatioValue { get; set; }

            /// <summary>
            /// The deadline for the adjustment of the maximum IOPS.
            /// </summary>
            [NameInMap("MaxIopsAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxIopsAdjustDeadline { get; set; }

            /// <summary>
            /// The maximum IOPS.
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatio { get; set; }

            /// <summary>
            /// The maximum IOPS that can be supported by the instance.
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatioValue { get; set; }

            /// <summary>
            /// The maximum percentage of the system memory that the instance can use.
            /// </summary>
            [NameInMap("MemAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string MemAdjustableMaxRatio { get; set; }

            /// <summary>
            /// The maximum value of the resources to be evaluated.
            /// </summary>
            [NameInMap("MemAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MemAdjustableMaxValue { get; set; }

            /// <summary>
            /// The deadline for the memory adjustment.
            /// </summary>
            [NameInMap("MemoryAdjustDeadline")]
            [Validation(Required=false)]
            public string MemoryAdjustDeadline { get; set; }

            /// <summary>
            /// The memory increase percentage.
            /// </summary>
            [NameInMap("MemoryIncreaseRatio")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatio { get; set; }

            /// <summary>
            /// The memory usage. Unit: MB.
            /// </summary>
            [NameInMap("MemoryIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatioValue { get; set; }

            /// <summary>
            /// The number of CPUs of the instance.
            /// </summary>
            [NameInMap("OriginCpu")]
            [Validation(Required=false)]
            public string OriginCpu { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections.
            /// </summary>
            [NameInMap("OriginMaxConn")]
            [Validation(Required=false)]
            public string OriginMaxConn { get; set; }

            /// <summary>
            /// The maximum IOPS.
            /// </summary>
            [NameInMap("OriginMaxIops")]
            [Validation(Required=false)]
            public string OriginMaxIops { get; set; }

            /// <summary>
            /// The actual memory used. Unit: MB.
            /// </summary>
            [NameInMap("OriginMemory")]
            [Validation(Required=false)]
            public string OriginMemory { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
